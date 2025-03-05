namespace WinAppEjercicio24._3
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBTRANSCRITO = new System.Windows.Forms.TextBox();
            this.BTNREINICAR = new System.Windows.Forms.Button();
            this.BTNCOMENZAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNDETENER = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voz a Texto";
            // 
            // TXTBTRANSCRITO
            // 
            this.TXTBTRANSCRITO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTRANSCRITO.Location = new System.Drawing.Point(12, 157);
            this.TXTBTRANSCRITO.Multiline = true;
            this.TXTBTRANSCRITO.Name = "TXTBTRANSCRITO";
            this.TXTBTRANSCRITO.ReadOnly = true;
            this.TXTBTRANSCRITO.Size = new System.Drawing.Size(483, 263);
            this.TXTBTRANSCRITO.TabIndex = 2;
            this.TXTBTRANSCRITO.Text = "El texto transcrito aparecerá aquí...";
            // 
            // BTNREINICAR
            // 
            this.BTNREINICAR.BackColor = System.Drawing.Color.Blue;
            this.BTNREINICAR.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREINICAR.ForeColor = System.Drawing.Color.White;
            this.BTNREINICAR.Location = new System.Drawing.Point(39, 426);
            this.BTNREINICAR.Name = "BTNREINICAR";
            this.BTNREINICAR.Size = new System.Drawing.Size(425, 42);
            this.BTNREINICAR.TabIndex = 5;
            this.BTNREINICAR.Text = "Reiniciar Texto";
            this.BTNREINICAR.UseVisualStyleBackColor = false;
            this.BTNREINICAR.Click += new System.EventHandler(this.BTNREINICAR_Click);
            // 
            // BTNCOMENZAR
            // 
            this.BTNCOMENZAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNCOMENZAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNCOMENZAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNCOMENZAR.BorderRadius = 0;
            this.BTNCOMENZAR.ButtonText = "         Comenzar";
            this.BTNCOMENZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCOMENZAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNCOMENZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCOMENZAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNCOMENZAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNCOMENZAR.Iconimage")));
            this.BTNCOMENZAR.Iconimage_right = null;
            this.BTNCOMENZAR.Iconimage_right_Selected = null;
            this.BTNCOMENZAR.Iconimage_Selected = null;
            this.BTNCOMENZAR.IconMarginLeft = 0;
            this.BTNCOMENZAR.IconMarginRight = 0;
            this.BTNCOMENZAR.IconRightVisible = true;
            this.BTNCOMENZAR.IconRightZoom = 0D;
            this.BTNCOMENZAR.IconVisible = true;
            this.BTNCOMENZAR.IconZoom = 90D;
            this.BTNCOMENZAR.IsTab = false;
            this.BTNCOMENZAR.Location = new System.Drawing.Point(39, 91);
            this.BTNCOMENZAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCOMENZAR.Name = "BTNCOMENZAR";
            this.BTNCOMENZAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNCOMENZAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BTNCOMENZAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNCOMENZAR.selected = false;
            this.BTNCOMENZAR.Size = new System.Drawing.Size(181, 39);
            this.BTNCOMENZAR.TabIndex = 6;
            this.BTNCOMENZAR.Text = "         Comenzar";
            this.BTNCOMENZAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCOMENZAR.Textcolor = System.Drawing.Color.White;
            this.BTNCOMENZAR.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCOMENZAR.Click += new System.EventHandler(this.BTNCOMENZAR_Click);
            // 
            // BTNDETENER
            // 
            this.BTNDETENER.Activecolor = System.Drawing.Color.Red;
            this.BTNDETENER.BackColor = System.Drawing.Color.Red;
            this.BTNDETENER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNDETENER.BorderRadius = 0;
            this.BTNDETENER.ButtonText = "          Detener";
            this.BTNDETENER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDETENER.DisabledColor = System.Drawing.Color.Gray;
            this.BTNDETENER.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDETENER.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNDETENER.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNDETENER.Iconimage")));
            this.BTNDETENER.Iconimage_right = null;
            this.BTNDETENER.Iconimage_right_Selected = null;
            this.BTNDETENER.Iconimage_Selected = null;
            this.BTNDETENER.IconMarginLeft = 0;
            this.BTNDETENER.IconMarginRight = 0;
            this.BTNDETENER.IconRightVisible = true;
            this.BTNDETENER.IconRightZoom = 0D;
            this.BTNDETENER.IconVisible = true;
            this.BTNDETENER.IconZoom = 90D;
            this.BTNDETENER.IsTab = false;
            this.BTNDETENER.Location = new System.Drawing.Point(310, 91);
            this.BTNDETENER.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDETENER.Name = "BTNDETENER";
            this.BTNDETENER.Normalcolor = System.Drawing.Color.Red;
            this.BTNDETENER.OnHovercolor = System.Drawing.Color.Red;
            this.BTNDETENER.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNDETENER.selected = false;
            this.BTNDETENER.Size = new System.Drawing.Size(168, 39);
            this.BTNDETENER.TabIndex = 7;
            this.BTNDETENER.Text = "          Detener";
            this.BTNDETENER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDETENER.Textcolor = System.Drawing.Color.White;
            this.BTNDETENER.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDETENER.Click += new System.EventHandler(this.BTNDETENER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 471);
            this.Controls.Add(this.BTNDETENER);
            this.Controls.Add(this.BTNCOMENZAR);
            this.Controls.Add(this.BTNREINICAR);
            this.Controls.Add(this.TXTBTRANSCRITO);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 24";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBTRANSCRITO;
        private System.Windows.Forms.Button BTNREINICAR;
        private Bunifu.Framework.UI.BunifuFlatButton BTNCOMENZAR;
        private Bunifu.Framework.UI.BunifuFlatButton BTNDETENER;
    }
}

