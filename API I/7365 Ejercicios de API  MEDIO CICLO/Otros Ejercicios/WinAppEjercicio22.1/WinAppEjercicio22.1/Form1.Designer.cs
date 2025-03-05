namespace WinAppEjercicio22._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNCARGAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNGUARDAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PCBCOLORDIA = new System.Windows.Forms.PictureBox();
            this.CMBTIPOLETRA = new System.Windows.Forms.ComboBox();
            this.CMBTAMANIO = new System.Windows.Forms.ComboBox();
            this.PCBALINEADODE = new System.Windows.Forms.PictureBox();
            this.PCBTALINEADOCE = new System.Windows.Forms.PictureBox();
            this.PCBALINEADOIZ = new System.Windows.Forms.PictureBox();
            this.BTNTSUBRAYADO = new System.Windows.Forms.Button();
            this.BTNTCURSIVA = new System.Windows.Forms.Button();
            this.RTBINFORMACION = new System.Windows.Forms.RichTextBox();
            this.BTNTNEGRITA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCOLORDIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBALINEADODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBTALINEADOCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBALINEADOIZ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTNCARGAR);
            this.panel1.Controls.Add(this.BTNGUARDAR);
            this.panel1.Controls.Add(this.PCBCOLORDIA);
            this.panel1.Controls.Add(this.CMBTIPOLETRA);
            this.panel1.Controls.Add(this.CMBTAMANIO);
            this.panel1.Controls.Add(this.PCBALINEADODE);
            this.panel1.Controls.Add(this.PCBTALINEADOCE);
            this.panel1.Controls.Add(this.PCBALINEADOIZ);
            this.panel1.Controls.Add(this.BTNTSUBRAYADO);
            this.panel1.Controls.Add(this.BTNTCURSIVA);
            this.panel1.Controls.Add(this.RTBINFORMACION);
            this.panel1.Controls.Add(this.BTNTNEGRITA);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 513);
            this.panel1.TabIndex = 0;
            // 
            // BTNCARGAR
            // 
            this.BTNCARGAR.Activecolor = System.Drawing.Color.Indigo;
            this.BTNCARGAR.BackColor = System.Drawing.Color.Indigo;
            this.BTNCARGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNCARGAR.BorderRadius = 0;
            this.BTNCARGAR.ButtonText = "               Cargar";
            this.BTNCARGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCARGAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNCARGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCARGAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNCARGAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNCARGAR.Iconimage")));
            this.BTNCARGAR.Iconimage_right = null;
            this.BTNCARGAR.Iconimage_right_Selected = null;
            this.BTNCARGAR.Iconimage_Selected = null;
            this.BTNCARGAR.IconMarginLeft = 0;
            this.BTNCARGAR.IconMarginRight = 0;
            this.BTNCARGAR.IconRightVisible = true;
            this.BTNCARGAR.IconRightZoom = 0D;
            this.BTNCARGAR.IconVisible = true;
            this.BTNCARGAR.IconZoom = 90D;
            this.BTNCARGAR.IsTab = false;
            this.BTNCARGAR.Location = new System.Drawing.Point(501, 452);
            this.BTNCARGAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCARGAR.Name = "BTNCARGAR";
            this.BTNCARGAR.Normalcolor = System.Drawing.Color.Indigo;
            this.BTNCARGAR.OnHovercolor = System.Drawing.Color.Indigo;
            this.BTNCARGAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNCARGAR.selected = false;
            this.BTNCARGAR.Size = new System.Drawing.Size(201, 48);
            this.BTNCARGAR.TabIndex = 12;
            this.BTNCARGAR.Text = "               Cargar";
            this.BTNCARGAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCARGAR.Textcolor = System.Drawing.Color.White;
            this.BTNCARGAR.TextFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCARGAR.Click += new System.EventHandler(this.BTNCARGAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Activecolor = System.Drawing.Color.Indigo;
            this.BTNGUARDAR.BackColor = System.Drawing.Color.Indigo;
            this.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNGUARDAR.BorderRadius = 0;
            this.BTNGUARDAR.ButtonText = "               Guardar";
            this.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGUARDAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNGUARDAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Iconimage")));
            this.BTNGUARDAR.Iconimage_right = null;
            this.BTNGUARDAR.Iconimage_right_Selected = null;
            this.BTNGUARDAR.Iconimage_Selected = null;
            this.BTNGUARDAR.IconMarginLeft = 0;
            this.BTNGUARDAR.IconMarginRight = 0;
            this.BTNGUARDAR.IconRightVisible = true;
            this.BTNGUARDAR.IconRightZoom = 0D;
            this.BTNGUARDAR.IconVisible = true;
            this.BTNGUARDAR.IconZoom = 90D;
            this.BTNGUARDAR.IsTab = false;
            this.BTNGUARDAR.Location = new System.Drawing.Point(63, 452);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Normalcolor = System.Drawing.Color.Indigo;
            this.BTNGUARDAR.OnHovercolor = System.Drawing.Color.Indigo;
            this.BTNGUARDAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNGUARDAR.selected = false;
            this.BTNGUARDAR.Size = new System.Drawing.Size(201, 48);
            this.BTNGUARDAR.TabIndex = 11;
            this.BTNGUARDAR.Text = "               Guardar";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Textcolor = System.Drawing.Color.White;
            this.BTNGUARDAR.TextFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // PCBCOLORDIA
            // 
            this.PCBCOLORDIA.BackColor = System.Drawing.Color.Black;
            this.PCBCOLORDIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBCOLORDIA.Location = new System.Drawing.Point(710, 16);
            this.PCBCOLORDIA.Name = "PCBCOLORDIA";
            this.PCBCOLORDIA.Size = new System.Drawing.Size(35, 35);
            this.PCBCOLORDIA.TabIndex = 10;
            this.PCBCOLORDIA.TabStop = false;
            this.PCBCOLORDIA.Click += new System.EventHandler(this.PCBCOLORDIA_Click);
            // 
            // CMBTIPOLETRA
            // 
            this.CMBTIPOLETRA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CMBTIPOLETRA.FormattingEnabled = true;
            this.CMBTIPOLETRA.Location = new System.Drawing.Point(538, 19);
            this.CMBTIPOLETRA.Name = "CMBTIPOLETRA";
            this.CMBTIPOLETRA.Size = new System.Drawing.Size(143, 32);
            this.CMBTIPOLETRA.TabIndex = 9;
            this.CMBTIPOLETRA.SelectedIndexChanged += new System.EventHandler(this.CMBTIPOLETRA_SelectedIndexChanged);
            // 
            // CMBTAMANIO
            // 
            this.CMBTAMANIO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CMBTAMANIO.FormattingEnabled = true;
            this.CMBTAMANIO.Location = new System.Drawing.Point(388, 19);
            this.CMBTAMANIO.Name = "CMBTAMANIO";
            this.CMBTAMANIO.Size = new System.Drawing.Size(121, 32);
            this.CMBTAMANIO.TabIndex = 8;
            this.CMBTAMANIO.SelectedIndexChanged += new System.EventHandler(this.CMBTAMANIO_SelectedIndexChanged);
            // 
            // PCBALINEADODE
            // 
            this.PCBALINEADODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBALINEADODE.Image = ((System.Drawing.Image)(resources.GetObject("PCBALINEADODE.Image")));
            this.PCBALINEADODE.Location = new System.Drawing.Point(326, 19);
            this.PCBALINEADODE.Name = "PCBALINEADODE";
            this.PCBALINEADODE.Size = new System.Drawing.Size(35, 35);
            this.PCBALINEADODE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBALINEADODE.TabIndex = 7;
            this.PCBALINEADODE.TabStop = false;
            this.PCBALINEADODE.Click += new System.EventHandler(this.PCBALINEADODE_Click);
            // 
            // PCBTALINEADOCE
            // 
            this.PCBTALINEADOCE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBTALINEADOCE.Image = ((System.Drawing.Image)(resources.GetObject("PCBTALINEADOCE.Image")));
            this.PCBTALINEADOCE.Location = new System.Drawing.Point(266, 19);
            this.PCBTALINEADOCE.Name = "PCBTALINEADOCE";
            this.PCBTALINEADOCE.Size = new System.Drawing.Size(35, 35);
            this.PCBTALINEADOCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBTALINEADOCE.TabIndex = 6;
            this.PCBTALINEADOCE.TabStop = false;
            this.PCBTALINEADOCE.Click += new System.EventHandler(this.PCBTALINEADOCE_Click);
            // 
            // PCBALINEADOIZ
            // 
            this.PCBALINEADOIZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBALINEADOIZ.Image = ((System.Drawing.Image)(resources.GetObject("PCBALINEADOIZ.Image")));
            this.PCBALINEADOIZ.Location = new System.Drawing.Point(206, 19);
            this.PCBALINEADOIZ.Name = "PCBALINEADOIZ";
            this.PCBALINEADOIZ.Size = new System.Drawing.Size(35, 35);
            this.PCBALINEADOIZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBALINEADOIZ.TabIndex = 5;
            this.PCBALINEADOIZ.TabStop = false;
            this.PCBALINEADOIZ.Click += new System.EventHandler(this.PCBALINEADOIZ_Click);
            // 
            // BTNTSUBRAYADO
            // 
            this.BTNTSUBRAYADO.BackColor = System.Drawing.Color.White;
            this.BTNTSUBRAYADO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTSUBRAYADO.ForeColor = System.Drawing.Color.Black;
            this.BTNTSUBRAYADO.Location = new System.Drawing.Point(145, 15);
            this.BTNTSUBRAYADO.Name = "BTNTSUBRAYADO";
            this.BTNTSUBRAYADO.Size = new System.Drawing.Size(44, 44);
            this.BTNTSUBRAYADO.TabIndex = 4;
            this.BTNTSUBRAYADO.Text = "U̲";
            this.BTNTSUBRAYADO.UseVisualStyleBackColor = false;
            this.BTNTSUBRAYADO.Click += new System.EventHandler(this.BTNTSUBRAYADO_Click);
            // 
            // BTNTCURSIVA
            // 
            this.BTNTCURSIVA.BackColor = System.Drawing.Color.White;
            this.BTNTCURSIVA.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTCURSIVA.ForeColor = System.Drawing.Color.Black;
            this.BTNTCURSIVA.Location = new System.Drawing.Point(84, 15);
            this.BTNTCURSIVA.Name = "BTNTCURSIVA";
            this.BTNTCURSIVA.Size = new System.Drawing.Size(44, 44);
            this.BTNTCURSIVA.TabIndex = 3;
            this.BTNTCURSIVA.Text = "I";
            this.BTNTCURSIVA.UseVisualStyleBackColor = false;
            this.BTNTCURSIVA.Click += new System.EventHandler(this.BTNTCURSIVA_Click);
            // 
            // RTBINFORMACION
            // 
            this.RTBINFORMACION.Location = new System.Drawing.Point(23, 79);
            this.RTBINFORMACION.Name = "RTBINFORMACION";
            this.RTBINFORMACION.Size = new System.Drawing.Size(722, 349);
            this.RTBINFORMACION.TabIndex = 2;
            this.RTBINFORMACION.Text = "";
            // 
            // BTNTNEGRITA
            // 
            this.BTNTNEGRITA.BackColor = System.Drawing.Color.White;
            this.BTNTNEGRITA.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTNEGRITA.ForeColor = System.Drawing.Color.Black;
            this.BTNTNEGRITA.Location = new System.Drawing.Point(23, 15);
            this.BTNTNEGRITA.Name = "BTNTNEGRITA";
            this.BTNTNEGRITA.Size = new System.Drawing.Size(44, 44);
            this.BTNTNEGRITA.TabIndex = 1;
            this.BTNTNEGRITA.Text = "B";
            this.BTNTNEGRITA.UseVisualStyleBackColor = false;
            this.BTNTNEGRITA.Click += new System.EventHandler(this.BTNTNEGRITA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editor de Texto Mágico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 22";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCBCOLORDIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBALINEADODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBTALINEADOCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBALINEADOIZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNTNEGRITA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBINFORMACION;
        private System.Windows.Forms.Button BTNTSUBRAYADO;
        private System.Windows.Forms.Button BTNTCURSIVA;
        private System.Windows.Forms.PictureBox PCBALINEADOIZ;
        private System.Windows.Forms.ComboBox CMBTIPOLETRA;
        private System.Windows.Forms.ComboBox CMBTAMANIO;
        private System.Windows.Forms.PictureBox PCBALINEADODE;
        private System.Windows.Forms.PictureBox PCBTALINEADOCE;
        private System.Windows.Forms.PictureBox PCBCOLORDIA;
        private Bunifu.Framework.UI.BunifuFlatButton BTNCARGAR;
        private Bunifu.Framework.UI.BunifuFlatButton BTNGUARDAR;
    }
}

