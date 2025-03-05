namespace WinAppEjercicio4
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
            this.LBLRESULSALARIONETO = new System.Windows.Forms.Label();
            this.LBLIRESULMPUESTOS = new System.Windows.Forms.Label();
            this.LBLRESULSALARIOBRUTO = new System.Windows.Forms.Label();
            this.LBLTITULO2 = new System.Windows.Forms.Label();
            this.LBLTITULO1 = new System.Windows.Forms.Label();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.TXTBTRABAJAS = new System.Windows.Forms.TextBox();
            this.TXTBHORA = new System.Windows.Forms.TextBox();
            this.BTNCALCULARS = new System.Windows.Forms.Button();
            this.TXTRESULTADOT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLRESULSALARIONETO
            // 
            this.LBLRESULSALARIONETO.AutoSize = true;
            this.LBLRESULSALARIONETO.BackColor = System.Drawing.Color.White;
            this.LBLRESULSALARIONETO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULSALARIONETO.Location = new System.Drawing.Point(224, 381);
            this.LBLRESULSALARIONETO.Name = "LBLRESULSALARIONETO";
            this.LBLRESULSALARIONETO.Size = new System.Drawing.Size(21, 24);
            this.LBLRESULSALARIONETO.TabIndex = 0;
            this.LBLRESULSALARIONETO.Text = "0";
            // 
            // LBLIRESULMPUESTOS
            // 
            this.LBLIRESULMPUESTOS.AutoSize = true;
            this.LBLIRESULMPUESTOS.BackColor = System.Drawing.Color.White;
            this.LBLIRESULMPUESTOS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIRESULMPUESTOS.Location = new System.Drawing.Point(225, 354);
            this.LBLIRESULMPUESTOS.Name = "LBLIRESULMPUESTOS";
            this.LBLIRESULMPUESTOS.Size = new System.Drawing.Size(21, 24);
            this.LBLIRESULMPUESTOS.TabIndex = 1;
            this.LBLIRESULMPUESTOS.Text = "0";
            // 
            // LBLRESULSALARIOBRUTO
            // 
            this.LBLRESULSALARIOBRUTO.AutoSize = true;
            this.LBLRESULSALARIOBRUTO.BackColor = System.Drawing.Color.White;
            this.LBLRESULSALARIOBRUTO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULSALARIOBRUTO.Location = new System.Drawing.Point(225, 328);
            this.LBLRESULSALARIOBRUTO.Name = "LBLRESULSALARIOBRUTO";
            this.LBLRESULSALARIOBRUTO.Size = new System.Drawing.Size(21, 24);
            this.LBLRESULSALARIOBRUTO.TabIndex = 2;
            this.LBLRESULSALARIOBRUTO.Text = "0";
            // 
            // LBLTITULO2
            // 
            this.LBLTITULO2.AutoSize = true;
            this.LBLTITULO2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO2.Location = new System.Drawing.Point(293, 107);
            this.LBLTITULO2.Name = "LBLTITULO2";
            this.LBLTITULO2.Size = new System.Drawing.Size(168, 24);
            this.LBLTITULO2.TabIndex = 3;
            this.LBLTITULO2.Text = "Horas Trabajadas";
            // 
            // LBLTITULO1
            // 
            this.LBLTITULO1.AutoSize = true;
            this.LBLTITULO1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO1.Location = new System.Drawing.Point(26, 107);
            this.LBLTITULO1.Name = "LBLTITULO1";
            this.LBLTITULO1.Size = new System.Drawing.Size(146, 24);
            this.LBLTITULO1.TabIndex = 4;
            this.LBLTITULO1.Text = "Tarifa por Hora";
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(115, 21);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(329, 34);
            this.LBLTITULO.TabIndex = 5;
            this.LBLTITULO.Text = "Calculadora de Salario";
            // 
            // TXTBTRABAJAS
            // 
            this.TXTBTRABAJAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBTRABAJAS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTRABAJAS.Location = new System.Drawing.Point(297, 150);
            this.TXTBTRABAJAS.Name = "TXTBTRABAJAS";
            this.TXTBTRABAJAS.Size = new System.Drawing.Size(231, 32);
            this.TXTBTRABAJAS.TabIndex = 2;
            this.TXTBTRABAJAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBTRABAJAS_KeyPress);
            // 
            // TXTBHORA
            // 
            this.TXTBHORA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBHORA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBHORA.Location = new System.Drawing.Point(30, 150);
            this.TXTBHORA.Name = "TXTBHORA";
            this.TXTBHORA.Size = new System.Drawing.Size(231, 32);
            this.TXTBHORA.TabIndex = 1;
            this.TXTBHORA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBHORA_KeyPress);
            // 
            // BTNCALCULARS
            // 
            this.BTNCALCULARS.BackColor = System.Drawing.Color.Black;
            this.BTNCALCULARS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCALCULARS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULARS.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULARS.Location = new System.Drawing.Point(30, 213);
            this.BTNCALCULARS.Name = "BTNCALCULARS";
            this.BTNCALCULARS.Size = new System.Drawing.Size(498, 44);
            this.BTNCALCULARS.TabIndex = 8;
            this.BTNCALCULARS.Text = "Calcular Salario";
            this.BTNCALCULARS.UseVisualStyleBackColor = false;
            this.BTNCALCULARS.Click += new System.EventHandler(this.BTNCALCULARS_Click);
            // 
            // TXTRESULTADOT
            // 
            this.TXTRESULTADOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTRESULTADOT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTRESULTADOT.Location = new System.Drawing.Point(34, 284);
            this.TXTRESULTADOT.Multiline = true;
            this.TXTRESULTADOT.Name = "TXTRESULTADOT";
            this.TXTRESULTADOT.Size = new System.Drawing.Size(494, 125);
            this.TXTRESULTADOT.TabIndex = 9;
            this.TXTRESULTADOT.Text = "Resultados:\r\n\r\nSalario Bruto: \r\nImpuestos (12%): \r\nSalario Neto: \r\n\r\n\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WinAppEjercicio4.Properties.Resources.RESET;
            this.pictureBox1.Location = new System.Drawing.Point(488, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCALCULARS);
            this.Controls.Add(this.TXTBHORA);
            this.Controls.Add(this.TXTBTRABAJAS);
            this.Controls.Add(this.LBLTITULO);
            this.Controls.Add(this.LBLTITULO1);
            this.Controls.Add(this.LBLTITULO2);
            this.Controls.Add(this.LBLRESULSALARIOBRUTO);
            this.Controls.Add(this.LBLIRESULMPUESTOS);
            this.Controls.Add(this.LBLRESULSALARIONETO);
            this.Controls.Add(this.TXTRESULTADOT);
            this.Name = "Form1";
            this.Text = "Ejercicio 4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLRESULSALARIONETO;
        private System.Windows.Forms.Label LBLIRESULMPUESTOS;
        private System.Windows.Forms.Label LBLRESULSALARIOBRUTO;
        private System.Windows.Forms.Label LBLTITULO2;
        private System.Windows.Forms.Label LBLTITULO1;
        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.TextBox TXTBTRABAJAS;
        private System.Windows.Forms.TextBox TXTBHORA;
        private System.Windows.Forms.Button BTNCALCULARS;
        private System.Windows.Forms.TextBox TXTRESULTADOT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

