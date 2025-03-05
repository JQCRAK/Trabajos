namespace windoappPractica
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
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.LBL = new System.Windows.Forms.Label();
            this.labelBASE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextResultado = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.textBase = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.PFOTO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PFOTO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Red;
            this.BTNSALIR.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.Color.White;
            this.BTNSALIR.Location = new System.Drawing.Point(517, 369);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(120, 45);
            this.BTNSALIR.TabIndex = 0;
            this.BTNSALIR.Text = "&SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.BackColor = System.Drawing.Color.Transparent;
            this.LBL.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LBL.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL.ForeColor = System.Drawing.Color.Black;
            this.LBL.Location = new System.Drawing.Point(261, 72);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(265, 47);
            this.LBL.TabIndex = 1;
            this.LBL.Text = "Practica de C#";
            this.LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBASE
            // 
            this.labelBASE.AllowDrop = true;
            this.labelBASE.AutoSize = true;
            this.labelBASE.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBASE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBASE.Location = new System.Drawing.Point(137, 166);
            this.labelBASE.Name = "labelBASE";
            this.labelBASE.Size = new System.Drawing.Size(87, 28);
            this.labelBASE.TabIndex = 2;
            this.labelBASE.Text = "BASE:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(137, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALTURA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextResultado
            // 
            this.TextResultado.AutoSize = true;
            this.TextResultado.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextResultado.Location = new System.Drawing.Point(138, 299);
            this.TextResultado.Name = "TextResultado";
            this.TextResultado.Size = new System.Drawing.Size(316, 30);
            this.TextResultado.TabIndex = 4;
            this.TextResultado.Text = "El resultado del area es: ";
            this.TextResultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(448, 299);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(87, 30);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "label3";
            this.Resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(300, 233);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(208, 22);
            this.textAltura.TabIndex = 6;
            this.textAltura.TextChanged += new System.EventHandler(this.textAltura_TextChanged);
            // 
            // textBase
            // 
            this.textBase.Location = new System.Drawing.Point(300, 166);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(208, 22);
            this.textBase.TabIndex = 7;
            this.textBase.TextChanged += new System.EventHandler(this.textBase_TextChanged);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Lime;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(169, 369);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(120, 45);
            this.BTNCALCULAR.TabIndex = 8;
            this.BTNCALCULAR.Text = "CALCULAR";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // PFOTO
            // 
            this.PFOTO.Image = global::windoappPractica.Properties.Resources.triangulo_sinfondo;
            this.PFOTO.Location = new System.Drawing.Point(570, 135);
            this.PFOTO.Name = "PFOTO";
            this.PFOTO.Size = new System.Drawing.Size(186, 154);
            this.PFOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PFOTO.TabIndex = 9;
            this.PFOTO.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PFOTO);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.textBase);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.TextResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBASE);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.BTNSALIR);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PFOTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Label labelBASE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextResultado;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.PictureBox PFOTO;
    }
}

