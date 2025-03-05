namespace CapaPresentacion
{
    partial class FRMREPORTE1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicio5DataSet1 = new CapaPresentacion.Ejercicio5DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.provTableAdapter = new CapaPresentacion.Ejercicio5DataSet1TableAdapters.provTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // provBindingSource
            // 
            this.provBindingSource.DataMember = "prov";
            this.provBindingSource.DataSource = this.ejercicio5DataSet1;
            // 
            // ejercicio5DataSet1
            // 
            this.ejercicio5DataSet1.DataSetName = "Ejercicio5DataSet1";
            this.ejercicio5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.provBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(836, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // provTableAdapter
            // 
            this.provTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE1";
            this.Text = "FRMREPORTE1";
            this.Load += new System.EventHandler(this.FRMREPORTE1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ejercicio5DataSet1 ejercicio5DataSet1;
        private System.Windows.Forms.BindingSource provBindingSource;
        private Ejercicio5DataSet1TableAdapters.provTableAdapter provTableAdapter;
    }
}