namespace WinAppEjercicio15._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBN = new System.Windows.Forms.TextBox();
            this.BTNGENERAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNRESUL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PNRESUL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(113, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador de Fibonacci";
            // 
            // TXTBN
            // 
            this.TXTBN.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBN.Location = new System.Drawing.Point(14, 61);
            this.TXTBN.Name = "TXTBN";
            this.TXTBN.Size = new System.Drawing.Size(265, 38);
            this.TXTBN.TabIndex = 1;
            this.TXTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBN_KeyPress);
            // 
            // BTNGENERAR
            // 
            this.BTNGENERAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNGENERAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNGENERAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNGENERAR.BorderRadius = 0;
            this.BTNGENERAR.ButtonText = "Generar";
            this.BTNGENERAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGENERAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNGENERAR.Font = new System.Drawing.Font("Microsoft YaHei", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGENERAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNGENERAR.Iconimage = null;
            this.BTNGENERAR.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("BTNGENERAR.Iconimage_right")));
            this.BTNGENERAR.Iconimage_right_Selected = null;
            this.BTNGENERAR.Iconimage_Selected = null;
            this.BTNGENERAR.IconMarginLeft = 0;
            this.BTNGENERAR.IconMarginRight = 0;
            this.BTNGENERAR.IconRightVisible = true;
            this.BTNGENERAR.IconRightZoom = 0D;
            this.BTNGENERAR.IconVisible = true;
            this.BTNGENERAR.IconZoom = 90D;
            this.BTNGENERAR.IsTab = false;
            this.BTNGENERAR.Location = new System.Drawing.Point(329, 61);
            this.BTNGENERAR.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNGENERAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BTNGENERAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNGENERAR.selected = false;
            this.BTNGENERAR.Size = new System.Drawing.Size(146, 40);
            this.BTNGENERAR.TabIndex = 2;
            this.BTNGENERAR.Text = "Generar";
            this.BTNGENERAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGENERAR.Textcolor = System.Drawing.Color.White;
            this.BTNGENERAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGENERAR.Click += new System.EventHandler(this.BTNGENERAR_Click);
            this.BTNGENERAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNGENERAR_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PNRESUL);
            this.panel1.Controls.Add(this.BTNGENERAR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXTBN);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 208);
            this.panel1.TabIndex = 3;
            // 
            // PNRESUL
            // 
            this.PNRESUL.BackColor = System.Drawing.Color.MidnightBlue;
            this.PNRESUL.Controls.Add(this.pictureBox1);
            this.PNRESUL.Controls.Add(this.LBLRESUL);
            this.PNRESUL.Controls.Add(this.label2);
            this.PNRESUL.Location = new System.Drawing.Point(14, 113);
            this.PNRESUL.Name = "PNRESUL";
            this.PNRESUL.Size = new System.Drawing.Size(464, 76);
            this.PNRESUL.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.ForeColor = System.Drawing.Color.White;
            this.LBLRESUL.Location = new System.Drawing.Point(5, 41);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(20, 24);
            this.LBLRESUL.TabIndex = 1;
            this.LBLRESUL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "La serie de Fibonacci es";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(520, 265);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Ejercicio 15";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNRESUL.ResumeLayout(false);
            this.PNRESUL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBN;
        private Bunifu.Framework.UI.BunifuFlatButton BTNGENERAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PNRESUL;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

