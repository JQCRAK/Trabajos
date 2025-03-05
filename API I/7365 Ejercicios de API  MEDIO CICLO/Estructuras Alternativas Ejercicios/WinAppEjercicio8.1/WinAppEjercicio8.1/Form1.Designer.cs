namespace WinAppEjercicio8._1
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
            this.LBLTITULO1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TXTBINGRESAR = new System.Windows.Forms.TextBox();
            this.PCBCALENDARIO = new System.Windows.Forms.PictureBox();
            this.BTNRESUL = new WinAppCalculadora.RJButton();
            this.BTNCONVERTIR = new WinAppCalculadora.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCALENDARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTITULO1
            // 
            this.LBLTITULO1.AutoSize = true;
            this.LBLTITULO1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO1.ForeColor = System.Drawing.Color.White;
            this.LBLTITULO1.Location = new System.Drawing.Point(28, 28);
            this.LBLTITULO1.Name = "LBLTITULO1";
            this.LBLTITULO1.Size = new System.Drawing.Size(244, 35);
            this.LBLTITULO1.TabIndex = 0;
            this.LBLTITULO1.Text = "Conversor de Mes";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(31, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(357, 67);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Ingrese un número del 1 al 12 para ver el mes correspondiente.";
            // 
            // TXTBINGRESAR
            // 
            this.TXTBINGRESAR.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBINGRESAR.ForeColor = System.Drawing.Color.Blue;
            this.TXTBINGRESAR.Location = new System.Drawing.Point(34, 145);
            this.TXTBINGRESAR.Name = "TXTBINGRESAR";
            this.TXTBINGRESAR.Size = new System.Drawing.Size(354, 40);
            this.TXTBINGRESAR.TabIndex = 2;
            this.TXTBINGRESAR.TextChanged += new System.EventHandler(this.TXTBINGRESAR_TextChanged);
            this.TXTBINGRESAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBINGRESAR_KeyPress);
            // 
            // PCBCALENDARIO
            // 
            this.PCBCALENDARIO.Image = global::WinAppEjercicio8._1.Properties.Resources.icons8_calendario_de_la_semana_32__1_;
            this.PCBCALENDARIO.Location = new System.Drawing.Point(510, 28);
            this.PCBCALENDARIO.Name = "PCBCALENDARIO";
            this.PCBCALENDARIO.Size = new System.Drawing.Size(50, 50);
            this.PCBCALENDARIO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBCALENDARIO.TabIndex = 4;
            this.PCBCALENDARIO.TabStop = false;
            // 
            // BTNRESUL
            // 
            this.BTNRESUL.BackColor = System.Drawing.Color.White;
            this.BTNRESUL.BackgroundColor = System.Drawing.Color.White;
            this.BTNRESUL.BorderColor = System.Drawing.Color.Black;
            this.BTNRESUL.BorderRadius = 40;
            this.BTNRESUL.BorderSize = 2;
            this.BTNRESUL.FlatAppearance.BorderSize = 0;
            this.BTNRESUL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNRESUL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNRESUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRESUL.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRESUL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNRESUL.Location = new System.Drawing.Point(31, 209);
            this.BTNRESUL.Name = "BTNRESUL";
            this.BTNRESUL.Size = new System.Drawing.Size(529, 60);
            this.BTNRESUL.TabIndex = 5;
            this.BTNRESUL.TabStop = false;
            this.BTNRESUL.UseVisualStyleBackColor = false;
            // 
            // BTNCONVERTIR
            // 
            this.BTNCONVERTIR.BackColor = System.Drawing.Color.White;
            this.BTNCONVERTIR.BackgroundColor = System.Drawing.Color.White;
            this.BTNCONVERTIR.BorderColor = System.Drawing.Color.Navy;
            this.BTNCONVERTIR.BorderRadius = 30;
            this.BTNCONVERTIR.BorderSize = 2;
            this.BTNCONVERTIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCONVERTIR.FlatAppearance.BorderSize = 0;
            this.BTNCONVERTIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNCONVERTIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNCONVERTIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCONVERTIR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONVERTIR.ForeColor = System.Drawing.Color.Blue;
            this.BTNCONVERTIR.Location = new System.Drawing.Point(410, 145);
            this.BTNCONVERTIR.Name = "BTNCONVERTIR";
            this.BTNCONVERTIR.Size = new System.Drawing.Size(150, 40);
            this.BTNCONVERTIR.TabIndex = 3;
            this.BTNCONVERTIR.Text = "Convertir";
            this.BTNCONVERTIR.UseVisualStyleBackColor = false;
            this.BTNCONVERTIR.Click += new System.EventHandler(this.BTNCONVERTIR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(591, 308);
            this.Controls.Add(this.BTNRESUL);
            this.Controls.Add(this.PCBCALENDARIO);
            this.Controls.Add(this.BTNCONVERTIR);
            this.Controls.Add(this.TXTBINGRESAR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LBLTITULO1);
            this.Name = "Form1";
            this.Text = "Ejercicio 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCBCALENDARIO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TXTBINGRESAR;
        private WinAppCalculadora.RJButton BTNCONVERTIR;
        private System.Windows.Forms.PictureBox PCBCALENDARIO;
        private WinAppCalculadora.RJButton BTNRESUL;
    }
}

