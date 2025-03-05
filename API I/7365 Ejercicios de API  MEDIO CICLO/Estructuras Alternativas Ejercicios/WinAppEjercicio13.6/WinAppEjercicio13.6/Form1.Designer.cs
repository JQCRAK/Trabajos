namespace WinAppEjercicio13._6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTB1 = new System.Windows.Forms.TextBox();
            this.TXTB2 = new System.Windows.Forms.TextBox();
            this.TXTB3 = new System.Windows.Forms.TextBox();
            this.TXTB4 = new System.Windows.Forms.TextBox();
            this.BTNINICIAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Ruleta Mágica!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario 1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario 2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario 3: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario 4: ";
            // 
            // TXTB1
            // 
            this.TXTB1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB1.Location = new System.Drawing.Point(119, 81);
            this.TXTB1.Name = "TXTB1";
            this.TXTB1.Size = new System.Drawing.Size(240, 32);
            this.TXTB1.TabIndex = 1;
            this.TXTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB1_KeyPress);
            // 
            // TXTB2
            // 
            this.TXTB2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB2.Location = new System.Drawing.Point(119, 119);
            this.TXTB2.Name = "TXTB2";
            this.TXTB2.Size = new System.Drawing.Size(240, 32);
            this.TXTB2.TabIndex = 2;
            this.TXTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB2_KeyPress);
            // 
            // TXTB3
            // 
            this.TXTB3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB3.Location = new System.Drawing.Point(119, 157);
            this.TXTB3.Name = "TXTB3";
            this.TXTB3.Size = new System.Drawing.Size(240, 32);
            this.TXTB3.TabIndex = 3;
            this.TXTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB3_KeyPress);
            // 
            // TXTB4
            // 
            this.TXTB4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB4.Location = new System.Drawing.Point(119, 195);
            this.TXTB4.Name = "TXTB4";
            this.TXTB4.Size = new System.Drawing.Size(240, 32);
            this.TXTB4.TabIndex = 4;
            this.TXTB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB4_KeyPress);
            // 
            // BTNINICIAR
            // 
            this.BTNINICIAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BTNINICIAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNINICIAR.BackColor = System.Drawing.Color.Yellow;
            this.BTNINICIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNINICIAR.BorderRadius = 0;
            this.BTNINICIAR.ButtonText = "  ¡Iniciar la Aventura!";
            this.BTNINICIAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNINICIAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNINICIAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNINICIAR.Iconimage = null;
            this.BTNINICIAR.Iconimage_right = null;
            this.BTNINICIAR.Iconimage_right_Selected = null;
            this.BTNINICIAR.Iconimage_Selected = null;
            this.BTNINICIAR.IconMarginLeft = 0;
            this.BTNINICIAR.IconMarginRight = 0;
            this.BTNINICIAR.IconRightVisible = true;
            this.BTNINICIAR.IconRightZoom = 0D;
            this.BTNINICIAR.IconVisible = true;
            this.BTNINICIAR.IconZoom = 90D;
            this.BTNINICIAR.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.BTNINICIAR.IsTab = false;
            this.BTNINICIAR.Location = new System.Drawing.Point(94, 248);
            this.BTNINICIAR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BTNINICIAR.Name = "BTNINICIAR";
            this.BTNINICIAR.Normalcolor = System.Drawing.Color.Yellow;
            this.BTNINICIAR.OnHovercolor = System.Drawing.Color.Gold;
            this.BTNINICIAR.OnHoverTextColor = System.Drawing.Color.Black;
            this.BTNINICIAR.selected = false;
            this.BTNINICIAR.Size = new System.Drawing.Size(210, 45);
            this.BTNINICIAR.TabIndex = 11;
            this.BTNINICIAR.Text = "  ¡Iniciar la Aventura!";
            this.BTNINICIAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNINICIAR.Textcolor = System.Drawing.Color.Black;
            this.BTNINICIAR.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINICIAR.Click += new System.EventHandler(this.BTNINICIAR_Click);
            this.BTNINICIAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNINICIAR_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(382, 324);
            this.Controls.Add(this.BTNINICIAR);
            this.Controls.Add(this.TXTB4);
            this.Controls.Add(this.TXTB3);
            this.Controls.Add(this.TXTB2);
            this.Controls.Add(this.TXTB1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTB1;
        private System.Windows.Forms.TextBox TXTB2;
        private System.Windows.Forms.TextBox TXTB3;
        private System.Windows.Forms.TextBox TXTB4;
        private Bunifu.Framework.UI.BunifuFlatButton BTNINICIAR;
    }
}

