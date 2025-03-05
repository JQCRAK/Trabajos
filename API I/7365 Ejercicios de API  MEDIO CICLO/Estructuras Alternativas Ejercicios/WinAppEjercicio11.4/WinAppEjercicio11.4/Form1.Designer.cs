namespace WinAppEjercicio11._4
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
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTBVALORX = new System.Windows.Forms.TextBox();
            this.TXTBVALORY = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.LBLPUNTO = new System.Windows.Forms.Label();
            this.LBLRESULCUADRANTE = new System.Windows.Forms.Label();
            this.LBLDISTANCIA = new System.Windows.Forms.Label();
            this.LBLRESULDISTANCIA = new System.Windows.Forms.Label();
            this.PCBCUADRANTE = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCUADRANTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.Location = new System.Drawing.Point(71, 9);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(372, 26);
            this.LBLTITULO.TabIndex = 0;
            this.LBLTITULO.Text = "Localizador de Cuadrantes y Distancia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coordenada X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(29, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese un número para la coordenada X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coordenada Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(30, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese un número para la coordenada Y";
            // 
            // TXTBVALORX
            // 
            this.TXTBVALORX.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBVALORX.Location = new System.Drawing.Point(34, 97);
            this.TXTBVALORX.Name = "TXTBVALORX";
            this.TXTBVALORX.Size = new System.Drawing.Size(392, 33);
            this.TXTBVALORX.TabIndex = 5;
            this.TXTBVALORX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBVALORX_KeyPress);
            // 
            // TXTBVALORY
            // 
            this.TXTBVALORY.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBVALORY.Location = new System.Drawing.Point(33, 213);
            this.TXTBVALORY.Name = "TXTBVALORY";
            this.TXTBVALORY.Size = new System.Drawing.Size(393, 33);
            this.TXTBVALORY.TabIndex = 6;
            this.TXTBVALORY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBVALORY_KeyPress);
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.BackColor = System.Drawing.Color.Black;
            this.BTNCALCULAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCALCULAR.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCALCULAR.ForeColor = System.Drawing.Color.White;
            this.BTNCALCULAR.Location = new System.Drawing.Point(33, 296);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(330, 43);
            this.BTNCALCULAR.TabIndex = 7;
            this.BTNCALCULAR.Text = "Calcular";
            this.BTNCALCULAR.UseVisualStyleBackColor = false;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // LBLPUNTO
            // 
            this.LBLPUNTO.AutoSize = true;
            this.LBLPUNTO.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPUNTO.Location = new System.Drawing.Point(30, 378);
            this.LBLPUNTO.Name = "LBLPUNTO";
            this.LBLPUNTO.Size = new System.Drawing.Size(0, 23);
            this.LBLPUNTO.TabIndex = 8;
            // 
            // LBLRESULCUADRANTE
            // 
            this.LBLRESULCUADRANTE.AutoSize = true;
            this.LBLRESULCUADRANTE.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULCUADRANTE.Location = new System.Drawing.Point(30, 401);
            this.LBLRESULCUADRANTE.Name = "LBLRESULCUADRANTE";
            this.LBLRESULCUADRANTE.Size = new System.Drawing.Size(0, 23);
            this.LBLRESULCUADRANTE.TabIndex = 9;
            // 
            // LBLDISTANCIA
            // 
            this.LBLDISTANCIA.AutoSize = true;
            this.LBLDISTANCIA.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDISTANCIA.Location = new System.Drawing.Point(29, 424);
            this.LBLDISTANCIA.Name = "LBLDISTANCIA";
            this.LBLDISTANCIA.Size = new System.Drawing.Size(85, 23);
            this.LBLDISTANCIA.TabIndex = 10;
            this.LBLDISTANCIA.Text = "Distancia:";
            // 
            // LBLRESULDISTANCIA
            // 
            this.LBLRESULDISTANCIA.AutoSize = true;
            this.LBLRESULDISTANCIA.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULDISTANCIA.Location = new System.Drawing.Point(120, 424);
            this.LBLRESULDISTANCIA.Name = "LBLRESULDISTANCIA";
            this.LBLRESULDISTANCIA.Size = new System.Drawing.Size(0, 23);
            this.LBLRESULDISTANCIA.TabIndex = 11;
            // 
            // PCBCUADRANTE
            // 
            this.PCBCUADRANTE.Location = new System.Drawing.Point(315, 358);
            this.PCBCUADRANTE.Name = "PCBCUADRANTE";
            this.PCBCUADRANTE.Size = new System.Drawing.Size(176, 133);
            this.PCBCUADRANTE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBCUADRANTE.TabIndex = 12;
            this.PCBCUADRANTE.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WinAppEjercicio11._4.Properties.Resources.RESET;
            this.pictureBox1.Location = new System.Drawing.Point(383, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PCBCUADRANTE);
            this.Controls.Add(this.LBLRESULDISTANCIA);
            this.Controls.Add(this.LBLDISTANCIA);
            this.Controls.Add(this.LBLRESULCUADRANTE);
            this.Controls.Add(this.LBLPUNTO);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTBVALORY);
            this.Controls.Add(this.TXTBVALORX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLTITULO);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Ejercicio 11";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCBCUADRANTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTITULO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTBVALORX;
        private System.Windows.Forms.TextBox TXTBVALORY;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.Label LBLPUNTO;
        private System.Windows.Forms.Label LBLRESULCUADRANTE;
        private System.Windows.Forms.Label LBLDISTANCIA;
        private System.Windows.Forms.Label LBLRESULDISTANCIA;
        private System.Windows.Forms.PictureBox PCBCUADRANTE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

