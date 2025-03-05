namespace WinAppEjercicio19._5
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.GPBRESULTADOS = new System.Windows.Forms.GroupBox();
            this.LBLSTI = new System.Windows.Forms.Label();
            this.LBLMDP = new System.Windows.Forms.Label();
            this.LBLMTS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GPBRESULTADOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Matriz Cuadrática";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño de la Matriz Cuadratica";
            // 
            // TXTBN
            // 
            this.TXTBN.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBN.Location = new System.Drawing.Point(296, 71);
            this.TXTBN.Name = "TXTBN";
            this.TXTBN.Size = new System.Drawing.Size(89, 28);
            this.TXTBN.TabIndex = 2;
            this.TXTBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTBN_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 191);
            this.dataGridView1.TabIndex = 3;
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Green;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(61, 314);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(499, 36);
            this.BTNCALCULAR.TabIndex = 4;
            this.BTNCALCULAR.Text = "Calcular";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // GPBRESULTADOS
            // 
            this.GPBRESULTADOS.BackColor = System.Drawing.Color.LavenderBlush;
            this.GPBRESULTADOS.Controls.Add(this.LBLSTI);
            this.GPBRESULTADOS.Controls.Add(this.LBLMDP);
            this.GPBRESULTADOS.Controls.Add(this.LBLMTS);
            this.GPBRESULTADOS.Controls.Add(this.label5);
            this.GPBRESULTADOS.Controls.Add(this.label4);
            this.GPBRESULTADOS.Controls.Add(this.label3);
            this.GPBRESULTADOS.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBRESULTADOS.Location = new System.Drawing.Point(25, 374);
            this.GPBRESULTADOS.Name = "GPBRESULTADOS";
            this.GPBRESULTADOS.Size = new System.Drawing.Size(584, 125);
            this.GPBRESULTADOS.TabIndex = 5;
            this.GPBRESULTADOS.TabStop = false;
            this.GPBRESULTADOS.Text = "Resultados:";
            // 
            // LBLSTI
            // 
            this.LBLSTI.AutoSize = true;
            this.LBLSTI.Location = new System.Drawing.Point(451, 85);
            this.LBLSTI.Name = "LBLSTI";
            this.LBLSTI.Size = new System.Drawing.Size(20, 23);
            this.LBLSTI.TabIndex = 5;
            this.LBLSTI.Text = "0";
            // 
            // LBLMDP
            // 
            this.LBLMDP.AutoSize = true;
            this.LBLMDP.Location = new System.Drawing.Point(382, 57);
            this.LBLMDP.Name = "LBLMDP";
            this.LBLMDP.Size = new System.Drawing.Size(20, 23);
            this.LBLMDP.TabIndex = 4;
            this.LBLMDP.Text = "0";
            // 
            // LBLMTS
            // 
            this.LBLMTS.AutoSize = true;
            this.LBLMTS.Location = new System.Drawing.Point(366, 30);
            this.LBLMTS.Name = "LBLMTS";
            this.LBLMTS.Size = new System.Drawing.Size(20, 23);
            this.LBLMTS.TabIndex = 3;
            this.LBLMTS.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Suma total de los elementos del triángulo inferior: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Menor elemento de la diagonal principal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mayor elemento del triángulo superior: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GPBRESULTADOS);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GPBRESULTADOS.ResumeLayout(false);
            this.GPBRESULTADOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.GroupBox GPBRESULTADOS;
        private System.Windows.Forms.Label LBLSTI;
        private System.Windows.Forms.Label LBLMDP;
        private System.Windows.Forms.Label LBLMTS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

