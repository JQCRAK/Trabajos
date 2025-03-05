namespace WindowsAppPractica2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsubArcSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBXCURSOR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBXCURSORES = new System.Windows.Forms.GroupBox();
            this.GBXSONIDO = new System.Windows.Forms.GroupBox();
            this.BTNEXCLAMACION = new System.Windows.Forms.Button();
            this.BTNASTERIS = new System.Windows.Forms.Button();
            this.BTNBEEP = new System.Windows.Forms.Button();
            this.BTNVENTANA = new System.Windows.Forms.Button();
            this.pROYECTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GBXCURSORES.SuspendLayout();
            this.GBXSONIDO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.coloroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnsubArcSalir,
            this.colorToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // MnsubArcSalir
            // 
            this.MnsubArcSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MnsubArcSalir.Checked = true;
            this.MnsubArcSalir.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.MnsubArcSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MnsubArcSalir.ForeColor = System.Drawing.Color.White;
            this.MnsubArcSalir.Name = "MnsubArcSalir";
            this.MnsubArcSalir.Size = new System.Drawing.Size(224, 26);
            this.MnsubArcSalir.Text = "Salir";
            this.MnsubArcSalir.Click += new System.EventHandler(this.MnsubArcSalir_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROYECTOToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // coloroToolStripMenuItem
            // 
            this.coloroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.amarilloToolStripMenuItem});
            this.coloroToolStripMenuItem.Name = "coloroToolStripMenuItem";
            this.coloroToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.coloroToolStripMenuItem.Text = "Color";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.amarilloToolStripMenuItem.Text = "Amarillo";
            // 
            // CBXCURSOR
            // 
            this.CBXCURSOR.FormattingEnabled = true;
            this.CBXCURSOR.Items.AddRange(new object[] {
            "ARROW",
            "CROS",
            "HELP"});
            this.CBXCURSOR.Location = new System.Drawing.Point(130, 64);
            this.CBXCURSOR.Name = "CBXCURSOR";
            this.CBXCURSOR.Size = new System.Drawing.Size(121, 36);
            this.CBXCURSOR.TabIndex = 1;
            this.CBXCURSOR.SelectedIndexChanged += new System.EventHandler(this.CBXCURSOR_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPCION";
            // 
            // GBXCURSORES
            // 
            this.GBXCURSORES.Controls.Add(this.label1);
            this.GBXCURSORES.Controls.Add(this.CBXCURSOR);
            this.GBXCURSORES.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXCURSORES.Location = new System.Drawing.Point(201, 121);
            this.GBXCURSORES.Name = "GBXCURSORES";
            this.GBXCURSORES.Size = new System.Drawing.Size(269, 160);
            this.GBXCURSORES.TabIndex = 3;
            this.GBXCURSORES.TabStop = false;
            this.GBXCURSORES.Text = "Cursores";
            this.GBXCURSORES.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GBXSONIDO
            // 
            this.GBXSONIDO.Controls.Add(this.BTNEXCLAMACION);
            this.GBXSONIDO.Controls.Add(this.BTNASTERIS);
            this.GBXSONIDO.Controls.Add(this.BTNBEEP);
            this.GBXSONIDO.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXSONIDO.Location = new System.Drawing.Point(130, 290);
            this.GBXSONIDO.Name = "GBXSONIDO";
            this.GBXSONIDO.Size = new System.Drawing.Size(571, 148);
            this.GBXSONIDO.TabIndex = 4;
            this.GBXSONIDO.TabStop = false;
            this.GBXSONIDO.Text = "Sonidos";
            // 
            // BTNEXCLAMACION
            // 
            this.BTNEXCLAMACION.Location = new System.Drawing.Point(362, 68);
            this.BTNEXCLAMACION.Name = "BTNEXCLAMACION";
            this.BTNEXCLAMACION.Size = new System.Drawing.Size(177, 37);
            this.BTNEXCLAMACION.TabIndex = 3;
            this.BTNEXCLAMACION.Text = "EXCLAMACION";
            this.BTNEXCLAMACION.UseVisualStyleBackColor = true;
            this.BTNEXCLAMACION.Click += new System.EventHandler(this.BTNEXCLAMACION_Click);
            // 
            // BTNASTERIS
            // 
            this.BTNASTERIS.Location = new System.Drawing.Point(201, 68);
            this.BTNASTERIS.Name = "BTNASTERIS";
            this.BTNASTERIS.Size = new System.Drawing.Size(121, 37);
            this.BTNASTERIS.TabIndex = 2;
            this.BTNASTERIS.Text = "ASTERIS";
            this.BTNASTERIS.UseVisualStyleBackColor = true;
            this.BTNASTERIS.Click += new System.EventHandler(this.BTNASTERIS_Click);
            // 
            // BTNBEEP
            // 
            this.BTNBEEP.Location = new System.Drawing.Point(16, 68);
            this.BTNBEEP.Name = "BTNBEEP";
            this.BTNBEEP.Size = new System.Drawing.Size(99, 37);
            this.BTNBEEP.TabIndex = 1;
            this.BTNBEEP.Text = "BEEP";
            this.BTNBEEP.UseVisualStyleBackColor = true;
            this.BTNBEEP.Click += new System.EventHandler(this.BTNBEEP_Click);
            // 
            // BTNVENTANA
            // 
            this.BTNVENTANA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVENTANA.Location = new System.Drawing.Point(585, 178);
            this.BTNVENTANA.Name = "BTNVENTANA";
            this.BTNVENTANA.Size = new System.Drawing.Size(141, 60);
            this.BTNVENTANA.TabIndex = 5;
            this.BTNVENTANA.Text = "VENTA AUXILIAR";
            this.BTNVENTANA.UseVisualStyleBackColor = true;
            this.BTNVENTANA.Click += new System.EventHandler(this.BTNVENTANA_Click);
            // 
            // pROYECTOToolStripMenuItem
            // 
            this.pROYECTOToolStripMenuItem.Name = "pROYECTOToolStripMenuItem";
            this.pROYECTOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pROYECTOToolStripMenuItem.Text = "PROYECTO";
            this.pROYECTOToolStripMenuItem.Click += new System.EventHandler(this.pROYECTOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNVENTANA);
            this.Controls.Add(this.GBXSONIDO);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GBXCURSORES);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBXCURSORES.ResumeLayout(false);
            this.GBXCURSORES.PerformLayout();
            this.GBXSONIDO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnsubArcSalir;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBXCURSOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBXCURSORES;
        private System.Windows.Forms.GroupBox GBXSONIDO;
        private System.Windows.Forms.Button BTNEXCLAMACION;
        private System.Windows.Forms.Button BTNASTERIS;
        private System.Windows.Forms.Button BTNBEEP;
        private System.Windows.Forms.Button BTNVENTANA;
        private System.Windows.Forms.ToolStripMenuItem pROYECTOToolStripMenuItem;
    }
}

