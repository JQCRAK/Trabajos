namespace WinAppEjercicio16._2
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
            this.BTNGENERAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de Conversión de Tallas";
            // 
            // BTNGENERAR
            // 
            this.BTNGENERAR.BackColor = System.Drawing.Color.Black;
            this.BTNGENERAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGENERAR.ForeColor = System.Drawing.Color.White;
            this.BTNGENERAR.Location = new System.Drawing.Point(38, 63);
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Size = new System.Drawing.Size(303, 35);
            this.BTNGENERAR.TabIndex = 1;
            this.BTNGENERAR.Text = "Generar Tabla";
            this.BTNGENERAR.UseVisualStyleBackColor = false;
            this.BTNGENERAR.Click += new System.EventHandler(this.BTNGENERAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla conversiones desde 48 hasta 84 pulgadas.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(379, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNGENERAR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNGENERAR;
        private System.Windows.Forms.Label label2;
    }
}

