namespace WinAppEjercicio20._6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNANADIR = new System.Windows.Forms.ToolStripMenuItem();
            this.MNORDENAR = new System.Windows.Forms.ToolStripMenuItem();
            this.MNOASCENDENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.MNODESCENDENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.MNBUSCAR = new System.Windows.Forms.ToolStripMenuItem();
            this.MNBVALOR = new System.Windows.Forms.ToolStripMenuItem();
            this.MNBMINIMO = new System.Windows.Forms.ToolStripMenuItem();
            this.MNBMAXIMO = new System.Windows.Forms.ToolStripMenuItem();
            this.MNAYUDAR = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBVALORN = new System.Windows.Forms.TextBox();
            this.BTNRESTABLECER = new System.Windows.Forms.Button();
            this.TXTBVALORES = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PNPEDIRN = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LBLVECTOR = new System.Windows.Forms.Label();
            this.PNORDENAR = new System.Windows.Forms.Panel();
            this.GRPBORDENARDES = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.GRPBORDENARAS = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.PNBUSCAR = new System.Windows.Forms.Panel();
            this.GRPBVALORBUSCAR = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.GRPMINIMO = new System.Windows.Forms.GroupBox();
            this.LBLMINIMO = new System.Windows.Forms.Label();
            this.LBLPOSMIN = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GRPMAXIMO = new System.Windows.Forms.GroupBox();
            this.LBLMAXIMO = new System.Windows.Forms.Label();
            this.LBLPOSM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PNPEDIRN.SuspendLayout();
            this.PNORDENAR.SuspendLayout();
            this.GRPBORDENARDES.SuspendLayout();
            this.GRPBORDENARAS.SuspendLayout();
            this.PNBUSCAR.SuspendLayout();
            this.GRPBVALORBUSCAR.SuspendLayout();
            this.GRPMINIMO.SuspendLayout();
            this.GRPMAXIMO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNANADIR,
            this.MNORDENAR,
            this.MNBUSCAR,
            this.MNAYUDAR});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNANADIR
            // 
            this.MNANADIR.Name = "MNANADIR";
            this.MNANADIR.Size = new System.Drawing.Size(67, 24);
            this.MNANADIR.Text = "Añadir";
            this.MNANADIR.Click += new System.EventHandler(this.MNANADIR_Click);
            // 
            // MNORDENAR
            // 
            this.MNORDENAR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNOASCENDENTE,
            this.MNODESCENDENTE});
            this.MNORDENAR.Name = "MNORDENAR";
            this.MNORDENAR.Size = new System.Drawing.Size(77, 24);
            this.MNORDENAR.Text = "Ordenar";
            this.MNORDENAR.Click += new System.EventHandler(this.MNORDENAR_Click);
            // 
            // MNOASCENDENTE
            // 
            this.MNOASCENDENTE.Name = "MNOASCENDENTE";
            this.MNOASCENDENTE.Size = new System.Drawing.Size(178, 26);
            this.MNOASCENDENTE.Text = "Ascendente";
            this.MNOASCENDENTE.Click += new System.EventHandler(this.MNOASCENDENTE_Click);
            // 
            // MNODESCENDENTE
            // 
            this.MNODESCENDENTE.Name = "MNODESCENDENTE";
            this.MNODESCENDENTE.Size = new System.Drawing.Size(178, 26);
            this.MNODESCENDENTE.Text = "Descendente";
            this.MNODESCENDENTE.Click += new System.EventHandler(this.MNODESCENDENTE_Click);
            // 
            // MNBUSCAR
            // 
            this.MNBUSCAR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNBVALOR,
            this.MNBMINIMO,
            this.MNBMAXIMO});
            this.MNBUSCAR.Name = "MNBUSCAR";
            this.MNBUSCAR.Size = new System.Drawing.Size(66, 24);
            this.MNBUSCAR.Text = "Buscar";
            this.MNBUSCAR.Click += new System.EventHandler(this.MNBUSCAR_Click);
            // 
            // MNBVALOR
            // 
            this.MNBVALOR.Name = "MNBVALOR";
            this.MNBVALOR.Size = new System.Drawing.Size(146, 26);
            this.MNBVALOR.Text = "Valor";
            this.MNBVALOR.Click += new System.EventHandler(this.MNBVALOR_Click);
            // 
            // MNBMINIMO
            // 
            this.MNBMINIMO.Name = "MNBMINIMO";
            this.MNBMINIMO.Size = new System.Drawing.Size(146, 26);
            this.MNBMINIMO.Text = "Minimo";
            this.MNBMINIMO.Click += new System.EventHandler(this.MNBMINIMO_Click);
            // 
            // MNBMAXIMO
            // 
            this.MNBMAXIMO.Name = "MNBMAXIMO";
            this.MNBMAXIMO.Size = new System.Drawing.Size(146, 26);
            this.MNBMAXIMO.Text = "Maximo";
            this.MNBMAXIMO.Click += new System.EventHandler(this.MNBMAXIMO_Click);
            // 
            // MNAYUDAR
            // 
            this.MNAYUDAR.Name = "MNAYUDAR";
            this.MNAYUDAR.Size = new System.Drawing.Size(65, 24);
            this.MNAYUDAR.Text = "Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones con Vectores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primero, establezca el tamaño del vector (N).";
            // 
            // TXTBVALORN
            // 
            this.TXTBVALORN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBVALORN.Location = new System.Drawing.Point(31, 93);
            this.TXTBVALORN.Name = "TXTBVALORN";
            this.TXTBVALORN.Size = new System.Drawing.Size(283, 32);
            this.TXTBVALORN.TabIndex = 2;
            this.TXTBVALORN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBVALORN_KeyPress);
            // 
            // BTNRESTABLECER
            // 
            this.BTNRESTABLECER.BackColor = System.Drawing.Color.Black;
            this.BTNRESTABLECER.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRESTABLECER.ForeColor = System.Drawing.Color.White;
            this.BTNRESTABLECER.Location = new System.Drawing.Point(336, 93);
            this.BTNRESTABLECER.Name = "BTNRESTABLECER";
            this.BTNRESTABLECER.Size = new System.Drawing.Size(118, 32);
            this.BTNRESTABLECER.TabIndex = 3;
            this.BTNRESTABLECER.Text = "Establecer";
            this.BTNRESTABLECER.UseVisualStyleBackColor = false;
            this.BTNRESTABLECER.Click += new System.EventHandler(this.BTNRESTABLECER_Click);
            // 
            // TXTBVALORES
            // 
            this.TXTBVALORES.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBVALORES.Location = new System.Drawing.Point(31, 156);
            this.TXTBVALORES.Name = "TXTBVALORES";
            this.TXTBVALORES.Size = new System.Drawing.Size(283, 32);
            this.TXTBVALORES.TabIndex = 4;
            this.TXTBVALORES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBVALORES_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese los valores";
            // 
            // PNPEDIRN
            // 
            this.PNPEDIRN.BackColor = System.Drawing.Color.White;
            this.PNPEDIRN.Controls.Add(this.flowLayoutPanel1);
            this.PNPEDIRN.Controls.Add(this.LBLVECTOR);
            this.PNPEDIRN.Controls.Add(this.label3);
            this.PNPEDIRN.Controls.Add(this.TXTBVALORES);
            this.PNPEDIRN.Controls.Add(this.BTNRESTABLECER);
            this.PNPEDIRN.Controls.Add(this.TXTBVALORN);
            this.PNPEDIRN.Controls.Add(this.label2);
            this.PNPEDIRN.Controls.Add(this.label1);
            this.PNPEDIRN.Location = new System.Drawing.Point(41, 45);
            this.PNPEDIRN.Name = "PNPEDIRN";
            this.PNPEDIRN.Size = new System.Drawing.Size(497, 320);
            this.PNPEDIRN.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 94);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // LBLVECTOR
            // 
            this.LBLVECTOR.AutoSize = true;
            this.LBLVECTOR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLVECTOR.Location = new System.Drawing.Point(18, 194);
            this.LBLVECTOR.Name = "LBLVECTOR";
            this.LBLVECTOR.Size = new System.Drawing.Size(75, 24);
            this.LBLVECTOR.TabIndex = 12;
            this.LBLVECTOR.Text = "Vector: ";
            // 
            // PNORDENAR
            // 
            this.PNORDENAR.BackColor = System.Drawing.Color.White;
            this.PNORDENAR.Controls.Add(this.GRPBORDENARDES);
            this.PNORDENAR.Controls.Add(this.GRPBORDENARAS);
            this.PNORDENAR.Controls.Add(this.label8);
            this.PNORDENAR.Location = new System.Drawing.Point(41, 45);
            this.PNORDENAR.Name = "PNORDENAR";
            this.PNORDENAR.Size = new System.Drawing.Size(497, 320);
            this.PNORDENAR.TabIndex = 14;
            // 
            // GRPBORDENARDES
            // 
            this.GRPBORDENARDES.Controls.Add(this.flowLayoutPanel3);
            this.GRPBORDENARDES.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBORDENARDES.Location = new System.Drawing.Point(19, 173);
            this.GRPBORDENARDES.Name = "GRPBORDENARDES";
            this.GRPBORDENARDES.Size = new System.Drawing.Size(463, 126);
            this.GRPBORDENARDES.TabIndex = 17;
            this.GRPBORDENARDES.TabStop = false;
            this.GRPBORDENARDES.Text = "Ordenado Descendente";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(9, 31);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(436, 71);
            this.flowLayoutPanel3.TabIndex = 15;
            // 
            // GRPBORDENARAS
            // 
            this.GRPBORDENARAS.Controls.Add(this.flowLayoutPanel2);
            this.GRPBORDENARAS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBORDENARAS.Location = new System.Drawing.Point(19, 56);
            this.GRPBORDENARAS.Name = "GRPBORDENARAS";
            this.GRPBORDENARAS.Size = new System.Drawing.Size(463, 100);
            this.GRPBORDENARAS.TabIndex = 16;
            this.GRPBORDENARAS.TabStop = false;
            this.GRPBORDENARAS.Text = "Ordenado Ascendente";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 29);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(445, 65);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ordenar";
            // 
            // PNBUSCAR
            // 
            this.PNBUSCAR.BackColor = System.Drawing.Color.White;
            this.PNBUSCAR.Controls.Add(this.GRPBVALORBUSCAR);
            this.PNBUSCAR.Controls.Add(this.GRPMINIMO);
            this.PNBUSCAR.Controls.Add(this.GRPMAXIMO);
            this.PNBUSCAR.Controls.Add(this.label7);
            this.PNBUSCAR.Location = new System.Drawing.Point(41, 45);
            this.PNBUSCAR.Name = "PNBUSCAR";
            this.PNBUSCAR.Size = new System.Drawing.Size(497, 320);
            this.PNBUSCAR.TabIndex = 16;
            // 
            // GRPBVALORBUSCAR
            // 
            this.GRPBVALORBUSCAR.Controls.Add(this.textBox1);
            this.GRPBVALORBUSCAR.Controls.Add(this.LBLRESUL);
            this.GRPBVALORBUSCAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBVALORBUSCAR.Location = new System.Drawing.Point(19, 50);
            this.GRPBVALORBUSCAR.Name = "GRPBVALORBUSCAR";
            this.GRPBVALORBUSCAR.Size = new System.Drawing.Size(463, 84);
            this.GRPBVALORBUSCAR.TabIndex = 19;
            this.GRPBVALORBUSCAR.TabStop = false;
            this.GRPBVALORBUSCAR.Text = "Valor";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 32);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.Location = new System.Drawing.Point(224, 29);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(0, 24);
            this.LBLRESUL.TabIndex = 17;
            // 
            // GRPMINIMO
            // 
            this.GRPMINIMO.Controls.Add(this.LBLMINIMO);
            this.GRPMINIMO.Controls.Add(this.LBLPOSMIN);
            this.GRPMINIMO.Controls.Add(this.label11);
            this.GRPMINIMO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPMINIMO.Location = new System.Drawing.Point(19, 223);
            this.GRPMINIMO.Name = "GRPMINIMO";
            this.GRPMINIMO.Size = new System.Drawing.Size(463, 84);
            this.GRPMINIMO.TabIndex = 19;
            this.GRPMINIMO.TabStop = false;
            this.GRPMINIMO.Text = "Minimo";
            // 
            // LBLMINIMO
            // 
            this.LBLMINIMO.AutoSize = true;
            this.LBLMINIMO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMINIMO.Location = new System.Drawing.Point(6, 28);
            this.LBLMINIMO.Name = "LBLMINIMO";
            this.LBLMINIMO.Size = new System.Drawing.Size(0, 24);
            this.LBLMINIMO.TabIndex = 2;
            // 
            // LBLPOSMIN
            // 
            this.LBLPOSMIN.AutoSize = true;
            this.LBLPOSMIN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPOSMIN.Location = new System.Drawing.Point(98, 52);
            this.LBLPOSMIN.Name = "LBLPOSMIN";
            this.LBLPOSMIN.Size = new System.Drawing.Size(0, 24);
            this.LBLPOSMIN.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Posicion:";
            // 
            // GRPMAXIMO
            // 
            this.GRPMAXIMO.Controls.Add(this.LBLMAXIMO);
            this.GRPMAXIMO.Controls.Add(this.LBLPOSM);
            this.GRPMAXIMO.Controls.Add(this.label5);
            this.GRPMAXIMO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPMAXIMO.Location = new System.Drawing.Point(19, 133);
            this.GRPMAXIMO.Name = "GRPMAXIMO";
            this.GRPMAXIMO.Size = new System.Drawing.Size(463, 84);
            this.GRPMAXIMO.TabIndex = 18;
            this.GRPMAXIMO.TabStop = false;
            this.GRPMAXIMO.Text = "Maximo";
            // 
            // LBLMAXIMO
            // 
            this.LBLMAXIMO.AutoSize = true;
            this.LBLMAXIMO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMAXIMO.Location = new System.Drawing.Point(6, 28);
            this.LBLMAXIMO.Name = "LBLMAXIMO";
            this.LBLMAXIMO.Size = new System.Drawing.Size(0, 24);
            this.LBLMAXIMO.TabIndex = 2;
            // 
            // LBLPOSM
            // 
            this.LBLPOSM.AutoSize = true;
            this.LBLPOSM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPOSM.Location = new System.Drawing.Point(98, 52);
            this.LBLPOSM.Name = "LBLPOSM";
            this.LBLPOSM.Size = new System.Drawing.Size(0, 24);
            this.LBLPOSM.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Posicion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(591, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PNPEDIRN);
            this.Controls.Add(this.PNBUSCAR);
            this.Controls.Add(this.PNORDENAR);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ejercicio 20";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PNPEDIRN.ResumeLayout(false);
            this.PNPEDIRN.PerformLayout();
            this.PNORDENAR.ResumeLayout(false);
            this.PNORDENAR.PerformLayout();
            this.GRPBORDENARDES.ResumeLayout(false);
            this.GRPBORDENARAS.ResumeLayout(false);
            this.PNBUSCAR.ResumeLayout(false);
            this.PNBUSCAR.PerformLayout();
            this.GRPBVALORBUSCAR.ResumeLayout(false);
            this.GRPBVALORBUSCAR.PerformLayout();
            this.GRPMINIMO.ResumeLayout(false);
            this.GRPMINIMO.PerformLayout();
            this.GRPMAXIMO.ResumeLayout(false);
            this.GRPMAXIMO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNANADIR;
        private System.Windows.Forms.ToolStripMenuItem MNORDENAR;
        private System.Windows.Forms.ToolStripMenuItem MNOASCENDENTE;
        private System.Windows.Forms.ToolStripMenuItem MNODESCENDENTE;
        private System.Windows.Forms.ToolStripMenuItem MNBUSCAR;
        private System.Windows.Forms.ToolStripMenuItem MNBVALOR;
        private System.Windows.Forms.ToolStripMenuItem MNBMINIMO;
        private System.Windows.Forms.ToolStripMenuItem MNBMAXIMO;
        private System.Windows.Forms.ToolStripMenuItem MNAYUDAR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBVALORN;
        private System.Windows.Forms.Button BTNRESTABLECER;
        private System.Windows.Forms.TextBox TXTBVALORES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PNPEDIRN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LBLVECTOR;
        private System.Windows.Forms.Panel PNORDENAR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel PNBUSCAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.GroupBox GRPMAXIMO;
        private System.Windows.Forms.Label LBLPOSM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLMAXIMO;
        private System.Windows.Forms.GroupBox GRPMINIMO;
        private System.Windows.Forms.Label LBLMINIMO;
        private System.Windows.Forms.Label LBLPOSMIN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GRPBVALORBUSCAR;
        private System.Windows.Forms.GroupBox GRPBORDENARDES;
        private System.Windows.Forms.GroupBox GRPBORDENARAS;
    }
}

