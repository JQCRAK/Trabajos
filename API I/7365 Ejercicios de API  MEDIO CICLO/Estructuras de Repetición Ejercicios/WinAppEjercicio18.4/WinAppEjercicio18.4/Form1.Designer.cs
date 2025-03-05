namespace WinAppEjercicio18._4
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
            this.label3 = new System.Windows.Forms.Label();
            this.TXTBFILA = new System.Windows.Forms.TextBox();
            this.TXTBCOLUMNA = new System.Windows.Forms.TextBox();
            this.BTNCREARM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNCALCULARM = new System.Windows.Forms.Button();
            this.GPBRESULTADOS = new System.Windows.Forms.GroupBox();
            this.LBLMLTIPLICACIONN = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LBLSCPARES = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBLSUMATOTAL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBLEPOSITIVO = new System.Windows.Forms.Label();
            this.LBLENEGATIVOS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GPBRESULTADOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizador de Matriz Mágico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columnas:";
            // 
            // TXTBFILA
            // 
            this.TXTBFILA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBFILA.Location = new System.Drawing.Point(180, 129);
            this.TXTBFILA.Name = "TXTBFILA";
            this.TXTBFILA.Size = new System.Drawing.Size(81, 32);
            this.TXTBFILA.TabIndex = 3;
            this.TXTBFILA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBFILA_KeyPress);
            // 
            // TXTBCOLUMNA
            // 
            this.TXTBCOLUMNA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBCOLUMNA.Location = new System.Drawing.Point(295, 129);
            this.TXTBCOLUMNA.Name = "TXTBCOLUMNA";
            this.TXTBCOLUMNA.Size = new System.Drawing.Size(81, 32);
            this.TXTBCOLUMNA.TabIndex = 4;
            this.TXTBCOLUMNA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBCOLUMNA_KeyPress);
            // 
            // BTNCREARM
            // 
            this.BTNCREARM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNCREARM.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCREARM.ForeColor = System.Drawing.Color.White;
            this.BTNCREARM.Location = new System.Drawing.Point(431, 104);
            this.BTNCREARM.Name = "BTNCREARM";
            this.BTNCREARM.Size = new System.Drawing.Size(125, 44);
            this.BTNCREARM.TabIndex = 5;
            this.BTNCREARM.Text = "Crear Matriz";
            this.BTNCREARM.UseVisualStyleBackColor = false;
            this.BTNCREARM.Click += new System.EventHandler(this.BTNCREARM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matriz:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 185);
            this.dataGridView1.TabIndex = 7;
            // 
            // BTNCALCULARM
            // 
            this.BTNCALCULARM.BackColor = System.Drawing.Color.BlueViolet;
            this.BTNCALCULARM.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULARM.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULARM.Location = new System.Drawing.Point(91, 389);
            this.BTNCALCULARM.Name = "BTNCALCULARM";
            this.BTNCALCULARM.Size = new System.Drawing.Size(441, 44);
            this.BTNCALCULARM.TabIndex = 8;
            this.BTNCALCULARM.Text = "¡Analizar Matriz!";
            this.BTNCALCULARM.UseVisualStyleBackColor = false;
            this.BTNCALCULARM.Click += new System.EventHandler(this.BTNCALCULARM_Click);
            // 
            // GPBRESULTADOS
            // 
            this.GPBRESULTADOS.BackColor = System.Drawing.Color.White;
            this.GPBRESULTADOS.Controls.Add(this.LBLMLTIPLICACIONN);
            this.GPBRESULTADOS.Controls.Add(this.label12);
            this.GPBRESULTADOS.Controls.Add(this.LBLSCPARES);
            this.GPBRESULTADOS.Controls.Add(this.label10);
            this.GPBRESULTADOS.Controls.Add(this.LBLSUMATOTAL);
            this.GPBRESULTADOS.Controls.Add(this.label7);
            this.GPBRESULTADOS.Controls.Add(this.LBLEPOSITIVO);
            this.GPBRESULTADOS.Controls.Add(this.LBLENEGATIVOS);
            this.GPBRESULTADOS.Controls.Add(this.label6);
            this.GPBRESULTADOS.Controls.Add(this.label5);
            this.GPBRESULTADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBRESULTADOS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GPBRESULTADOS.Location = new System.Drawing.Point(12, 448);
            this.GPBRESULTADOS.Name = "GPBRESULTADOS";
            this.GPBRESULTADOS.Size = new System.Drawing.Size(619, 137);
            this.GPBRESULTADOS.TabIndex = 10;
            this.GPBRESULTADOS.TabStop = false;
            this.GPBRESULTADOS.Text = "Resultados";
            // 
            // LBLMLTIPLICACIONN
            // 
            this.LBLMLTIPLICACIONN.AutoSize = true;
            this.LBLMLTIPLICACIONN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMLTIPLICACIONN.Location = new System.Drawing.Point(540, 70);
            this.LBLMLTIPLICACIONN.Name = "LBLMLTIPLICACIONN";
            this.LBLMLTIPLICACIONN.Size = new System.Drawing.Size(23, 25);
            this.LBLMLTIPLICACIONN.TabIndex = 9;
            this.LBLMLTIPLICACIONN.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(314, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Multiplicación Negativos ";
            // 
            // LBLSCPARES
            // 
            this.LBLSCPARES.AutoSize = true;
            this.LBLSCPARES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSCPARES.Location = new System.Drawing.Point(244, 100);
            this.LBLSCPARES.Name = "LBLSCPARES";
            this.LBLSCPARES.Size = new System.Drawing.Size(23, 25);
            this.LBLSCPARES.TabIndex = 7;
            this.LBLSCPARES.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Suma de Columnas Pares ";
            // 
            // LBLSUMATOTAL
            // 
            this.LBLSUMATOTAL.AutoSize = true;
            this.LBLSUMATOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSUMATOTAL.Location = new System.Drawing.Point(430, 34);
            this.LBLSUMATOTAL.Name = "LBLSUMATOTAL";
            this.LBLSUMATOTAL.Size = new System.Drawing.Size(23, 25);
            this.LBLSUMATOTAL.TabIndex = 5;
            this.LBLSUMATOTAL.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Suma Total ";
            // 
            // LBLEPOSITIVO
            // 
            this.LBLEPOSITIVO.AutoSize = true;
            this.LBLEPOSITIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEPOSITIVO.Location = new System.Drawing.Point(198, 30);
            this.LBLEPOSITIVO.Name = "LBLEPOSITIVO";
            this.LBLEPOSITIVO.Size = new System.Drawing.Size(23, 25);
            this.LBLEPOSITIVO.TabIndex = 3;
            this.LBLEPOSITIVO.Text = "0";
            // 
            // LBLENEGATIVOS
            // 
            this.LBLENEGATIVOS.AutoSize = true;
            this.LBLENEGATIVOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLENEGATIVOS.Location = new System.Drawing.Point(204, 70);
            this.LBLENEGATIVOS.Name = "LBLENEGATIVOS";
            this.LBLENEGATIVOS.Size = new System.Drawing.Size(23, 25);
            this.LBLENEGATIVOS.TabIndex = 2;
            this.LBLENEGATIVOS.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Elementos Negativos ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Elementos Positivos ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(643, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GPBRESULTADOS);
            this.Controls.Add(this.BTNCALCULARM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNCREARM);
            this.Controls.Add(this.TXTBCOLUMNA);
            this.Controls.Add(this.TXTBFILA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 18";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTBFILA;
        private System.Windows.Forms.TextBox TXTBCOLUMNA;
        private System.Windows.Forms.Button BTNCREARM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNCALCULARM;
        private System.Windows.Forms.GroupBox GPBRESULTADOS;
        private System.Windows.Forms.Label LBLEPOSITIVO;
        private System.Windows.Forms.Label LBLENEGATIVOS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLMLTIPLICACIONN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LBLSCPARES;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LBLSUMATOTAL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

