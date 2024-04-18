namespace TexEditor
{
    partial class F
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip = new ContextMenuStrip(components);
            solveToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            preferenciasToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toggleCompilationStrip = new ToolStripMenuItem();
            vistaToolStripMenuItem = new ToolStripMenuItem();
            toggleViewerToolStrip = new ToolStripMenuItem();
            recompilarToolStripMenuItem = new ToolStripMenuItem();
            sistemasToolStrip = new ToolStripMenuItem();
            x2ToolStrip = new ToolStripMenuItem();
            x3ToolStrip = new ToolStripMenuItem();
            ecuacionesToolStrip = new ToolStripMenuItem();
            rtb = new RichTextBox();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            splitContainer = new SplitContainer();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            contextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { solveToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(119, 26);
            // 
            // solveToolStripMenuItem
            // 
            solveToolStripMenuItem.Name = "solveToolStripMenuItem";
            solveToolStripMenuItem.Size = new Size(118, 22);
            solveToolStripMenuItem.Text = "Resolver";
            solveToolStripMenuItem.Click += solveSelected;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { preferenciasToolStripMenuItem, archivoToolStripMenuItem, vistaToolStripMenuItem, sistemasToolStrip, ecuacionesToolStrip });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // preferenciasToolStripMenuItem
            // 
            preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            preferenciasToolStripMenuItem.Size = new Size(83, 20);
            preferenciasToolStripMenuItem.Text = "Preferencias";
            preferenciasToolStripMenuItem.Click += settings;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripSeparator1, exportarToolStripMenuItem, toolStripSeparator2, toggleCompilationStrip });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(237, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += openFile;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(237, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += save;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            guardarComoToolStripMenuItem.Size = new Size(237, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como     ";
            guardarComoToolStripMenuItem.Click += saveAs;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(234, 6);
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDFToolStripMenuItem });
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(237, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(95, 22);
            pDFToolStripMenuItem.Text = "PDF";
            pDFToolStripMenuItem.Click += exportPdf;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(234, 6);
            // 
            // toggleCompilationStrip
            // 
            toggleCompilationStrip.Name = "toggleCompilationStrip";
            toggleCompilationStrip.Size = new Size(237, 22);
            toggleCompilationStrip.Text = "Compilar";
            toggleCompilationStrip.Click += toggleCompilation;
            // 
            // vistaToolStripMenuItem
            // 
            vistaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toggleViewerToolStrip, recompilarToolStripMenuItem });
            vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            vistaToolStripMenuItem.Size = new Size(44, 20);
            vistaToolStripMenuItem.Text = "Vista";
            // 
            // toggleViewerToolStrip
            // 
            toggleViewerToolStrip.Name = "toggleViewerToolStrip";
            toggleViewerToolStrip.Size = new Size(173, 22);
            toggleViewerToolStrip.Text = "Mostar vista previa";
            toggleViewerToolStrip.Click += toggleViewer;
            // 
            // recompilarToolStripMenuItem
            // 
            recompilarToolStripMenuItem.Name = "recompilarToolStripMenuItem";
            recompilarToolStripMenuItem.Size = new Size(173, 22);
            recompilarToolStripMenuItem.Text = "Recompilar";
            recompilarToolStripMenuItem.Click += compileAndReload;
            // 
            // sistemasToolStrip
            // 
            sistemasToolStrip.DropDownItems.AddRange(new ToolStripItem[] { x2ToolStrip, x3ToolStrip });
            sistemasToolStrip.Name = "sistemasToolStrip";
            sistemasToolStrip.Size = new Size(143, 20);
            sistemasToolStrip.Text = "Sistemas de ecuaciones";
            // 
            // x2ToolStrip
            // 
            x2ToolStrip.Name = "x2ToolStrip";
            x2ToolStrip.Size = new Size(92, 22);
            x2ToolStrip.Text = "2x2";
            x2ToolStrip.Click += sistemasEcuaciones2x2;
            // 
            // x3ToolStrip
            // 
            x3ToolStrip.Name = "x3ToolStrip";
            x3ToolStrip.Size = new Size(92, 22);
            x3ToolStrip.Text = "3x3";
            x3ToolStrip.Click += sistemasEcuaciones3x3;
            // 
            // ecuacionesToolStrip
            // 
            ecuacionesToolStrip.Name = "ecuacionesToolStrip";
            ecuacionesToolStrip.Size = new Size(78, 20);
            ecuacionesToolStrip.Text = "Ecuaciones";
            ecuacionesToolStrip.Click += ecuaciones;
            // 
            // rtb
            // 
            rtb.AcceptsTab = true;
            rtb.AutoWordSelection = true;
            rtb.ContextMenuStrip = contextMenuStrip;
            rtb.DetectUrls = false;
            rtb.Dock = DockStyle.Fill;
            rtb.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb.Location = new Point(0, 0);
            rtb.Name = "rtb";
            rtb.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtb.Size = new Size(784, 387);
            rtb.TabIndex = 5;
            rtb.Text = "";
            rtb.WordWrap = false;
            rtb.TextChanged += rtbChanged;
            rtb.KeyPress += rtbKeyPress;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 0);
            webView.Name = "webView";
            webView.Size = new Size(96, 100);
            webView.TabIndex = 7;
            webView.ZoomFactor = 1D;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 24);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(rtb);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(webView);
            splitContainer.Panel2Collapsed = true;
            splitContainer.Size = new Size(784, 387);
            splitContainer.SplitterDistance = 407;
            splitContainer.TabIndex = 8;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Title = "Guardar como";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "LaTeX|*.tex|All files|*.*";
            // 
            // F
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(splitContainer);
            Controls.Add(menuStrip);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "F";
            Text = "LaTeX Editor";
            contextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem solveToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStrip;
        private ToolStripMenuItem x2ToolStrip;
        private ToolStripMenuItem x3ToolStrip;
        private ToolStripMenuItem ecuacionesToolStrip;
        private ToolStripMenuItem vistaToolStripMenuItem;
        private RichTextBox rtb;
        private ToolStripMenuItem toggleViewerToolStrip;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem toggleCompilationStrip;
        private SplitContainer splitContainer;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private ToolStripMenuItem recompilarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem preferenciasToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private OpenFileDialog openFileDialog;
    }
}
