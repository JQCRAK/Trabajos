namespace WinAppEjercicio2
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
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.LBLSUBVELOCIDAD = new System.Windows.Forms.Label();
            this.LBLSUBMASA = new System.Windows.Forms.Label();
            this.TXTBMASA = new System.Windows.Forms.TextBox();
            this.TXTVELOCIDAD = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.TXTINFO = new System.Windows.Forms.TextBox();
            this.LBLRESULT = new System.Windows.Forms.Label();
            this.LBLRESULTADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(82, 18);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(379, 35);
            this.LBLTITULO.TabIndex = 0;
            this.LBLTITULO.Text = "Calculadora de Energía Cinética";
            // 
            // LBLSUBVELOCIDAD
            // 
            this.LBLSUBVELOCIDAD.AutoSize = true;
            this.LBLSUBVELOCIDAD.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSUBVELOCIDAD.Location = new System.Drawing.Point(48, 174);
            this.LBLSUBVELOCIDAD.Name = "LBLSUBVELOCIDAD";
            this.LBLSUBVELOCIDAD.Size = new System.Drawing.Size(157, 28);
            this.LBLSUBVELOCIDAD.TabIndex = 1;
            this.LBLSUBVELOCIDAD.Text = "Velocidad (m/s)";
            // 
            // LBLSUBMASA
            // 
            this.LBLSUBMASA.AutoSize = true;
            this.LBLSUBMASA.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSUBMASA.Location = new System.Drawing.Point(48, 78);
            this.LBLSUBMASA.Name = "LBLSUBMASA";
            this.LBLSUBMASA.Size = new System.Drawing.Size(103, 28);
            this.LBLSUBMASA.TabIndex = 2;
            this.LBLSUBMASA.Text = "Masa (kg)";
            // 
            // TXTBMASA
            // 
            this.TXTBMASA.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBMASA.Location = new System.Drawing.Point(53, 124);
            this.TXTBMASA.Name = "TXTBMASA";
            this.TXTBMASA.Size = new System.Drawing.Size(408, 36);
            this.TXTBMASA.TabIndex = 3;
            this.TXTBMASA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBMASA_KeyPress);
            // 
            // TXTVELOCIDAD
            // 
            this.TXTVELOCIDAD.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTVELOCIDAD.Location = new System.Drawing.Point(53, 224);
            this.TXTVELOCIDAD.Name = "TXTVELOCIDAD";
            this.TXTVELOCIDAD.Size = new System.Drawing.Size(408, 36);
            this.TXTVELOCIDAD.TabIndex = 4;
            this.TXTVELOCIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTVELOCIDAD_KeyPress);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Black;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(124, 285);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(269, 36);
            this.BTNCALCULAR.TabIndex = 5;
            this.BTNCALCULAR.Text = "Calcular Energía Cinética";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // TXTINFO
            // 
            this.TXTINFO.BackColor = System.Drawing.Color.White;
            this.TXTINFO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTINFO.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTINFO.Location = new System.Drawing.Point(53, 398);
            this.TXTINFO.Multiline = true;
            this.TXTINFO.Name = "TXTINFO";
            this.TXTINFO.ReadOnly = true;
            this.TXTINFO.Size = new System.Drawing.Size(408, 50);
            this.TXTINFO.TabIndex = 6;
            this.TXTINFO.Text = "Esta calculadora determina la energía cinética de un objeto basándose en su masa " +
    "y velocidad.";
            // 
            // LBLRESULT
            // 
            this.LBLRESULT.AutoSize = true;
            this.LBLRESULT.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULT.Location = new System.Drawing.Point(121, 347);
            this.LBLRESULT.Name = "LBLRESULT";
            this.LBLRESULT.Size = new System.Drawing.Size(171, 28);
            this.LBLRESULT.TabIndex = 7;
            this.LBLRESULT.Text = "Energía Cinética: ";
            // 
            // LBLRESULTADO
            // 
            this.LBLRESULTADO.AutoSize = true;
            this.LBLRESULTADO.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULTADO.Location = new System.Drawing.Point(296, 347);
            this.LBLRESULTADO.Name = "LBLRESULTADO";
            this.LBLRESULTADO.Size = new System.Drawing.Size(0, 28);
            this.LBLRESULTADO.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 460);
            this.Controls.Add(this.LBLRESULTADO);
            this.Controls.Add(this.LBLRESULT);
            this.Controls.Add(this.TXTINFO);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTVELOCIDAD);
            this.Controls.Add(this.TXTBMASA);
            this.Controls.Add(this.LBLSUBMASA);
            this.Controls.Add(this.LBLSUBVELOCIDAD);
            this.Controls.Add(this.LBLTITULO);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.Label LBLSUBVELOCIDAD;
        private System.Windows.Forms.Label LBLSUBMASA;
        private System.Windows.Forms.TextBox TXTBMASA;
        private System.Windows.Forms.TextBox TXTVELOCIDAD;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.TextBox TXTINFO;
        private System.Windows.Forms.Label LBLRESULT;
        private System.Windows.Forms.Label LBLRESULTADO;
    }
}

