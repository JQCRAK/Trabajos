namespace WinAppEjercicio1
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
            this.components = new System.ComponentModel.Container();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.LBLPEDIRV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.LBLRESULTADOT = new System.Windows.Forms.Label();
            this.TXTBINGRESARV = new System.Windows.Forms.TextBox();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.progressBarCifras = new System.Windows.Forms.ProgressBar();
            this.timerCargar = new System.Windows.Forms.Timer(this.components);
            this.PTBRESET = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBRESET)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.ForeColor = System.Drawing.Color.White;
            this.LBLTITULO.Location = new System.Drawing.Point(121, 20);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(301, 40);
            this.LBLTITULO.TabIndex = 0;
            this.LBLTITULO.Text = "Calculadora de Cifras";
            // 
            // LBLPEDIRV
            // 
            this.LBLPEDIRV.AutoSize = true;
            this.LBLPEDIRV.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPEDIRV.Location = new System.Drawing.Point(118, 114);
            this.LBLPEDIRV.Name = "LBLPEDIRV";
            this.LBLPEDIRV.Size = new System.Drawing.Size(271, 28);
            this.LBLPEDIRV.TabIndex = 1;
            this.LBLPEDIRV.Text = "Ingese un numero (Entero): ";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.BTNSALIR);
            this.panel1.Controls.Add(this.LBLTITULO);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 84);
            this.panel1.TabIndex = 3;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Red;
            this.BTNSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSALIR.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Image = global::WinAppEjercicio1.Properties.Resources.Salirmaspeque;
            this.BTNSALIR.Location = new System.Drawing.Point(480, 16);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(39, 44);
            this.BTNSALIR.TabIndex = 11;
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Green;
            this.BTNCALCULAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(185, 222);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(144, 41);
            this.BTNCALCULAR.TabIndex = 4;
            this.BTNCALCULAR.Text = "Calcular";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // LBLRESULTADOT
            // 
            this.LBLRESULTADOT.AutoSize = true;
            this.LBLRESULTADOT.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULTADOT.Location = new System.Drawing.Point(108, 311);
            this.LBLRESULTADOT.Name = "LBLRESULTADOT";
            this.LBLRESULTADOT.Size = new System.Drawing.Size(297, 28);
            this.LBLRESULTADOT.TabIndex = 5;
            this.LBLRESULTADOT.Text = "El numero contiene           cifras";
            // 
            // TXTBINGRESARV
            // 
            this.TXTBINGRESARV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBINGRESARV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTBINGRESARV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTBINGRESARV.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBINGRESARV.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TXTBINGRESARV.Location = new System.Drawing.Point(123, 165);
            this.TXTBINGRESARV.Name = "TXTBINGRESARV";
            this.TXTBINGRESARV.Size = new System.Drawing.Size(266, 36);
            this.TXTBINGRESARV.TabIndex = 1;
            this.TXTBINGRESARV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBINGRESARV_KeyPress);
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LBLRESUL.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBLRESUL.Location = new System.Drawing.Point(319, 311);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(24, 28);
            this.LBLRESUL.TabIndex = 8;
            this.LBLRESUL.Text = "0";
            // 
            // progressBarCifras
            // 
            this.progressBarCifras.Location = new System.Drawing.Point(113, 277);
            this.progressBarCifras.Name = "progressBarCifras";
            this.progressBarCifras.Size = new System.Drawing.Size(287, 23);
            this.progressBarCifras.TabIndex = 10;
            // 
            // PTBRESET
            // 
            this.PTBRESET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PTBRESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PTBRESET.Image = global::WinAppEjercicio1.Properties.Resources.RESET;
            this.PTBRESET.Location = new System.Drawing.Point(410, 165);
            this.PTBRESET.Name = "PTBRESET";
            this.PTBRESET.Size = new System.Drawing.Size(38, 36);
            this.PTBRESET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTBRESET.TabIndex = 9;
            this.PTBRESET.TabStop = false;
            this.PTBRESET.Click += new System.EventHandler(this.PTBRESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 398);
            this.Controls.Add(this.progressBarCifras);
            this.Controls.Add(this.PTBRESET);
            this.Controls.Add(this.LBLRESUL);
            this.Controls.Add(this.TXTBINGRESARV);
            this.Controls.Add(this.LBLRESULTADOT);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.LBLPEDIRV);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBRESET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.Label LBLPEDIRV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.Label LBLRESULTADOT;
        private System.Windows.Forms.TextBox TXTBINGRESARV;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.PictureBox PTBRESET;
        private System.Windows.Forms.ProgressBar progressBarCifras;
        internal System.Windows.Forms.Timer timerCargar;
        private System.Windows.Forms.Button BTNSALIR;
    }
}

