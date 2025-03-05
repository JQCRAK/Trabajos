namespace CapaPresentacion
{
    partial class FRMCATEGORIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCATEGORIA));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBNOMBRECATEGORIA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTBPRECIO = new System.Windows.Forms.TextBox();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre de la Categoría";
            // 
            // TXTBNOMBRECATEGORIA
            // 
            this.TXTBNOMBRECATEGORIA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBNOMBRECATEGORIA.Location = new System.Drawing.Point(42, 90);
            this.TXTBNOMBRECATEGORIA.Name = "TXTBNOMBRECATEGORIA";
            this.TXTBNOMBRECATEGORIA.Size = new System.Drawing.Size(380, 32);
            this.TXTBNOMBRECATEGORIA.TabIndex = 38;
            this.TXTBNOMBRECATEGORIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBNOMBRECATEGORIA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nueva Categoría";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(42, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Precio";
            // 
            // TXTBPRECIO
            // 
            this.TXTBPRECIO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBPRECIO.Location = new System.Drawing.Point(42, 173);
            this.TXTBPRECIO.Name = "TXTBPRECIO";
            this.TXTBPRECIO.Size = new System.Drawing.Size(380, 32);
            this.TXTBPRECIO.TabIndex = 42;
            this.TXTBPRECIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBPRECIO_KeyPress);
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.BackColor = System.Drawing.Color.Indigo;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.ForeColor = System.Drawing.Color.White;
            this.BTNCANCELAR.Location = new System.Drawing.Point(243, 239);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(179, 34);
            this.BTNCANCELAR.TabIndex = 46;
            this.BTNCANCELAR.Text = "Cancelar";
            this.BTNCANCELAR.UseVisualStyleBackColor = false;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.Indigo;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.White;
            this.BTNGUARDAR.Location = new System.Drawing.Point(42, 239);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(179, 34);
            this.BTNGUARDAR.TabIndex = 45;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // FRMCATEGORIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(465, 317);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTBPRECIO);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTBNOMBRECATEGORIA);
            this.Controls.Add(this.label1);
            this.Name = "FRMCATEGORIA";
            this.Text = "FRMCATEGORIA";
            this.Load += new System.EventHandler(this.FRMCATEGORIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBNOMBRECATEGORIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTBPRECIO;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNGUARDAR;
    }
}