namespace WindowsAppPractica2
{
    partial class FRMFELIZ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBTITULO = new System.Windows.Forms.Label();
            this.PCTIMAGEN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCTIMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // LBTITULO
            // 
            this.LBTITULO.AutoSize = true;
            this.LBTITULO.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTITULO.Location = new System.Drawing.Point(327, 76);
            this.LBTITULO.Name = "LBTITULO";
            this.LBTITULO.Size = new System.Drawing.Size(177, 28);
            this.LBTITULO.TabIndex = 0;
            this.LBTITULO.Text = "NUEVA VENTANA";
            // 
            // PCTIMAGEN
            // 
            this.PCTIMAGEN.BackgroundImage = global::WindowsAppPractica2.Properties.Resources.TRUSTME;
            this.PCTIMAGEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCTIMAGEN.Location = new System.Drawing.Point(191, 124);
            this.PCTIMAGEN.Name = "PCTIMAGEN";
            this.PCTIMAGEN.Size = new System.Drawing.Size(436, 277);
            this.PCTIMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCTIMAGEN.TabIndex = 1;
            this.PCTIMAGEN.TabStop = false;
            // 
            // FRMFELIZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCTIMAGEN);
            this.Controls.Add(this.LBTITULO);
            this.Name = "FRMFELIZ";
            this.Text = "FRMFELIZ";
            ((System.ComponentModel.ISupportInitialize)(this.PCTIMAGEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTITULO;
        private System.Windows.Forms.PictureBox PCTIMAGEN;
    }
}