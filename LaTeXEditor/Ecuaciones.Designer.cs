namespace TexEditor
{
	partial class Ecuaciones
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBoxOutputX2 = new System.Windows.Forms.TextBox();
			this.txtBoxOutputX1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBoxOutputType = new System.Windows.Forms.TextBox();
			this.rbQuad = new System.Windows.Forms.RadioButton();
			this.rbCube = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBoxInputConstant = new System.Windows.Forms.TextBox();
			this.txtBoxInputX = new System.Windows.Forms.TextBox();
			this.txtBoxInputXSquare = new System.Windows.Forms.TextBox();
			this.txtBoxInputXCube = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnAviso = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(140, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(644, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculadora de las fórmulas cuadráticas y cúbicas";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAviso);
			this.groupBox1.Controls.Add(this.txtBoxOutputX2);
			this.groupBox1.Controls.Add(this.txtBoxOutputX1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtBoxOutputType);
			this.groupBox1.Location = new System.Drawing.Point(534, 179);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 227);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Resultados";
			// 
			// txtBoxOutputX2
			// 
			this.txtBoxOutputX2.Enabled = false;
			this.txtBoxOutputX2.Location = new System.Drawing.Point(189, 103);
			this.txtBoxOutputX2.Name = "txtBoxOutputX2";
			this.txtBoxOutputX2.Size = new System.Drawing.Size(100, 22);
			this.txtBoxOutputX2.TabIndex = 6;
			// 
			// txtBoxOutputX1
			// 
			this.txtBoxOutputX1.Enabled = false;
			this.txtBoxOutputX1.Location = new System.Drawing.Point(189, 64);
			this.txtBoxOutputX1.Name = "txtBoxOutputX1";
			this.txtBoxOutputX1.Size = new System.Drawing.Size(100, 22);
			this.txtBoxOutputX1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(66, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "x2:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(66, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "x1:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tipo:";
			// 
			// txtBoxOutputType
			// 
			this.txtBoxOutputType.Enabled = false;
			this.txtBoxOutputType.Location = new System.Drawing.Point(189, 24);
			this.txtBoxOutputType.Name = "txtBoxOutputType";
			this.txtBoxOutputType.Size = new System.Drawing.Size(100, 22);
			this.txtBoxOutputType.TabIndex = 0;
			// 
			// rbQuad
			// 
			this.rbQuad.AutoSize = true;
			this.rbQuad.Location = new System.Drawing.Point(146, 113);
			this.rbQuad.Name = "rbQuad";
			this.rbQuad.Size = new System.Drawing.Size(143, 20);
			this.rbQuad.TabIndex = 4;
			this.rbQuad.TabStop = true;
			this.rbQuad.Text = "Calcular cuadrática";
			this.rbQuad.UseVisualStyleBackColor = true;
			this.rbQuad.Click += new System.EventHandler(this.rbQuad_Click);
			// 
			// rbCube
			// 
			this.rbCube.AutoSize = true;
			this.rbCube.Location = new System.Drawing.Point(482, 113);
			this.rbCube.Name = "rbCube";
			this.rbCube.Size = new System.Drawing.Size(120, 20);
			this.rbCube.TabIndex = 5;
			this.rbCube.TabStop = true;
			this.rbCube.Text = "Calcular cúbica";
			this.rbCube.UseVisualStyleBackColor = true;
			this.rbCube.Click += new System.EventHandler(this.rbCube_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtBoxInputConstant);
			this.groupBox2.Controls.Add(this.txtBoxInputX);
			this.groupBox2.Controls.Add(this.txtBoxInputXSquare);
			this.groupBox2.Controls.Add(this.txtBoxInputXCube);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(43, 179);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(397, 227);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Parámetros";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(32, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(320, 16);
			this.label10.TabIndex = 8;
			this.label10.Text = "Escribir aquí los términos del polinomio igualado a 0.";
			// 
			// txtBoxInputConstant
			// 
			this.txtBoxInputConstant.Location = new System.Drawing.Point(146, 170);
			this.txtBoxInputConstant.Name = "txtBoxInputConstant";
			this.txtBoxInputConstant.Size = new System.Drawing.Size(100, 22);
			this.txtBoxInputConstant.TabIndex = 7;
			// 
			// txtBoxInputX
			// 
			this.txtBoxInputX.Location = new System.Drawing.Point(146, 138);
			this.txtBoxInputX.Name = "txtBoxInputX";
			this.txtBoxInputX.Size = new System.Drawing.Size(100, 22);
			this.txtBoxInputX.TabIndex = 6;
			// 
			// txtBoxInputXSquare
			// 
			this.txtBoxInputXSquare.Location = new System.Drawing.Point(146, 103);
			this.txtBoxInputXSquare.Name = "txtBoxInputXSquare";
			this.txtBoxInputXSquare.Size = new System.Drawing.Size(100, 22);
			this.txtBoxInputXSquare.TabIndex = 5;
			// 
			// txtBoxInputXCube
			// 
			this.txtBoxInputXCube.Enabled = false;
			this.txtBoxInputXCube.Location = new System.Drawing.Point(146, 67);
			this.txtBoxInputXCube.Name = "txtBoxInputXCube";
			this.txtBoxInputXCube.Size = new System.Drawing.Size(100, 22);
			this.txtBoxInputXCube.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(29, 173);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 16);
			this.label9.TabIndex = 3;
			this.label9.Text = "Constante:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "x sin exponente:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "x al cuadrado:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "x al cubo:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(67, 425);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 7;
			this.btnCalculate.Text = "Calcular";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(171, 425);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(118, 23);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Reestablecer";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(320, 425);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(43, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 10;
			this.textBox1.Visible = false;
			// 
			// btnAviso
			// 
			this.btnAviso.Location = new System.Drawing.Point(69, 138);
			this.btnAviso.Name = "btnAviso";
			this.btnAviso.Size = new System.Drawing.Size(75, 23);
			this.btnAviso.TabIndex = 11;
			this.btnAviso.Text = "Aviso";
			this.btnAviso.UseVisualStyleBackColor = true;
			this.btnAviso.Click += new System.EventHandler(this.btnAviso_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 475);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.rbCube);
			this.Controls.Add(this.rbQuad);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtBoxOutputX2;
		private System.Windows.Forms.TextBox txtBoxOutputX1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBoxOutputType;
		private System.Windows.Forms.RadioButton rbQuad;
		private System.Windows.Forms.RadioButton rbCube;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtBoxInputConstant;
		private System.Windows.Forms.TextBox txtBoxInputX;
		private System.Windows.Forms.TextBox txtBoxInputXSquare;
		private System.Windows.Forms.TextBox txtBoxInputXCube;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnAviso;
	}
}

