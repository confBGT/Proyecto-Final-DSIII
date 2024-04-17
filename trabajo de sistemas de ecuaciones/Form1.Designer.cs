namespace trabajo_de_sistemas_de_ecuaciones
{
    partial class Form1
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
            Btn2x2 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Btn2x2
            // 
            Btn2x2.Location = new Point(288, 71);
            Btn2x2.Name = "Btn2x2";
            Btn2x2.Size = new Size(226, 104);
            Btn2x2.TabIndex = 0;
            Btn2x2.Text = "Sistemas 2x2";
            Btn2x2.UseVisualStyleBackColor = true;
            Btn2x2.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(288, 234);
            button2.Name = "button2";
            button2.Size = new Size(226, 108);
            button2.TabIndex = 1;
            button2.Text = "Sistemas 3x3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Btn2x2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn2x2;
        private Button button2;
    }
}
