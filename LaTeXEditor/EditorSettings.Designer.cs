namespace TexEditor
{
    partial class EditorSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnOk = new Button();
            tabControl = new TabPage();
            groupBox1 = new GroupBox();
            tbCompilationTime = new TextBox();
            tbCompilationChars = new TextBox();
            rbtnCompilationChars = new RadioButton();
            rbtnCompilationTime = new RadioButton();
            tabCompilation = new TabControl();
            tabDocument = new TabPage();
            gbDocClass = new GroupBox();
            tbDocumentClass = new TextBox();
            gbAuthor = new GroupBox();
            tbAuthor = new TextBox();
            tabControl.SuspendLayout();
            groupBox1.SuspendLayout();
            tabCompilation.SuspendLayout();
            tabDocument.SuspendLayout();
            gbDocClass.SuspendLayout();
            gbAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(275, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 31);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(177, 398);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(92, 31);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += saveSettings;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(groupBox1);
            tabControl.Location = new Point(4, 24);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Padding(3);
            tabControl.Size = new Size(351, 352);
            tabControl.TabIndex = 0;
            tabControl.Text = "Compilacion";
            tabControl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCompilationTime);
            groupBox1.Controls.Add(tbCompilationChars);
            groupBox1.Controls.Add(rbtnCompilationChars);
            groupBox1.Controls.Add(rbtnCompilationTime);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modo de compilacion";
            // 
            // tbCompilationTime
            // 
            tbCompilationTime.Location = new Point(210, 27);
            tbCompilationTime.Name = "tbCompilationTime";
            tbCompilationTime.Size = new Size(112, 23);
            tbCompilationTime.TabIndex = 3;
            tbCompilationTime.TextAlign = HorizontalAlignment.Right;
            tbCompilationTime.KeyPress += numericFilter;
            // 
            // tbCompilationChars
            // 
            tbCompilationChars.Location = new Point(210, 65);
            tbCompilationChars.Name = "tbCompilationChars";
            tbCompilationChars.Size = new Size(112, 23);
            tbCompilationChars.TabIndex = 2;
            tbCompilationChars.TextAlign = HorizontalAlignment.Right;
            tbCompilationChars.KeyPress += numericFilter;
            // 
            // rbtnCompilationChars
            // 
            rbtnCompilationChars.AutoSize = true;
            rbtnCompilationChars.Location = new Point(16, 66);
            rbtnCompilationChars.Name = "rbtnCompilationChars";
            rbtnCompilationChars.Size = new Size(164, 19);
            rbtnCompilationChars.TabIndex = 1;
            rbtnCompilationChars.TabStop = true;
            rbtnCompilationChars.Text = "Por cantidad de caracteres";
            rbtnCompilationChars.UseVisualStyleBackColor = true;
            // 
            // rbtnCompilationTime
            // 
            rbtnCompilationTime.AutoSize = true;
            rbtnCompilationTime.Location = new Point(16, 28);
            rbtnCompilationTime.Name = "rbtnCompilationTime";
            rbtnCompilationTime.Size = new Size(146, 19);
            rbtnCompilationTime.TabIndex = 0;
            rbtnCompilationTime.TabStop = true;
            rbtnCompilationTime.Text = "Por tiempo (segundos)";
            rbtnCompilationTime.UseVisualStyleBackColor = true;
            rbtnCompilationTime.CheckedChanged += rbtnCompilationModeChanged;
            // 
            // tabCompilation
            // 
            tabCompilation.Controls.Add(tabControl);
            tabCompilation.Controls.Add(tabDocument);
            tabCompilation.Location = new Point(12, 12);
            tabCompilation.Name = "tabCompilation";
            tabCompilation.SelectedIndex = 0;
            tabCompilation.Size = new Size(359, 380);
            tabCompilation.TabIndex = 4;
            // 
            // tabDocument
            // 
            tabDocument.Controls.Add(gbDocClass);
            tabDocument.Controls.Add(gbAuthor);
            tabDocument.Location = new Point(4, 24);
            tabDocument.Name = "tabDocument";
            tabDocument.Padding = new Padding(3);
            tabDocument.Size = new Size(351, 352);
            tabDocument.TabIndex = 1;
            tabDocument.Text = "Documento";
            tabDocument.UseVisualStyleBackColor = true;
            // 
            // gbDocClass
            // 
            gbDocClass.Controls.Add(tbDocumentClass);
            gbDocClass.Location = new Point(6, 63);
            gbDocClass.Name = "gbDocClass";
            gbDocClass.Size = new Size(339, 56);
            gbDocClass.TabIndex = 1;
            gbDocClass.TabStop = false;
            gbDocClass.Text = "Document class";
            // 
            // tbDocumentClass
            // 
            tbDocumentClass.Location = new Point(6, 22);
            tbDocumentClass.Name = "tbDocumentClass";
            tbDocumentClass.Size = new Size(327, 23);
            tbDocumentClass.TabIndex = 1;
            // 
            // gbAuthor
            // 
            gbAuthor.Controls.Add(tbAuthor);
            gbAuthor.Location = new Point(6, 6);
            gbAuthor.Name = "gbAuthor";
            gbAuthor.Size = new Size(339, 51);
            gbAuthor.TabIndex = 0;
            gbAuthor.TabStop = false;
            gbAuthor.Text = "Autor";
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(6, 19);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(327, 23);
            tbAuthor.TabIndex = 0;
            // 
            // EditorSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 439);
            Controls.Add(tabCompilation);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            KeyPreview = true;
            Name = "EditorSettings";
            Text = "Preferencias";
            tabControl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabCompilation.ResumeLayout(false);
            tabDocument.ResumeLayout(false);
            gbDocClass.ResumeLayout(false);
            gbDocClass.PerformLayout();
            gbAuthor.ResumeLayout(false);
            gbAuthor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancel;
        private Button btnOk;
        private TabPage tabControl;
        private GroupBox groupBox1;
        private TextBox tbCompilationTime;
        private TextBox tbCompilationChars;
        private RadioButton rbtnCompilationChars;
        private RadioButton rbtnCompilationTime;
        private TabControl tabCompilation;
        private TabPage tabDocument;
        private GroupBox gbAuthor;
        private TextBox tbAuthor;
        private GroupBox gbDocClass;
        private TextBox tbDocumentClass;
    }
}