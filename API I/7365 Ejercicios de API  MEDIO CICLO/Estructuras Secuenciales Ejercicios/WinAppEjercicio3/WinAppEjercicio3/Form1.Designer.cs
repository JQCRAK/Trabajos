namespace WinAppEjercicio3
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
            this.LBLTIRESUL = new System.Windows.Forms.Label();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.LBLTERESUL = new System.Windows.Forms.Label();
            this.LBLPREGUNTA = new System.Windows.Forms.Label();
            this.LBLSUBTITULO = new System.Windows.Forms.Label();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.TXTBINGRESARV = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PCBRESET = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCBRESET)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTIRESUL
            // 
            this.LBLTIRESUL.AutoSize = true;
            this.LBLTIRESUL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTIRESUL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBLTIRESUL.Location = new System.Drawing.Point(220, 286);
            this.LBLTIRESUL.Name = "LBLTIRESUL";
            this.LBLTIRESUL.Size = new System.Drawing.Size(118, 24);
            this.LBLTIRESUL.TabIndex = 0;
            this.LBLTIRESUL.Text = "Resultado:";
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.Location = new System.Drawing.Point(272, 343);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(21, 24);
            this.LBLRESUL.TabIndex = 1;
            this.LBLRESUL.Text = "0";
            // 
            // LBLTERESUL
            // 
            this.LBLTERESUL.AutoSize = true;
            this.LBLTERESUL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTERESUL.Location = new System.Drawing.Point(116, 343);
            this.LBLTERESUL.Name = "LBLTERESUL";
            this.LBLTERESUL.Size = new System.Drawing.Size(151, 24);
            this.LBLTERESUL.TabIndex = 2;
            this.LBLTERESUL.Text = "Altura de caída:";
            // 
            // LBLPREGUNTA
            // 
            this.LBLPREGUNTA.AutoSize = true;
            this.LBLPREGUNTA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPREGUNTA.Location = new System.Drawing.Point(48, 120);
            this.LBLPREGUNTA.Name = "LBLPREGUNTA";
            this.LBLPREGUNTA.Size = new System.Drawing.Size(277, 24);
            this.LBLPREGUNTA.TabIndex = 3;
            this.LBLPREGUNTA.Text = "Tiempo de caída (segundos): ";
            // 
            // LBLSUBTITULO
            // 
            this.LBLSUBTITULO.AutoSize = true;
            this.LBLSUBTITULO.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSUBTITULO.ForeColor = System.Drawing.Color.Gray;
            this.LBLSUBTITULO.Location = new System.Drawing.Point(105, 68);
            this.LBLSUBTITULO.Name = "LBLSUBTITULO";
            this.LBLSUBTITULO.Size = new System.Drawing.Size(351, 21);
            this.LBLSUBTITULO.TabIndex = 4;
            this.LBLSUBTITULO.Text = "Calcule la altura de caída basada en el tiempo";
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBLTITULO.Location = new System.Drawing.Point(93, 18);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(390, 34);
            this.LBLTITULO.TabIndex = 5;
            this.LBLTITULO.Text = "Calculadora de Caída Libre";
            // 
            // TXTBINGRESARV
            // 
            this.TXTBINGRESARV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBINGRESARV.Location = new System.Drawing.Point(52, 163);
            this.TXTBINGRESARV.Name = "TXTBINGRESARV";
            this.TXTBINGRESARV.Size = new System.Drawing.Size(404, 32);
            this.TXTBINGRESARV.TabIndex = 6;
            this.TXTBINGRESARV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBINGRESARV_KeyPress);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Black;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(52, 217);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(454, 43);
            this.BTNCALCULAR.TabIndex = 7;
            this.BTNCALCULAR.Text = "Calcular Altura";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // PCBRESET
            // 
            this.PCBRESET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBRESET.Image = global::WinAppEjercicio3.Properties.Resources.RESET;
            this.PCBRESET.Location = new System.Drawing.Point(483, 163);
            this.PCBRESET.Name = "PCBRESET";
            this.PCBRESET.Size = new System.Drawing.Size(41, 32);
            this.PCBRESET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBRESET.TabIndex = 10;
            this.PCBRESET.TabStop = false;
            this.PCBRESET.Click += new System.EventHandler(this.PCBRESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 413);
            this.Controls.Add(this.PCBRESET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTBINGRESARV);
            this.Controls.Add(this.LBLTITULO);
            this.Controls.Add(this.LBLSUBTITULO);
            this.Controls.Add(this.LBLPREGUNTA);
            this.Controls.Add(this.LBLTERESUL);
            this.Controls.Add(this.LBLRESUL);
            this.Controls.Add(this.LBLTIRESUL);
            this.Name = "Form1";
            this.Text = "Ejercicio 3";
            ((System.ComponentModel.ISupportInitialize)(this.PCBRESET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTIRESUL;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.Label LBLTERESUL;
        private System.Windows.Forms.Label LBLPREGUNTA;
        private System.Windows.Forms.Label LBLSUBTITULO;
        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.TextBox TXTBINGRESARV;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PCBRESET;
    }
}

