using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace TexEditor
{
    public enum CompilationMode
    {
        Time,
        Chars
    }

    public partial class EditorSettings : Form
    {
        CompilationMode compilationMode;

        public EditorSettings()
        {
            InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            compilationMode = (CompilationMode)Properties.Settings.Default.CompilationMode;
            tbDocumentClass.Text = Properties.Settings.Default.DocumentClass;
            tbAuthor.Text = Properties.Settings.Default.Author;
            updateCompilationMode();

            tbCompilationTime.Text = Properties.Settings.Default.CompilationTime.ToString();
            tbCompilationChars.Text = Properties.Settings.Default.CompilationChars.ToString();
        }

        private void updateCompilationMode()
        {
            switch (compilationMode)
            {
                case CompilationMode.Time:
                    rbtnCompilationTime.Checked = true;
                    tbCompilationTime.Enabled = true;
                    tbCompilationChars.Enabled = false;
                    break;
                case CompilationMode.Chars:
                    rbtnCompilationChars.Checked = true;
                    tbCompilationChars.Enabled = true;
                    tbCompilationTime.Enabled = false;
                    break;
            }
        }

        private void rbtnCompilationModeChanged(object sender, EventArgs e)
        {
            if (rbtnCompilationChars.Checked)
            {
                compilationMode = CompilationMode.Chars;
            }
            else
            {
                compilationMode = CompilationMode.Time;
            }

            updateCompilationMode();
        }

        private void numericFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.CompilationMode = (short)compilationMode;
            Properties.Settings.Default.CompilationTime = Convert.ToInt32(tbCompilationTime.Text);
            Properties.Settings.Default.CompilationChars = Convert.ToInt32(tbCompilationChars.Text);
            Properties.Settings.Default.DocumentClass = tbDocumentClass.Text;
            Properties.Settings.Default.Author = tbAuthor.Text;

            Properties.Settings.Default.Save();
        }
    }
}
