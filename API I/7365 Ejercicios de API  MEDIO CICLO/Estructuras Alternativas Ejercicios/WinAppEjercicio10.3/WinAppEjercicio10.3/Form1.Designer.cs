namespace WinAppEjercicio10._3
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
            this.BTNINGRESAR = new System.Windows.Forms.Button();
            this.CMBTIPOUSUARIO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GRPBDISPOSITIVOAUTORIZADO = new System.Windows.Forms.GroupBox();
            this.CKBNO = new System.Windows.Forms.CheckBox();
            this.CKBSI = new System.Windows.Forms.CheckBox();
            this.GRPBVIDEOSVISTO = new System.Windows.Forms.GroupBox();
            this.TXTBVALOR = new System.Windows.Forms.TextBox();
            this.GRPBTIPODERED = new System.Windows.Forms.GroupBox();
            this.CKBPRIVADA = new System.Windows.Forms.CheckBox();
            this.CKBPUBLICA = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.GRPBDISPOSITIVOAUTORIZADO.SuspendLayout();
            this.GRPBVIDEOSVISTO.SuspendLayout();
            this.GRPBTIPODERED.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.BTNINGRESAR);
            this.panel1.Controls.Add(this.CMBTIPOUSUARIO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GRPBDISPOSITIVOAUTORIZADO);
            this.panel1.Controls.Add(this.GRPBVIDEOSVISTO);
            this.panel1.Controls.Add(this.GRPBTIPODERED);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 362);
            this.panel1.TabIndex = 0;
            // 
            // BTNINGRESAR
            // 
            this.BTNINGRESAR.BackColor = System.Drawing.Color.White;
            this.BTNINGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNINGRESAR.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESAR.Location = new System.Drawing.Point(72, 296);
            this.BTNINGRESAR.Name = "BTNINGRESAR";
            this.BTNINGRESAR.Size = new System.Drawing.Size(326, 31);
            this.BTNINGRESAR.TabIndex = 5;
            this.BTNINGRESAR.Text = "Ingresar";
            this.BTNINGRESAR.UseVisualStyleBackColor = false;
            this.BTNINGRESAR.Click += new System.EventHandler(this.BTNINGRESAR_Click);
            // 
            // CMBTIPOUSUARIO
            // 
            this.CMBTIPOUSUARIO.FormattingEnabled = true;
            this.CMBTIPOUSUARIO.Items.AddRange(new object[] {
            "Premium",
            "Basico",
            "Visitante"});
            this.CMBTIPOUSUARIO.Location = new System.Drawing.Point(25, 116);
            this.CMBTIPOUSUARIO.Name = "CMBTIPOUSUARIO";
            this.CMBTIPOUSUARIO.Size = new System.Drawing.Size(422, 32);
            this.CMBTIPOUSUARIO.TabIndex = 1;
            this.CMBTIPOUSUARIO.SelectedIndexChanged += new System.EventHandler(this.CMBTIPOUSUARIO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Acceso";
            // 
            // GRPBDISPOSITIVOAUTORIZADO
            // 
            this.GRPBDISPOSITIVOAUTORIZADO.Controls.Add(this.CKBNO);
            this.GRPBDISPOSITIVOAUTORIZADO.Controls.Add(this.CKBSI);
            this.GRPBDISPOSITIVOAUTORIZADO.ForeColor = System.Drawing.Color.White;
            this.GRPBDISPOSITIVOAUTORIZADO.Location = new System.Drawing.Point(25, 165);
            this.GRPBDISPOSITIVOAUTORIZADO.Name = "GRPBDISPOSITIVOAUTORIZADO";
            this.GRPBDISPOSITIVOAUTORIZADO.Size = new System.Drawing.Size(422, 83);
            this.GRPBDISPOSITIVOAUTORIZADO.TabIndex = 4;
            this.GRPBDISPOSITIVOAUTORIZADO.TabStop = false;
            this.GRPBDISPOSITIVOAUTORIZADO.Text = "Dispositivo Autorizado";
            // 
            // CKBNO
            // 
            this.CKBNO.AutoSize = true;
            this.CKBNO.Location = new System.Drawing.Point(123, 42);
            this.CKBNO.Name = "CKBNO";
            this.CKBNO.Size = new System.Drawing.Size(56, 28);
            this.CKBNO.TabIndex = 1;
            this.CKBNO.Text = "No";
            this.CKBNO.UseVisualStyleBackColor = true;
            this.CKBNO.CheckedChanged += new System.EventHandler(this.CKBNO_CheckedChanged);
            // 
            // CKBSI
            // 
            this.CKBSI.AutoSize = true;
            this.CKBSI.Location = new System.Drawing.Point(21, 42);
            this.CKBSI.Name = "CKBSI";
            this.CKBSI.Size = new System.Drawing.Size(46, 28);
            this.CKBSI.TabIndex = 0;
            this.CKBSI.Text = "Si";
            this.CKBSI.UseVisualStyleBackColor = true;
            this.CKBSI.CheckedChanged += new System.EventHandler(this.CKBSI_CheckedChanged);
            // 
            // GRPBVIDEOSVISTO
            // 
            this.GRPBVIDEOSVISTO.Controls.Add(this.TXTBVALOR);
            this.GRPBVIDEOSVISTO.ForeColor = System.Drawing.Color.White;
            this.GRPBVIDEOSVISTO.Location = new System.Drawing.Point(25, 165);
            this.GRPBVIDEOSVISTO.Name = "GRPBVIDEOSVISTO";
            this.GRPBVIDEOSVISTO.Size = new System.Drawing.Size(422, 83);
            this.GRPBVIDEOSVISTO.TabIndex = 6;
            this.GRPBVIDEOSVISTO.TabStop = false;
            this.GRPBVIDEOSVISTO.Text = "Videos vistos hoy";
            // 
            // TXTBVALOR
            // 
            this.TXTBVALOR.Location = new System.Drawing.Point(13, 31);
            this.TXTBVALOR.Name = "TXTBVALOR";
            this.TXTBVALOR.Size = new System.Drawing.Size(362, 32);
            this.TXTBVALOR.TabIndex = 0;
            this.TXTBVALOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBVALOR_KeyPress);
            // 
            // GRPBTIPODERED
            // 
            this.GRPBTIPODERED.Controls.Add(this.CKBPRIVADA);
            this.GRPBTIPODERED.Controls.Add(this.CKBPUBLICA);
            this.GRPBTIPODERED.ForeColor = System.Drawing.Color.White;
            this.GRPBTIPODERED.Location = new System.Drawing.Point(25, 165);
            this.GRPBTIPODERED.Name = "GRPBTIPODERED";
            this.GRPBTIPODERED.Size = new System.Drawing.Size(422, 83);
            this.GRPBTIPODERED.TabIndex = 5;
            this.GRPBTIPODERED.TabStop = false;
            this.GRPBTIPODERED.Text = "Tipo de Red";
            // 
            // CKBPRIVADA
            // 
            this.CKBPRIVADA.AutoSize = true;
            this.CKBPRIVADA.Location = new System.Drawing.Point(140, 42);
            this.CKBPRIVADA.Name = "CKBPRIVADA";
            this.CKBPRIVADA.Size = new System.Drawing.Size(94, 28);
            this.CKBPRIVADA.TabIndex = 1;
            this.CKBPRIVADA.Text = "Privada";
            this.CKBPRIVADA.UseVisualStyleBackColor = true;
            this.CKBPRIVADA.CheckedChanged += new System.EventHandler(this.CKBPRIVADA_CheckedChanged);
            // 
            // CKBPUBLICA
            // 
            this.CKBPUBLICA.AutoSize = true;
            this.CKBPUBLICA.Location = new System.Drawing.Point(21, 42);
            this.CKBPUBLICA.Name = "CKBPUBLICA";
            this.CKBPUBLICA.Size = new System.Drawing.Size(92, 28);
            this.CKBPUBLICA.TabIndex = 0;
            this.CKBPUBLICA.Text = "Publica";
            this.CKBPUBLICA.UseVisualStyleBackColor = true;
            this.CKBPUBLICA.CheckedChanged += new System.EventHandler(this.CKBPUBLICA_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(563, 436);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GRPBDISPOSITIVOAUTORIZADO.ResumeLayout(false);
            this.GRPBDISPOSITIVOAUTORIZADO.PerformLayout();
            this.GRPBVIDEOSVISTO.ResumeLayout(false);
            this.GRPBVIDEOSVISTO.PerformLayout();
            this.GRPBTIPODERED.ResumeLayout(false);
            this.GRPBTIPODERED.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBTIPOUSUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GRPBDISPOSITIVOAUTORIZADO;
        private System.Windows.Forms.CheckBox CKBSI;
        private System.Windows.Forms.CheckBox CKBNO;
        private System.Windows.Forms.Button BTNINGRESAR;
        private System.Windows.Forms.GroupBox GRPBTIPODERED;
        private System.Windows.Forms.CheckBox CKBPRIVADA;
        private System.Windows.Forms.CheckBox CKBPUBLICA;
        private System.Windows.Forms.GroupBox GRPBVIDEOSVISTO;
        private System.Windows.Forms.TextBox TXTBVALOR;
    }
}

