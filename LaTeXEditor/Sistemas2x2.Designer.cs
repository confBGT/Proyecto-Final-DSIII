namespace TexEditor
{
    partial class Sistemas2x2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSolve = new Button();
            label5 = new Label();
            txtXcoefficient1 = new TextBox();
            txtYcoefficient1 = new TextBox();
            txtIndependentTerm1 = new TextBox();
            txtXcoefficient2 = new TextBox();
            txtYcoefficient2 = new TextBox();
            txtIndependentTerm2 = new TextBox();
            txtSolutions = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 0;
            label1.Text = "X +";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 25);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 1;
            label2.Text = "Y =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 74);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 2;
            label3.Text = "X +";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 75);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 3;
            label4.Text = "Y =";
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(25, 123);
            btnSolve.Margin = new Padding(3, 2, 3, 2);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(116, 32);
            btnSolve.TabIndex = 4;
            btnSolve.Text = "Resolver";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 176);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 5;
            label5.Text = "Soluciones:";
            // 
            // txtXcoefficient1
            // 
            txtXcoefficient1.Location = new Point(25, 25);
            txtXcoefficient1.Margin = new Padding(3, 2, 3, 2);
            txtXcoefficient1.Name = "txtXcoefficient1";
            txtXcoefficient1.Size = new Size(41, 23);
            txtXcoefficient1.TabIndex = 6;
            // 
            // txtYcoefficient1
            // 
            txtYcoefficient1.Location = new Point(111, 26);
            txtYcoefficient1.Margin = new Padding(3, 2, 3, 2);
            txtYcoefficient1.Name = "txtYcoefficient1";
            txtYcoefficient1.Size = new Size(44, 23);
            txtYcoefficient1.TabIndex = 7;
            // 
            // txtIndependentTerm1
            // 
            txtIndependentTerm1.Location = new Point(208, 27);
            txtIndependentTerm1.Margin = new Padding(3, 2, 3, 2);
            txtIndependentTerm1.Name = "txtIndependentTerm1";
            txtIndependentTerm1.Size = new Size(42, 23);
            txtIndependentTerm1.TabIndex = 8;
            // 
            // txtXcoefficient2
            // 
            txtXcoefficient2.Location = new Point(26, 75);
            txtXcoefficient2.Margin = new Padding(3, 2, 3, 2);
            txtXcoefficient2.Name = "txtXcoefficient2";
            txtXcoefficient2.Size = new Size(40, 23);
            txtXcoefficient2.TabIndex = 9;
            // 
            // txtYcoefficient2
            // 
            txtYcoefficient2.Location = new Point(111, 76);
            txtYcoefficient2.Margin = new Padding(3, 2, 3, 2);
            txtYcoefficient2.Name = "txtYcoefficient2";
            txtYcoefficient2.Size = new Size(44, 23);
            txtYcoefficient2.TabIndex = 10;
            // 
            // txtIndependentTerm2
            // 
            txtIndependentTerm2.Location = new Point(208, 77);
            txtIndependentTerm2.Margin = new Padding(3, 2, 3, 2);
            txtIndependentTerm2.Name = "txtIndependentTerm2";
            txtIndependentTerm2.Size = new Size(42, 23);
            txtIndependentTerm2.TabIndex = 11;
            // 
            // txtSolutions
            // 
            txtSolutions.Location = new Point(137, 178);
            txtSolutions.Margin = new Padding(3, 2, 3, 2);
            txtSolutions.Name = "txtSolutions";
            txtSolutions.Size = new Size(195, 23);
            txtSolutions.TabIndex = 12;
            // 
            // Sistemas2x2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 227);
            Controls.Add(txtSolutions);
            Controls.Add(txtIndependentTerm2);
            Controls.Add(txtYcoefficient2);
            Controls.Add(txtXcoefficient2);
            Controls.Add(txtIndependentTerm1);
            Controls.Add(txtYcoefficient1);
            Controls.Add(txtXcoefficient1);
            Controls.Add(label5);
            Controls.Add(btnSolve);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Sistemas2x2";
            Text = "Sistemas2x2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSolve;
        private Label label5;
        private TextBox txtXcoefficient1;
        private TextBox txtYcoefficient1;
        private TextBox txtIndependentTerm1;
        private TextBox txtXcoefficient2;
        private TextBox txtYcoefficient2;
        private TextBox txtIndependentTerm2;
        private TextBox txtSolutions;
    }
}
