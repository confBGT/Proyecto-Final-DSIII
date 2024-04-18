using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Configuration;
using System.ComponentModel;
using System.Linq.Expressions;

namespace TexEditor
{
    public partial class F : Form
    {
        private static string WOLFRAM_ID = "2UTEJ5-6EWVJTPVQT";
        private static string URL = "https://api.wolframalpha.com/v2";

        private static HttpClient client = new();

        private static Guid instanceId = Guid.NewGuid();
        private static string tempPath = Path.Combine(Path.GetTempPath(), "TEX");

        private string lastSaved = string.Empty;
        private bool autoCompilation = false;
        private uint charsSinceSave = 0;
        private bool isSaved = true;

        private TexWrapper tex = new TexWrapper();

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private CompilationMode compilationMode;

        public F()
        {
            InitializeComponent();

            Directory.CreateDirectory(tempPath);

            string initialText = $$"""\documentclass{{{Properties.Settings.Default.DocumentClass}}}\n\n\author{{{Properties.Settings.Default.Author}}}\n\n\begin{document}\n\n\end{document}""";
            initialText = initialText.Replace(@"\n", Environment.NewLine);
            rtb.Text = initialText;

            FormClosing += onClose;

            Properties.Settings.Default.PropertyChanged += settingChanged;

            timer.Tick += new EventHandler(compileAndReload);

            compilationMode = (CompilationMode)Properties.Settings.Default.CompilationMode;
            timer.Interval = 1000 * Properties.Settings.Default.CompilationTime;

            webView.Source = new Uri(instanceFile("pdf"));
        }

        private void settingChanged(object? sender, PropertyChangedEventArgs e)
        {
            CompilationMode oldCompilationMode = compilationMode;
            compilationMode = (CompilationMode)Properties.Settings.Default.CompilationMode;
            timer.Interval = 1000 * Properties.Settings.Default.CompilationTime;

            if (autoCompilation)
            {
                if (oldCompilationMode == CompilationMode.Chars && compilationMode == CompilationMode.Time) timer.Start();
                if (oldCompilationMode == CompilationMode.Time && compilationMode == CompilationMode.Chars) timer.Stop();
            }
        }

        private static string instanceFile(string extension)
        {
            return Path.Combine(tempPath, $"{instanceId}.{extension}");
        }

        private void cleanup()
        {
            string[] extensions = { "pdf", "tex", "aux", "log" };

            foreach (string ext in extensions)
            {
                File.Delete(instanceFile(ext));
            }
        }

        private void onClose(object? sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("Salir sin guardar cambios?", "LaTeX Editor", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        return;
                    case DialogResult.Yes:
                        cleanup();
                        return;
                }
            }
        }

        private string urlBuilder(string query)
        {
            return $"{URL}/query?appid={WOLFRAM_ID}&input={query}&output=json";
        }

        private async void solveSelected(object sender, EventArgs e)
        {
            string query = rtb.SelectedText;

            if (query == string.Empty)
            {
                MessageBox.Show("Seleccione el problema a resolver", "LaTeX Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string url = urlBuilder(query);
            Clipboard.SetText(url);

            string jsonString = await client.GetStringAsync(url);
            WolframResult? result = JsonSerializer.Deserialize<WolframResult>(jsonString);

            if (result == null || result.queryresult == null)
            {
                MessageBox.Show("Error de conexion con Wolfram|Alpha APIs", "LaTeX Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!result.queryresult.success)
            {
                MessageBox.Show("No se pudo resolver el problema", "LaTeX Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WolframPod mainPod = result.queryresult.pods.First();
            WolframPod? mainSubpod = mainPod.subpods?.First();

            if (mainSubpod == null)
            {
                MessageBox.Show("Error reconociendo la respuesta", "LaTeX Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImageBox imageBox = new ImageBox(mainSubpod);
            imageBox.Show();
        }

        private void toggleViewer(object sender, EventArgs e)
        {
            toggleViewerToolStrip.Checked ^= true;
            splitContainer.Panel2Collapsed ^= true;

            webView.Reload();
        }

        private void saveToTemp()
        {
            rtb.SaveFile(instanceFile("tex"), RichTextBoxStreamType.PlainText);
        }

        private void compileAndReload(object? sender, EventArgs e)
        {
            saveToTemp();

            tex.target = instanceFile("tex");
            tex.outputDir = tempPath;
            tex.Compile();

            webView.Reload();
        }

        private void toggleCompilation(object sender, EventArgs e)
        {
            toggleCompilationStrip.Checked ^= true;
            autoCompilation ^= true;

            if (!autoCompilation)
            {
                if (compilationMode == CompilationMode.Time) timer.Stop();
                return;
            }

            if (compilationMode == CompilationMode.Time) timer.Start();

            compileAndReload(sender, e);
        }

        private void save(object sender, EventArgs e)
        {
            if (lastSaved == string.Empty)
            {
                saveAs(sender, e);
                return;
            }

            File.WriteAllText(lastSaved, rtb.Text);
            isSaved = true;
        }

        private void saveAs(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "LaTeX|*.tex";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                File.WriteAllText(saveFileDialog.FileName, rtb.Text);
                lastSaved = saveFileDialog.FileName;
                isSaved = true;
            }
        }

        private void exportPdf(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "PDF|*.pdf";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                string? outputDir = Path.GetDirectoryName(saveFileDialog.FileName);
                string? fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);

                if (outputDir == null || fileName == null)
                {
                    return;
                }

                saveToTemp();

                tex.target = instanceFile("tex");
                tex.outputDir = outputDir;
                tex.fileName = fileName;
                tex.Compile();
            }
        }

        private void openFile(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("Salir sin guardar?", "LaTeX Editor", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        save(sender, e);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            openFileDialog.ShowDialog();
            
            if (openFileDialog.FileName != string.Empty)
            {
                rtb.Text = File.ReadAllText(openFileDialog.FileName);
                instanceId = Guid.NewGuid();
                webView.Source = new Uri(instanceFile("pdf"));
                webView.Reload();
            }
        }

        private void rtbChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }

        private void rtbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || !autoCompilation)
            {
                return;
            }

            charsSinceSave++;

            if (compilationMode == CompilationMode.Chars && charsSinceSave > Properties.Settings.Default.CompilationChars)
            {
                charsSinceSave = 0;
                compileAndReload(sender, e);
            }
        }

        private void sistemasEcuaciones2x2(object sender, EventArgs e)
        {
            Sistemas2x2 form = new Sistemas2x2();
            form.Show();
        }

        private void sistemasEcuaciones3x3(object sender, EventArgs e)
        {
            Sistemas3x3 form = new Sistemas3x3();
            form.Show();
        }

        private void ecuaciones(object sender, EventArgs e)
        {
            Ecuaciones form = new Ecuaciones();
            form.Show();
        }

        private void settings(object sender, EventArgs e)
        {
            EditorSettings form = new EditorSettings();
            form.ShowDialog();
        }
    }
}
