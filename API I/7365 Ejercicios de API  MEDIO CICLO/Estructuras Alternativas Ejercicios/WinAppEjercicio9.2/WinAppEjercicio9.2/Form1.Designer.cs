namespace WinAppEjercicio9._2
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
            this.LBLTITULO3 = new System.Windows.Forms.Label();
            this.LBLTITULO4 = new System.Windows.Forms.Label();
            this.TXTBTITULO2 = new System.Windows.Forms.TextBox();
            this.TXTBEDAD = new System.Windows.Forms.TextBox();
            this.CMBGENEROP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNOBTENERR = new System.Windows.Forms.Button();
            this.RBTNSERIES = new System.Windows.Forms.RadioButton();
            this.RBTNPELICULAS = new System.Windows.Forms.RadioButton();
            this.GPBPREFERENCIA = new System.Windows.Forms.GroupBox();
            this.GPBPREFERENCIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLTITULO1
            // 
            this.LBLTITULO1.AutoSize = true;
            this.LBLTITULO1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO1.Location = new System.Drawing.Point(85, 27);
            this.LBLTITULO1.Name = "LBLTITULO1";
            this.LBLTITULO1.Size = new System.Drawing.Size(430, 35);
            this.LBLTITULO1.TabIndex = 0;
            this.LBLTITULO1.Text = "Recomendador de Películas y Series";
            // 
            // LBLTITULO3
            // 
            this.LBLTITULO3.AutoSize = true;
            this.LBLTITULO3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO3.Location = new System.Drawing.Point(25, 167);
            this.LBLTITULO3.Name = "LBLTITULO3";
            this.LBLTITULO3.Size = new System.Drawing.Size(64, 31);
            this.LBLTITULO3.TabIndex = 2;
            this.LBLTITULO3.Text = "Edad";
            // 
            // LBLTITULO4
            // 
            this.LBLTITULO4.AutoSize = true;
            this.LBLTITULO4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO4.Location = new System.Drawing.Point(25, 268);
            this.LBLTITULO4.Name = "LBLTITULO4";
            this.LBLTITULO4.Size = new System.Drawing.Size(189, 31);
            this.LBLTITULO4.TabIndex = 3;
            this.LBLTITULO4.Text = "Género Preferido";
            // 
            // TXTBTITULO2
            // 
            this.TXTBTITULO2.BackColor = System.Drawing.Color.LightCyan;
            this.TXTBTITULO2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBTITULO2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTITULO2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTBTITULO2.Location = new System.Drawing.Point(31, 87);
            this.TXTBTITULO2.Multiline = true;
            this.TXTBTITULO2.Name = "TXTBTITULO2";
            this.TXTBTITULO2.Size = new System.Drawing.Size(530, 66);
            this.TXTBTITULO2.TabIndex = 5;
            this.TXTBTITULO2.TabStop = false;
            this.TXTBTITULO2.Text = "Ingrese sus preferencias para obtener recomendaciones personalizadas.";
            // 
            // TXTBEDAD
            // 
            this.TXTBEDAD.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBEDAD.Location = new System.Drawing.Point(31, 212);
            this.TXTBEDAD.Name = "TXTBEDAD";
            this.TXTBEDAD.Size = new System.Drawing.Size(546, 38);
            this.TXTBEDAD.TabIndex = 6;
            this.TXTBEDAD.TextChanged += new System.EventHandler(this.TXTBEDAD_TextChanged);
            this.TXTBEDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBEDAD_KeyPress);
            // 
            // CMBGENEROP
            // 
            this.CMBGENEROP.BackColor = System.Drawing.Color.White;
            this.CMBGENEROP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBGENEROP.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBGENEROP.ForeColor = System.Drawing.Color.Black;
            this.CMBGENEROP.FormattingEnabled = true;
            this.CMBGENEROP.Items.AddRange(new object[] {
            "Animación",
            "Ciencia Ficción",
            "Drama",
            "Otro"});
            this.CMBGENEROP.Location = new System.Drawing.Point(34, 316);
            this.CMBGENEROP.Name = "CMBGENEROP";
            this.CMBGENEROP.Size = new System.Drawing.Size(543, 39);
            this.CMBGENEROP.TabIndex = 7;
            this.CMBGENEROP.SelectedIndexChanged += new System.EventHandler(this.CMBGENEROP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Género Preferido";
            // 
            // BTNOBTENERR
            // 
            this.BTNOBTENERR.BackColor = System.Drawing.Color.Black;
            this.BTNOBTENERR.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOBTENERR.ForeColor = System.Drawing.Color.White;
            this.BTNOBTENERR.Location = new System.Drawing.Point(34, 515);
            this.BTNOBTENERR.Name = "BTNOBTENERR";
            this.BTNOBTENERR.Size = new System.Drawing.Size(543, 53);
            this.BTNOBTENERR.TabIndex = 10;
            this.BTNOBTENERR.Text = "Obtener Recomendaciones";
            this.BTNOBTENERR.UseVisualStyleBackColor = false;
            this.BTNOBTENERR.Click += new System.EventHandler(this.BTNOBTENERR_Click);
            // 
            // RBTNSERIES
            // 
            this.RBTNSERIES.AutoSize = true;
            this.RBTNSERIES.Location = new System.Drawing.Point(21, 37);
            this.RBTNSERIES.Name = "RBTNSERIES";
            this.RBTNSERIES.Size = new System.Drawing.Size(98, 35);
            this.RBTNSERIES.TabIndex = 8;
            this.RBTNSERIES.TabStop = true;
            this.RBTNSERIES.Text = "Series";
            this.RBTNSERIES.UseVisualStyleBackColor = true;
            this.RBTNSERIES.CheckedChanged += new System.EventHandler(this.RBTNSERIES_CheckedChanged);
            // 
            // RBTNPELICULAS
            // 
            this.RBTNPELICULAS.AutoSize = true;
            this.RBTNPELICULAS.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNPELICULAS.Location = new System.Drawing.Point(18, 68);
            this.RBTNPELICULAS.Name = "RBTNPELICULAS";
            this.RBTNPELICULAS.Size = new System.Drawing.Size(124, 35);
            this.RBTNPELICULAS.TabIndex = 9;
            this.RBTNPELICULAS.TabStop = true;
            this.RBTNPELICULAS.Text = "Películas";
            this.RBTNPELICULAS.UseVisualStyleBackColor = true;
            this.RBTNPELICULAS.CheckedChanged += new System.EventHandler(this.RBTNPELICULAS_CheckedChanged);
            // 
            // GPBPREFERENCIA
            // 
            this.GPBPREFERENCIA.Controls.Add(this.RBTNPELICULAS);
            this.GPBPREFERENCIA.Controls.Add(this.RBTNSERIES);
            this.GPBPREFERENCIA.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBPREFERENCIA.Location = new System.Drawing.Point(31, 377);
            this.GPBPREFERENCIA.Name = "GPBPREFERENCIA";
            this.GPBPREFERENCIA.Size = new System.Drawing.Size(546, 120);
            this.GPBPREFERENCIA.TabIndex = 9;
            this.GPBPREFERENCIA.TabStop = false;
            this.GPBPREFERENCIA.Text = "Preferencia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(604, 602);
            this.Controls.Add(this.BTNOBTENERR);
            this.Controls.Add(this.GPBPREFERENCIA);
            this.Controls.Add(this.CMBGENEROP);
            this.Controls.Add(this.TXTBEDAD);
            this.Controls.Add(this.TXTBTITULO2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLTITULO4);
            this.Controls.Add(this.LBLTITULO3);
            this.Controls.Add(this.LBLTITULO1);
            this.Name = "Form1";
            this.Text = "Ejercicio 9";
            this.GPBPREFERENCIA.ResumeLayout(false);
            this.GPBPREFERENCIA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO1;
        private System.Windows.Forms.Label LBLTITULO3;
        private System.Windows.Forms.Label LBLTITULO4;
        private System.Windows.Forms.TextBox TXTBTITULO2;
        private System.Windows.Forms.TextBox TXTBEDAD;
        private System.Windows.Forms.ComboBox CMBGENEROP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNOBTENERR;
        private System.Windows.Forms.RadioButton RBTNSERIES;
        private System.Windows.Forms.RadioButton RBTNPELICULAS;
        private System.Windows.Forms.GroupBox GPBPREFERENCIA;
    }
}

