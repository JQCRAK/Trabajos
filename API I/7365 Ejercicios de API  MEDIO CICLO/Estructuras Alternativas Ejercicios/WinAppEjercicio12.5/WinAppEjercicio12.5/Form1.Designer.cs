namespace WinAppEjercicio12._5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.PCBRESET = new System.Windows.Forms.PictureBox();
            this.TXTBARBITRO1 = new System.Windows.Forms.TextBox();
            this.TXTBARBITRO2 = new System.Windows.Forms.TextBox();
            this.TXTBARBITRO3 = new System.Windows.Forms.TextBox();
            this.TXTBARBITRO4 = new System.Windows.Forms.TextBox();
            this.TXTBARBITRO5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBRESET)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.LBLTITULO);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 73);
            this.panel1.TabIndex = 0;
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(90, 22);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(298, 31);
            this.LBLTITULO.TabIndex = 1;
            this.LBLTITULO.Text = "Puntuación de Gimnasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Árbitro 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Árbitro 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Árbitro 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Árbitro 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Árbitro 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Puntuación Final:";
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESUL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBLRESUL.Location = new System.Drawing.Point(205, 24);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(24, 27);
            this.LBLRESUL.TabIndex = 7;
            this.LBLRESUL.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.LBLRESUL);
            this.panel2.Location = new System.Drawing.Point(32, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 74);
            this.panel2.TabIndex = 8;
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Red;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(50, 364);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(336, 36);
            this.BTNCALCULAR.TabIndex = 9;
            this.BTNCALCULAR.Text = "Calcular Puntuación";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // PCBRESET
            // 
            this.PCBRESET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCBRESET.Image = global::WinAppEjercicio12._5.Properties.Resources.RESET;
            this.PCBRESET.Location = new System.Drawing.Point(407, 364);
            this.PCBRESET.Name = "PCBRESET";
            this.PCBRESET.Size = new System.Drawing.Size(36, 36);
            this.PCBRESET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBRESET.TabIndex = 10;
            this.PCBRESET.TabStop = false;
            this.PCBRESET.Click += new System.EventHandler(this.PCBRESET_Click);
            // 
            // TXTBARBITRO1
            // 
            this.TXTBARBITRO1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBARBITRO1.Location = new System.Drawing.Point(154, 106);
            this.TXTBARBITRO1.Name = "TXTBARBITRO1";
            this.TXTBARBITRO1.Size = new System.Drawing.Size(289, 34);
            this.TXTBARBITRO1.TabIndex = 1;
            this.TXTBARBITRO1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBARBITRO1_KeyPress);
            // 
            // TXTBARBITRO2
            // 
            this.TXTBARBITRO2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBARBITRO2.Location = new System.Drawing.Point(154, 155);
            this.TXTBARBITRO2.Name = "TXTBARBITRO2";
            this.TXTBARBITRO2.Size = new System.Drawing.Size(289, 34);
            this.TXTBARBITRO2.TabIndex = 12;
            this.TXTBARBITRO2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBARBITRO2_KeyPress);
            // 
            // TXTBARBITRO3
            // 
            this.TXTBARBITRO3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBARBITRO3.Location = new System.Drawing.Point(154, 208);
            this.TXTBARBITRO3.Name = "TXTBARBITRO3";
            this.TXTBARBITRO3.Size = new System.Drawing.Size(289, 34);
            this.TXTBARBITRO3.TabIndex = 13;
            this.TXTBARBITRO3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBARBITRO3_KeyPress);
            // 
            // TXTBARBITRO4
            // 
            this.TXTBARBITRO4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBARBITRO4.Location = new System.Drawing.Point(154, 262);
            this.TXTBARBITRO4.Name = "TXTBARBITRO4";
            this.TXTBARBITRO4.Size = new System.Drawing.Size(289, 34);
            this.TXTBARBITRO4.TabIndex = 14;
            this.TXTBARBITRO4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBARBITRO4_KeyPress);
            // 
            // TXTBARBITRO5
            // 
            this.TXTBARBITRO5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBARBITRO5.Location = new System.Drawing.Point(154, 315);
            this.TXTBARBITRO5.Name = "TXTBARBITRO5";
            this.TXTBARBITRO5.Size = new System.Drawing.Size(289, 34);
            this.TXTBARBITRO5.TabIndex = 15;
            this.TXTBARBITRO5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBARBITRO5_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.TXTBARBITRO5);
            this.Controls.Add(this.TXTBARBITRO4);
            this.Controls.Add(this.TXTBARBITRO3);
            this.Controls.Add(this.TXTBARBITRO2);
            this.Controls.Add(this.TXTBARBITRO1);
            this.Controls.Add(this.PCBRESET);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Ejercicio 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBRESET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBLRESUL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.PictureBox PCBRESET;
        private System.Windows.Forms.TextBox TXTBARBITRO1;
        private System.Windows.Forms.TextBox TXTBARBITRO2;
        private System.Windows.Forms.TextBox TXTBARBITRO3;
        private System.Windows.Forms.TextBox TXTBARBITRO4;
        private System.Windows.Forms.TextBox TXTBARBITRO5;
    }
}

