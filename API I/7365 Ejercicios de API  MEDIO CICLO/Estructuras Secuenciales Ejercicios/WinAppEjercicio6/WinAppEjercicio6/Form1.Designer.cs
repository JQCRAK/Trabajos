namespace WinAppEjercicio6
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
            this.LBLTITULO3 = new System.Windows.Forms.Label();
            this.LBLTITULO2 = new System.Windows.Forms.Label();
            this.LBLTITULO4 = new System.Windows.Forms.Label();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.LBLTITULO5 = new System.Windows.Forms.Label();
            this.TXTBTITULO = new System.Windows.Forms.TextBox();
            this.TXTVALOR3 = new System.Windows.Forms.TextBox();
            this.TXTVALOR2 = new System.Windows.Forms.TextBox();
            this.TXTVALOR1 = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.PCBRESET = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCBRESET)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTITULO3
            // 
            this.LBLTITULO3.AutoSize = true;
            this.LBLTITULO3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO3.Location = new System.Drawing.Point(60, 225);
            this.LBLTITULO3.Name = "LBLTITULO3";
            this.LBLTITULO3.Size = new System.Drawing.Size(105, 24);
            this.LBLTITULO3.TabIndex = 0;
            this.LBLTITULO3.Text = "Masa 2 (kg)";
            // 
            // LBLTITULO2
            // 
            this.LBLTITULO2.AutoSize = true;
            this.LBLTITULO2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO2.Location = new System.Drawing.Point(60, 144);
            this.LBLTITULO2.Name = "LBLTITULO2";
            this.LBLTITULO2.Size = new System.Drawing.Size(105, 24);
            this.LBLTITULO2.TabIndex = 1;
            this.LBLTITULO2.Text = "Masa 1 (kg)";
            // 
            // LBLTITULO4
            // 
            this.LBLTITULO4.AutoSize = true;
            this.LBLTITULO4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO4.Location = new System.Drawing.Point(60, 305);
            this.LBLTITULO4.Name = "LBLTITULO4";
            this.LBLTITULO4.Size = new System.Drawing.Size(119, 24);
            this.LBLTITULO4.TabIndex = 3;
            this.LBLTITULO4.Text = "Distancia (m)";
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(132, 26);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(338, 28);
            this.LBLTITULO.TabIndex = 4;
            this.LBLTITULO.Text = "Calculadora de Fuerza Gravitatoria";
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.Location = new System.Drawing.Point(230, 492);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(58, 24);
            this.LBLRESUL.TabIndex = 5;
            this.LBLRESUL.Text = "0.0  N";
            // 
            // LBLTITULO5
            // 
            this.LBLTITULO5.AutoSize = true;
            this.LBLTITULO5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO5.Location = new System.Drawing.Point(245, 451);
            this.LBLTITULO5.Name = "LBLTITULO5";
            this.LBLTITULO5.Size = new System.Drawing.Size(94, 24);
            this.LBLTITULO5.TabIndex = 6;
            this.LBLTITULO5.Text = "Resultado";
            // 
            // TXTBTITULO
            // 
            this.TXTBTITULO.BackColor = System.Drawing.Color.White;
            this.TXTBTITULO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBTITULO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTITULO.ForeColor = System.Drawing.Color.Gray;
            this.TXTBTITULO.Location = new System.Drawing.Point(109, 57);
            this.TXTBTITULO.Multiline = true;
            this.TXTBTITULO.Name = "TXTBTITULO";
            this.TXTBTITULO.ReadOnly = true;
            this.TXTBTITULO.Size = new System.Drawing.Size(386, 54);
            this.TXTBTITULO.TabIndex = 7;
            this.TXTBTITULO.TabStop = false;
            this.TXTBTITULO.Text = "Ingrese las masas y la distancia para calcular la fuerza gravitatoria";
            this.TXTBTITULO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTVALOR3
            // 
            this.TXTVALOR3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTVALOR3.Location = new System.Drawing.Point(64, 337);
            this.TXTVALOR3.Name = "TXTVALOR3";
            this.TXTVALOR3.Size = new System.Drawing.Size(431, 32);
            this.TXTVALOR3.TabIndex = 8;
            this.TXTVALOR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTVALOR3_KeyPress);
            // 
            // TXTVALOR2
            // 
            this.TXTVALOR2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTVALOR2.Location = new System.Drawing.Point(64, 257);
            this.TXTVALOR2.Name = "TXTVALOR2";
            this.TXTVALOR2.Size = new System.Drawing.Size(431, 32);
            this.TXTVALOR2.TabIndex = 9;
            this.TXTVALOR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTVALOR2_KeyPress);
            // 
            // TXTVALOR1
            // 
            this.TXTVALOR1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTVALOR1.Location = new System.Drawing.Point(64, 176);
            this.TXTVALOR1.Name = "TXTVALOR1";
            this.TXTVALOR1.Size = new System.Drawing.Size(431, 32);
            this.TXTVALOR1.TabIndex = 0;
            this.TXTVALOR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTVALOR1_KeyPress);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Black;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(64, 386);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(431, 42);
            this.BTNCALCULAR.TabIndex = 11;
            this.BTNCALCULAR.Text = "Calcular Fuerza Gravitatoria";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // PCBRESET
            // 
            this.PCBRESET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBRESET.Image = global::WinAppEjercicio6.Properties.Resources.RESET;
            this.PCBRESET.Location = new System.Drawing.Point(521, 386);
            this.PCBRESET.Name = "PCBRESET";
            this.PCBRESET.Size = new System.Drawing.Size(42, 42);
            this.PCBRESET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBRESET.TabIndex = 12;
            this.PCBRESET.TabStop = false;
            this.PCBRESET.Click += new System.EventHandler(this.PCBRESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 545);
            this.Controls.Add(this.PCBRESET);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTVALOR1);
            this.Controls.Add(this.TXTVALOR2);
            this.Controls.Add(this.TXTVALOR3);
            this.Controls.Add(this.TXTBTITULO);
            this.Controls.Add(this.LBLTITULO5);
            this.Controls.Add(this.LBLRESUL);
            this.Controls.Add(this.LBLTITULO);
            this.Controls.Add(this.LBLTITULO4);
            this.Controls.Add(this.LBLTITULO2);
            this.Controls.Add(this.LBLTITULO3);
            this.Name = "Form1";
            this.Text = "Ejercicio 6";
            ((System.ComponentModel.ISupportInitialize)(this.PCBRESET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO3;
        private System.Windows.Forms.Label LBLTITULO2;
        private System.Windows.Forms.Label LBLTITULO4;
        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.Label LBLTITULO5;
        private System.Windows.Forms.TextBox TXTBTITULO;
        private System.Windows.Forms.TextBox TXTVALOR3;
        private System.Windows.Forms.TextBox TXTVALOR2;
        private System.Windows.Forms.TextBox TXTVALOR1;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.PictureBox PCBRESET;
    }
}

