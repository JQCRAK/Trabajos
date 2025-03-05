namespace WinAppEjercicio7
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
            this.PNPTITULO = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LBLTITULO1 = new System.Windows.Forms.Label();
            this.LBLTITULO2 = new System.Windows.Forms.Label();
            this.LBLTITULO3 = new System.Windows.Forms.Label();
            this.LBLTITULO4 = new System.Windows.Forms.Label();
            this.LBLTITULO5 = new System.Windows.Forms.Label();
            this.LBLTITULO6 = new System.Windows.Forms.Label();
            this.TXTBMASA = new System.Windows.Forms.TextBox();
            this.TXTBCALORIFICA = new System.Windows.Forms.TextBox();
            this.TXTBTINICIAL = new System.Windows.Forms.TextBox();
            this.TXTBTFINAL = new System.Windows.Forms.TextBox();
            this.LBLTITULO7 = new System.Windows.Forms.Label();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BTNCALCULAR = new WinAppCalculadora.RJButton();
            this.PNPTITULO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // PNPTITULO
            // 
            this.PNPTITULO.BackColor = System.Drawing.Color.LimeGreen;
            this.PNPTITULO.Controls.Add(this.pictureBox3);
            this.PNPTITULO.Controls.Add(this.LBLTITULO1);
            this.PNPTITULO.Controls.Add(this.LBLTITULO2);
            this.PNPTITULO.Location = new System.Drawing.Point(-1, 0);
            this.PNPTITULO.Name = "PNPTITULO";
            this.PNPTITULO.Size = new System.Drawing.Size(584, 123);
            this.PNPTITULO.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinAppEjercicio7.Properties.Resources.icons8_temperatura_50;
            this.pictureBox3.Location = new System.Drawing.Point(132, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // LBLTITULO1
            // 
            this.LBLTITULO1.AutoSize = true;
            this.LBLTITULO1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO1.ForeColor = System.Drawing.Color.White;
            this.LBLTITULO1.Location = new System.Drawing.Point(173, 20);
            this.LBLTITULO1.Name = "LBLTITULO1";
            this.LBLTITULO1.Size = new System.Drawing.Size(285, 35);
            this.LBLTITULO1.TabIndex = 1;
            this.LBLTITULO1.Text = "Calculadora de Calor";
            // 
            // LBLTITULO2
            // 
            this.LBLTITULO2.AutoSize = true;
            this.LBLTITULO2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO2.ForeColor = System.Drawing.Color.White;
            this.LBLTITULO2.Location = new System.Drawing.Point(39, 69);
            this.LBLTITULO2.Name = "LBLTITULO2";
            this.LBLTITULO2.Size = new System.Drawing.Size(512, 26);
            this.LBLTITULO2.TabIndex = 2;
            this.LBLTITULO2.Text = "Calcule el calor necesario para cambiar la temperatura";
            // 
            // LBLTITULO3
            // 
            this.LBLTITULO3.AutoSize = true;
            this.LBLTITULO3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO3.ForeColor = System.Drawing.Color.Black;
            this.LBLTITULO3.Location = new System.Drawing.Point(75, 170);
            this.LBLTITULO3.Name = "LBLTITULO3";
            this.LBLTITULO3.Size = new System.Drawing.Size(105, 26);
            this.LBLTITULO3.TabIndex = 3;
            this.LBLTITULO3.Text = "Masa (kg)";
            // 
            // LBLTITULO4
            // 
            this.LBLTITULO4.AutoSize = true;
            this.LBLTITULO4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO4.ForeColor = System.Drawing.Color.Black;
            this.LBLTITULO4.Location = new System.Drawing.Point(75, 263);
            this.LBLTITULO4.Name = "LBLTITULO4";
            this.LBLTITULO4.Size = new System.Drawing.Size(398, 26);
            this.LBLTITULO4.TabIndex = 4;
            this.LBLTITULO4.Text = "Capacidad Calorífica Específica (J/kg·°C)";
            // 
            // LBLTITULO5
            // 
            this.LBLTITULO5.AutoSize = true;
            this.LBLTITULO5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO5.ForeColor = System.Drawing.Color.Black;
            this.LBLTITULO5.Location = new System.Drawing.Point(38, 360);
            this.LBLTITULO5.Name = "LBLTITULO5";
            this.LBLTITULO5.Size = new System.Drawing.Size(238, 26);
            this.LBLTITULO5.TabIndex = 5;
            this.LBLTITULO5.Text = "Temperatura Inicial (°C)";
            // 
            // LBLTITULO6
            // 
            this.LBLTITULO6.AutoSize = true;
            this.LBLTITULO6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO6.ForeColor = System.Drawing.Color.Black;
            this.LBLTITULO6.Location = new System.Drawing.Point(323, 360);
            this.LBLTITULO6.Name = "LBLTITULO6";
            this.LBLTITULO6.Size = new System.Drawing.Size(227, 26);
            this.LBLTITULO6.TabIndex = 6;
            this.LBLTITULO6.Text = "Temperatura Final (°C)";
            // 
            // TXTBMASA
            // 
            this.TXTBMASA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBMASA.Location = new System.Drawing.Point(43, 211);
            this.TXTBMASA.Name = "TXTBMASA";
            this.TXTBMASA.Size = new System.Drawing.Size(507, 34);
            this.TXTBMASA.TabIndex = 7;
            this.TXTBMASA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBMASA_KeyPress);
            // 
            // TXTBCALORIFICA
            // 
            this.TXTBCALORIFICA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBCALORIFICA.Location = new System.Drawing.Point(43, 304);
            this.TXTBCALORIFICA.Name = "TXTBCALORIFICA";
            this.TXTBCALORIFICA.Size = new System.Drawing.Size(507, 34);
            this.TXTBCALORIFICA.TabIndex = 8;
            this.TXTBCALORIFICA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBCALORIFICA_KeyPress);
            // 
            // TXTBTINICIAL
            // 
            this.TXTBTINICIAL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTINICIAL.Location = new System.Drawing.Point(43, 403);
            this.TXTBTINICIAL.Name = "TXTBTINICIAL";
            this.TXTBTINICIAL.Size = new System.Drawing.Size(233, 34);
            this.TXTBTINICIAL.TabIndex = 9;
            this.TXTBTINICIAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBTINICIAL_KeyPress);
            // 
            // TXTBTFINAL
            // 
            this.TXTBTFINAL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTFINAL.Location = new System.Drawing.Point(328, 403);
            this.TXTBTFINAL.Name = "TXTBTFINAL";
            this.TXTBTFINAL.Size = new System.Drawing.Size(222, 34);
            this.TXTBTFINAL.TabIndex = 10;
            this.TXTBTFINAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBTFINAL_KeyPress);
            // 
            // LBLTITULO7
            // 
            this.LBLTITULO7.AutoSize = true;
            this.LBLTITULO7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LBLTITULO7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO7.ForeColor = System.Drawing.Color.Green;
            this.LBLTITULO7.Location = new System.Drawing.Point(22, 17);
            this.LBLTITULO7.Name = "LBLTITULO7";
            this.LBLTITULO7.Size = new System.Drawing.Size(190, 29);
            this.LBLTITULO7.TabIndex = 3;
            this.LBLTITULO7.Text = "Calor Necesario:";
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.BackColor = System.Drawing.Color.Transparent;
            this.LBLRESUL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.ForeColor = System.Drawing.Color.Green;
            this.LBLRESUL.Location = new System.Drawing.Point(218, 21);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(78, 25);
            this.LBLRESUL.TabIndex = 4;
            this.LBLRESUL.Text = "0.00  J";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.LBLTITULO7);
            this.panel1.Controls.Add(this.LBLRESUL);
            this.panel1.Location = new System.Drawing.Point(43, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 62);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinAppEjercicio7.Properties.Resources.PESA;
            this.pictureBox2.Location = new System.Drawing.Point(43, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppEjercicio7.Properties.Resources.Agua;
            this.pictureBox1.Location = new System.Drawing.Point(43, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::WinAppEjercicio7.Properties.Resources.RESET;
            this.pictureBox4.Location = new System.Drawing.Point(492, 463);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Green;
            this.BTNCALCULAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCALCULAR.FlatAppearance.BorderSize = 0;
            this.BTNCALCULAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(43, 463);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(414, 47);
            this.BTNCALCULAR.TabIndex = 11;
            this.BTNCALCULAR.Text = "Calcular Calor";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 632);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTBTFINAL);
            this.Controls.Add(this.TXTBTINICIAL);
            this.Controls.Add(this.TXTBCALORIFICA);
            this.Controls.Add(this.TXTBMASA);
            this.Controls.Add(this.LBLTITULO6);
            this.Controls.Add(this.LBLTITULO5);
            this.Controls.Add(this.LBLTITULO4);
            this.Controls.Add(this.LBLTITULO3);
            this.Controls.Add(this.PNPTITULO);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 7";
            this.PNPTITULO.ResumeLayout(false);
            this.PNPTITULO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNPTITULO;
        private System.Windows.Forms.Label LBLTITULO1;
        private System.Windows.Forms.Label LBLTITULO2;
        private System.Windows.Forms.Label LBLTITULO3;
        private System.Windows.Forms.Label LBLTITULO4;
        private System.Windows.Forms.Label LBLTITULO5;
        private System.Windows.Forms.Label LBLTITULO6;
        private System.Windows.Forms.TextBox TXTBMASA;
        private System.Windows.Forms.TextBox TXTBCALORIFICA;
        private System.Windows.Forms.TextBox TXTBTINICIAL;
        private System.Windows.Forms.TextBox TXTBTFINAL;
        private WinAppCalculadora.RJButton BTNCALCULAR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBLTITULO7;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

