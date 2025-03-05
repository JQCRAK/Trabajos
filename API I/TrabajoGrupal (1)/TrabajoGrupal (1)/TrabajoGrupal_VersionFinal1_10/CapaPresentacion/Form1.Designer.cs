namespace CapaPresentacion
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suministroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piezaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TXTBNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNCONOCER = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.insertarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem,
            this.reporte2ToolStripMenuItem,
            this.reporte3ToolStripMenuItem,
            this.reporte4ToolStripMenuItem,
            this.reporte5ToolStripMenuItem,
            this.reporte6ToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.inicioToolStripMenuItem.Text = "Reportes";
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reporte1ToolStripMenuItem.Text = "Proveedores";
            this.reporte1ToolStripMenuItem.Click += new System.EventHandler(this.reporte1ToolStripMenuItem_Click);
            // 
            // reporte2ToolStripMenuItem
            // 
            this.reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            this.reporte2ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reporte2ToolStripMenuItem.Text = "Categoria";
            this.reporte2ToolStripMenuItem.Click += new System.EventHandler(this.reporte2ToolStripMenuItem_Click);
            // 
            // reporte3ToolStripMenuItem
            // 
            this.reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            this.reporte3ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reporte3ToolStripMenuItem.Text = "Pieza";
            this.reporte3ToolStripMenuItem.Click += new System.EventHandler(this.reporte3ToolStripMenuItem_Click);
            // 
            // reporte4ToolStripMenuItem
            // 
            this.reporte4ToolStripMenuItem.Name = "reporte4ToolStripMenuItem";
            this.reporte4ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reporte4ToolStripMenuItem.Text = "Suministros";
            this.reporte4ToolStripMenuItem.Click += new System.EventHandler(this.reporte4ToolStripMenuItem_Click);
            // 
            // reporte5ToolStripMenuItem
            // 
            this.reporte5ToolStripMenuItem.Name = "reporte5ToolStripMenuItem";
            this.reporte5ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reporte5ToolStripMenuItem.Text = "Total por Categorias";
            this.reporte5ToolStripMenuItem.Click += new System.EventHandler(this.reporte5ToolStripMenuItem_Click);
            // 
            // reporte6ToolStripMenuItem
            // 
            this.reporte6ToolStripMenuItem.Name = "reporte6ToolStripMenuItem";
            this.reporte6ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reporte6ToolStripMenuItem.Text = "Total de Suministros";
            this.reporte6ToolStripMenuItem.Click += new System.EventHandler(this.reporte6ToolStripMenuItem_Click);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provedorToolStripMenuItem,
            this.piezaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.suministroToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // provedorToolStripMenuItem
            // 
            this.provedorToolStripMenuItem.Name = "provedorToolStripMenuItem";
            this.provedorToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.provedorToolStripMenuItem.Text = "Provedor";
            this.provedorToolStripMenuItem.Click += new System.EventHandler(this.provedorToolStripMenuItem_Click);
            // 
            // piezaToolStripMenuItem
            // 
            this.piezaToolStripMenuItem.Name = "piezaToolStripMenuItem";
            this.piezaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.piezaToolStripMenuItem.Text = "Pieza";
            this.piezaToolStripMenuItem.Click += new System.EventHandler(this.piezaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // suministroToolStripMenuItem
            // 
            this.suministroToolStripMenuItem.Name = "suministroToolStripMenuItem";
            this.suministroToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.suministroToolStripMenuItem.Text = "Suministro";
            this.suministroToolStripMenuItem.Click += new System.EventHandler(this.suministroToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.piezaToolStripMenuItem1});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // piezaToolStripMenuItem1
            // 
            this.piezaToolStripMenuItem1.Name = "piezaToolStripMenuItem1";
            this.piezaToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.piezaToolStripMenuItem1.Text = "Pieza";
            this.piezaToolStripMenuItem1.Click += new System.EventHandler(this.piezaToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provedoresToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // provedoresToolStripMenuItem
            // 
            this.provedoresToolStripMenuItem.Name = "provedoresToolStripMenuItem";
            this.provedoresToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.provedoresToolStripMenuItem.Text = "Proveedor";
            this.provedoresToolStripMenuItem.Click += new System.EventHandler(this.provedoresToolStripMenuItem_Click);
            // 
            // TXTBNOMBRE
            // 
            this.TXTBNOMBRE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBNOMBRE.Location = new System.Drawing.Point(115, 116);
            this.TXTBNOMBRE.Name = "TXTBNOMBRE";
            this.TXTBNOMBRE.Size = new System.Drawing.Size(412, 32);
            this.TXTBNOMBRE.TabIndex = 10;
            this.TXTBNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBNOMBRE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proveedor";
            // 
            // BTNCONOCER
            // 
            this.BTNCONOCER.BackColor = System.Drawing.Color.MidnightBlue;
            this.BTNCONOCER.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONOCER.ForeColor = System.Drawing.Color.White;
            this.BTNCONOCER.Location = new System.Drawing.Point(744, 114);
            this.BTNCONOCER.Name = "BTNCONOCER";
            this.BTNCONOCER.Size = new System.Drawing.Size(207, 34);
            this.BTNCONOCER.TabIndex = 7;
            this.BTNCONOCER.Text = "Conocer al Proveedor";
            this.BTNCONOCER.UseVisualStyleBackColor = false;
            this.BTNCONOCER.Click += new System.EventHandler(this.BTNCONOCER_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 183);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(979, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTBNOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNCONOCER);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suministroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TextBox TXTBNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCONOCER;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem piezaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provedoresToolStripMenuItem;
    }
}

