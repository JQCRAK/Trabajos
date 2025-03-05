namespace WindowsAppPractica2
{
    partial class Form2
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
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.PCTBOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCTBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(271, 64);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(237, 35);
            this.LBLTITULO.TabIndex = 0;
            this.LBLTITULO.Text = "NUEVA VENTANA 2";
            // 
            // PCTBOX
            // 
            this.PCTBOX.BackgroundImage = global::WindowsAppPractica2.Properties.Resources.SCRABDOODLE;
            this.PCTBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCTBOX.Location = new System.Drawing.Point(180, 102);
            this.PCTBOX.Name = "PCTBOX";
            this.PCTBOX.Size = new System.Drawing.Size(442, 285);
            this.PCTBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCTBOX.TabIndex = 1;
            this.PCTBOX.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCTBOX);
            this.Controls.Add(this.LBLTITULO);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PCTBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.PictureBox PCTBOX;
    }
}