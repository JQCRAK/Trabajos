namespace CapaPresentacion
{
    partial class FRMEDITAR
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
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreProv = new System.Windows.Forms.Label();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(140, 286);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(281, 32);
            this.txtProvincia.TabIndex = 73;
            this.txtProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvincia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Provincia:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(140, 221);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(281, 32);
            this.txtCiudad.TabIndex = 71;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "Dirección:";
            // 
            // lblNombreProv
            // 
            this.lblNombreProv.AutoSize = true;
            this.lblNombreProv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProv.ForeColor = System.Drawing.Color.White;
            this.lblNombreProv.Location = new System.Drawing.Point(139, 85);
            this.lblNombreProv.Name = "lblNombreProv";
            this.lblNombreProv.Size = new System.Drawing.Size(15, 24);
            this.lblNombreProv.TabIndex = 68;
            this.lblNombreProv.Text = ".";
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.BackColor = System.Drawing.Color.Indigo;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.ForeColor = System.Drawing.Color.White;
            this.BTNCANCELAR.Location = new System.Drawing.Point(242, 372);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(179, 34);
            this.BTNCANCELAR.TabIndex = 67;
            this.BTNCANCELAR.Text = "Cancelar";
            this.BTNCANCELAR.UseVisualStyleBackColor = false;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.Indigo;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.White;
            this.BTNGUARDAR.Location = new System.Drawing.Point(41, 372);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(179, 34);
            this.BTNGUARDAR.TabIndex = 66;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(140, 146);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(281, 32);
            this.txtDireccion.TabIndex = 64;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "EDITAR PROVEEDOR";
            // 
            // FRMEDITAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(495, 453);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNombreProv);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.Name = "FRMEDITAR";
            this.Text = "FRMEDITAR";
            this.Load += new System.EventHandler(this.FRMEDITAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreProv;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
    }
}