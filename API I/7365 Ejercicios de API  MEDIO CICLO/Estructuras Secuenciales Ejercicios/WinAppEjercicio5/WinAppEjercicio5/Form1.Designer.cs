namespace WinAppEjercicio5
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
            this.LBLTITULO2 = new System.Windows.Forms.Label();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.TXTBINGRESARS = new System.Windows.Forms.TextBox();
            this.BTNCONVERTIR = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTITULO1
            // 
            this.LBLTITULO1.AutoSize = true;
            this.LBLTITULO1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBLTITULO1.Location = new System.Drawing.Point(24, 87);
            this.LBLTITULO1.Name = "LBLTITULO1";
            this.LBLTITULO1.Size = new System.Drawing.Size(325, 27);
            this.LBLTITULO1.TabIndex = 0;
            this.LBLTITULO1.Text = "Ingrese la cantidad de segundos:";
            // 
            // LBLTITULO2
            // 
            this.LBLTITULO2.AutoSize = true;
            this.LBLTITULO2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO2.Location = new System.Drawing.Point(171, 238);
            this.LBLTITULO2.Name = "LBLTITULO2";
            this.LBLTITULO2.Size = new System.Drawing.Size(113, 27);
            this.LBLTITULO2.TabIndex = 1;
            this.LBLTITULO2.Text = "Resultado";
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.Location = new System.Drawing.Point(177, 274);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(94, 27);
            this.LBLRESUL.TabIndex = 2;
            this.LBLRESUL.Text = "00:00:00";
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(112, 30);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(285, 33);
            this.LBLTITULO.TabIndex = 3;
            this.LBLTITULO.Text = "Conversor de Tiempo";
            // 
            // TXTBINGRESARS
            // 
            this.TXTBINGRESARS.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBINGRESARS.Location = new System.Drawing.Point(29, 129);
            this.TXTBINGRESARS.Name = "TXTBINGRESARS";
            this.TXTBINGRESARS.Size = new System.Drawing.Size(343, 34);
            this.TXTBINGRESARS.TabIndex = 4;
            this.TXTBINGRESARS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBINGRESARS_KeyPress);
            // 
            // BTNCONVERTIR
            // 
            this.BTNCONVERTIR.BackColor = System.Drawing.Color.Black;
            this.BTNCONVERTIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCONVERTIR.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONVERTIR.ForeColor = System.Drawing.Color.White;
            this.BTNCONVERTIR.Location = new System.Drawing.Point(118, 185);
            this.BTNCONVERTIR.Name = "BTNCONVERTIR";
            this.BTNCONVERTIR.Size = new System.Drawing.Size(221, 34);
            this.BTNCONVERTIR.TabIndex = 5;
            this.BTNCONVERTIR.Text = "Convertir";
            this.BTNCONVERTIR.UseVisualStyleBackColor = false;
            this.BTNCONVERTIR.Click += new System.EventHandler(this.BTNCONVERTIR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WinAppEjercicio5.Properties.Resources.RESET;
            this.pictureBox2.Location = new System.Drawing.Point(385, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppEjercicio5.Properties.Resources.reloj_N;
            this.pictureBox1.Location = new System.Drawing.Point(75, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 339);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCONVERTIR);
            this.Controls.Add(this.TXTBINGRESARS);
            this.Controls.Add(this.LBLTITULO);
            this.Controls.Add(this.LBLRESUL);
            this.Controls.Add(this.LBLTITULO2);
            this.Controls.Add(this.LBLTITULO1);
            this.Name = "Form1";
            this.Text = "Ejercicio 5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO1;
        private System.Windows.Forms.Label LBLTITULO2;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.TextBox TXTBINGRESARS;
        private System.Windows.Forms.Button BTNCONVERTIR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

