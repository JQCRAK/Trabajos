namespace CapaPresentacion
{
    partial class FRMREPORTRESUMENPROVEDORES
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ejercicio5DataSet1 = new CapaPresentacion.Ejercicio5DataSet1();
            this.totalsuministrosproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_suministros_proveedorTableAdapter = new CapaPresentacion.Ejercicio5DataSet1TableAdapters.total_suministros_proveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalsuministrosproveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.totalsuministrosproveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // ejercicio5DataSet1
            // 
            this.ejercicio5DataSet1.DataSetName = "Ejercicio5DataSet1";
            this.ejercicio5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalsuministrosproveedorBindingSource
            // 
            this.totalsuministrosproveedorBindingSource.DataMember = "total_suministros_proveedor";
            this.totalsuministrosproveedorBindingSource.DataSource = this.ejercicio5DataSet1;
            // 
            // total_suministros_proveedorTableAdapter
            // 
            this.total_suministros_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTRESUMENPROVEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTRESUMENPROVEDORES";
            this.Text = "Resumen de Provedores";
            this.Load += new System.EventHandler(this.FRMREPORTRESUMENPROVEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalsuministrosproveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ejercicio5DataSet1 ejercicio5DataSet1;
        private System.Windows.Forms.BindingSource totalsuministrosproveedorBindingSource;
        private Ejercicio5DataSet1TableAdapters.total_suministros_proveedorTableAdapter total_suministros_proveedorTableAdapter;
    }
}