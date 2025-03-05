namespace WinAppEjercicio16._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pulgadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Centimetros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBN = new System.Windows.Forms.TextBox();
            this.BTNBUSCAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pulgadas,
            this.Centimetros});
            this.dataGridView1.Location = new System.Drawing.Point(25, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 343);
            this.dataGridView1.TabIndex = 5;
            // 
            // Pulgadas
            // 
            this.Pulgadas.HeaderText = "Pulgadas";
            this.Pulgadas.MinimumWidth = 6;
            this.Pulgadas.Name = "Pulgadas";
            // 
            // Centimetros
            // 
            this.Centimetros.HeaderText = "Centímetros";
            this.Centimetros.MinimumWidth = 6;
            this.Centimetros.Name = "Centimetros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla de Conversión de Tallas";
            // 
            // TXTBN
            // 
            this.TXTBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBN.Location = new System.Drawing.Point(25, 70);
            this.TXTBN.Name = "TXTBN";
            this.TXTBN.Size = new System.Drawing.Size(291, 32);
            this.TXTBN.TabIndex = 1;
            this.TXTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBN_KeyPress);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Activecolor = System.Drawing.Color.Black;
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNBUSCAR.BorderRadius = 0;
            this.BTNBUSCAR.ButtonText = "       Buscar";
            this.BTNBUSCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBUSCAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Calibri", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNBUSCAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNBUSCAR.Iconimage")));
            this.BTNBUSCAR.Iconimage_right = null;
            this.BTNBUSCAR.Iconimage_right_Selected = null;
            this.BTNBUSCAR.Iconimage_Selected = null;
            this.BTNBUSCAR.IconMarginLeft = 0;
            this.BTNBUSCAR.IconMarginRight = 0;
            this.BTNBUSCAR.IconRightVisible = true;
            this.BTNBUSCAR.IconRightZoom = 0D;
            this.BTNBUSCAR.IconVisible = true;
            this.BTNBUSCAR.IconZoom = 90D;
            this.BTNBUSCAR.IsTab = false;
            this.BTNBUSCAR.Location = new System.Drawing.Point(342, 70);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Normalcolor = System.Drawing.Color.Black;
            this.BTNBUSCAR.OnHovercolor = System.Drawing.Color.Black;
            this.BTNBUSCAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNBUSCAR.selected = false;
            this.BTNBUSCAR.Size = new System.Drawing.Size(150, 32);
            this.BTNBUSCAR.TabIndex = 3;
            this.BTNBUSCAR.Text = "       Buscar";
            this.BTNBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBUSCAR.Textcolor = System.Drawing.Color.White;
            this.BTNBUSCAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            this.BTNBUSCAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNBUSCAR_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(533, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.TXTBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBN;
        private Bunifu.Framework.UI.BunifuFlatButton BTNBUSCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulgadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centimetros;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}