namespace ServicioWebCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxcuadrado = new System.Windows.Forms.TextBox();
            this.basetrian = new System.Windows.Forms.TextBox();
            this.alturatrian = new System.Windows.Forms.TextBox();
            this.Radiocirculo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.resultadocuadrado = new System.Windows.Forms.Label();
            this.resultadotriangulo = new System.Windows.Forms.Label();
            this.resultadocirculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Áreas ";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos del Cuadrado";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datos del Triangulo";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos del Circulo";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lado del cuadrado:";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Base:";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Radio";
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Altura:";
            this.label8.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular Área Cuadrado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxcuadrado
            // 
            this.textBoxcuadrado.Location = new System.Drawing.Point(321, 128);
            this.textBoxcuadrado.Name = "textBoxcuadrado";
            this.textBoxcuadrado.Size = new System.Drawing.Size(100, 22);
            this.textBoxcuadrado.TabIndex = 11;
            this.textBoxcuadrado.UseWaitCursor = true;
            // 
            // basetrian
            // 
            this.basetrian.Location = new System.Drawing.Point(220, 251);
            this.basetrian.Name = "basetrian";
            this.basetrian.Size = new System.Drawing.Size(100, 22);
            this.basetrian.TabIndex = 12;
            this.basetrian.UseWaitCursor = true;
            this.basetrian.TextChanged += new System.EventHandler(this.basetrian_TextChanged);
            // 
            // alturatrian
            // 
            this.alturatrian.Location = new System.Drawing.Point(399, 251);
            this.alturatrian.Name = "alturatrian";
            this.alturatrian.Size = new System.Drawing.Size(100, 22);
            this.alturatrian.TabIndex = 13;
            this.alturatrian.UseWaitCursor = true;
            // 
            // Radiocirculo
            // 
            this.Radiocirculo.Location = new System.Drawing.Point(222, 345);
            this.Radiocirculo.Name = "Radiocirculo";
            this.Radiocirculo.Size = new System.Drawing.Size(100, 22);
            this.Radiocirculo.TabIndex = 14;
            this.Radiocirculo.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 58);
            this.button2.TabIndex = 15;
            this.button2.Text = "Calcular Área Triangulo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 58);
            this.button3.TabIndex = 16;
            this.button3.Text = "Calcular Área del Circulo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // resultadocuadrado
            // 
            this.resultadocuadrado.AutoSize = true;
            this.resultadocuadrado.Location = new System.Drawing.Point(695, 134);
            this.resultadocuadrado.Name = "resultadocuadrado";
            this.resultadocuadrado.Size = new System.Drawing.Size(0, 16);
            this.resultadocuadrado.TabIndex = 17;
            this.resultadocuadrado.UseWaitCursor = true;
            // 
            // resultadotriangulo
            // 
            this.resultadotriangulo.AutoSize = true;
            this.resultadotriangulo.Location = new System.Drawing.Point(695, 236);
            this.resultadotriangulo.Name = "resultadotriangulo";
            this.resultadotriangulo.Size = new System.Drawing.Size(0, 16);
            this.resultadotriangulo.TabIndex = 18;
            this.resultadotriangulo.UseWaitCursor = true;
            // 
            // resultadocirculo
            // 
            this.resultadocirculo.AutoSize = true;
            this.resultadocirculo.Location = new System.Drawing.Point(695, 351);
            this.resultadocirculo.Name = "resultadocirculo";
            this.resultadocirculo.Size = new System.Drawing.Size(0, 16);
            this.resultadocirculo.TabIndex = 19;
            this.resultadocirculo.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 526);
            this.Controls.Add(this.resultadocirculo);
            this.Controls.Add(this.resultadotriangulo);
            this.Controls.Add(this.resultadocuadrado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Radiocirculo);
            this.Controls.Add(this.alturatrian);
            this.Controls.Add(this.basetrian);
            this.Controls.Add(this.textBoxcuadrado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxcuadrado;
        private System.Windows.Forms.TextBox basetrian;
        private System.Windows.Forms.TextBox alturatrian;
        private System.Windows.Forms.TextBox Radiocirculo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label resultadocuadrado;
        private System.Windows.Forms.Label resultadotriangulo;
        private System.Windows.Forms.Label resultadocirculo;
    }
}

