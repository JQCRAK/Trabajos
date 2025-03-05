namespace CapaPresentacion
{
    partial class FRMREPORTPIEZA
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
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicio5DataSet = new CapaPresentacion.Ejercicio5DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.piezaTableAdapter = new CapaPresentacion.Ejercicio5DataSetTableAdapters.piezaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // piezaBindingSource
            // 
            this.piezaBindingSource.DataMember = "pieza";
            this.piezaBindingSource.DataSource = this.ejercicio5DataSet;
            // 
            // ejercicio5DataSet
            // 
            this.ejercicio5DataSet.DataSetName = "Ejercicio5DataSet";
            this.ejercicio5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.piezaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // piezaTableAdapter
            // 
            this.piezaTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTPIEZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTPIEZA";
            this.Text = "Reporte Pieza";
            this.Load += new System.EventHandler(this.FRMREPORTPIEZA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ejercicio5DataSet ejercicio5DataSet;
        private System.Windows.Forms.BindingSource piezaBindingSource;
        private Ejercicio5DataSetTableAdapters.piezaTableAdapter piezaTableAdapter;
    }
}