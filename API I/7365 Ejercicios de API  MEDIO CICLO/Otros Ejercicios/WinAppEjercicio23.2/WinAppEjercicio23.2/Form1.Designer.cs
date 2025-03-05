namespace WinAppEjercicio23._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBVALOR = new System.Windows.Forms.TextBox();
            this.BTNSUMAR = new System.Windows.Forms.Button();
            this.GPBSUMA = new System.Windows.Forms.GroupBox();
            this.LBLRESUL = new System.Windows.Forms.Label();
            this.GPBSUMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma Mágica de Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tu texto con números";
            // 
            // TXTBVALOR
            // 
            this.TXTBVALOR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBVALOR.Location = new System.Drawing.Point(25, 92);
            this.TXTBVALOR.Name = "TXTBVALOR";
            this.TXTBVALOR.Size = new System.Drawing.Size(454, 32);
            this.TXTBVALOR.TabIndex = 2;
            this.TXTBVALOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBVALOR_KeyPress);
            // 
            // BTNSUMAR
            // 
            this.BTNSUMAR.BackColor = System.Drawing.Color.Purple;
            this.BTNSUMAR.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUMAR.ForeColor = System.Drawing.Color.White;
            this.BTNSUMAR.Location = new System.Drawing.Point(160, 140);
            this.BTNSUMAR.Name = "BTNSUMAR";
            this.BTNSUMAR.Size = new System.Drawing.Size(188, 41);
            this.BTNSUMAR.TabIndex = 3;
            this.BTNSUMAR.Text = "Sumar Números";
            this.BTNSUMAR.UseVisualStyleBackColor = false;
            this.BTNSUMAR.Click += new System.EventHandler(this.BTNSUMAR_Click);
            // 
            // GPBSUMA
            // 
            this.GPBSUMA.Controls.Add(this.LBLRESUL);
            this.GPBSUMA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBSUMA.Location = new System.Drawing.Point(25, 210);
            this.GPBSUMA.Name = "GPBSUMA";
            this.GPBSUMA.Size = new System.Drawing.Size(335, 34);
            this.GPBSUMA.TabIndex = 4;
            this.GPBSUMA.TabStop = false;
            this.GPBSUMA.Text = "La suma es";
            // 
            // LBLRESUL
            // 
            this.LBLRESUL.AutoSize = true;
            this.LBLRESUL.Location = new System.Drawing.Point(135, 0);
            this.LBLRESUL.Name = "LBLRESUL";
            this.LBLRESUL.Size = new System.Drawing.Size(24, 27);
            this.LBLRESUL.TabIndex = 0;
            this.LBLRESUL.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 335);
            this.Controls.Add(this.GPBSUMA);
            this.Controls.Add(this.BTNSUMAR);
            this.Controls.Add(this.TXTBVALOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 23";
            this.GPBSUMA.ResumeLayout(false);
            this.GPBSUMA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBVALOR;
        private System.Windows.Forms.Button BTNSUMAR;
        private System.Windows.Forms.GroupBox GPBSUMA;
        private System.Windows.Forms.Label LBLRESUL;
    }
}

