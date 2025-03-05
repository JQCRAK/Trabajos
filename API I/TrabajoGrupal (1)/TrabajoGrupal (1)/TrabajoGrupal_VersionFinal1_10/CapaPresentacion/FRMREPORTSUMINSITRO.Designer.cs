namespace CapaPresentacion
{
    partial class FRMREPORTSUMINSITRO
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
            this.suministraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicio5DataSet1 = new CapaPresentacion.Ejercicio5DataSet1();
            this.suministraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicio5DataSet = new CapaPresentacion.Ejercicio5DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.suministraTableAdapter = new CapaPresentacion.Ejercicio5DataSetTableAdapters.suministraTableAdapter();
            this.totalporcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_por_categoriaTableAdapter = new CapaPresentacion.Ejercicio5DataSet1TableAdapters.total_por_categoriaTableAdapter();
            this.suministraTableAdapter1 = new CapaPresentacion.Ejercicio5DataSet1TableAdapters.suministraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalporcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // suministraBindingSource1
            // 
            this.suministraBindingSource1.DataMember = "suministra";
            this.suministraBindingSource1.DataSource = this.ejercicio5DataSet1;
            // 
            // ejercicio5DataSet1
            // 
            this.ejercicio5DataSet1.DataSetName = "Ejercicio5DataSet1";
            this.ejercicio5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suministraBindingSource
            // 
            this.suministraBindingSource.DataMember = "suministra";
            this.suministraBindingSource.DataSource = this.ejercicio5DataSet;
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
            reportDataSource1.Value = this.suministraBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(840, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // suministraTableAdapter
            // 
            this.suministraTableAdapter.ClearBeforeFill = true;
            // 
            // totalporcategoriaBindingSource
            // 
            this.totalporcategoriaBindingSource.DataMember = "total_por_categoria";
            this.totalporcategoriaBindingSource.DataSource = this.ejercicio5DataSet1;
            // 
            // total_por_categoriaTableAdapter
            // 
            this.total_por_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // suministraTableAdapter1
            // 
            this.suministraTableAdapter1.ClearBeforeFill = true;
            // 
            // FRMREPORTSUMINSITRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTSUMINSITRO";
            this.Text = "Reporte Suminitro";
            this.Load += new System.EventHandler(this.FRMREPORTSUMINSITRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalporcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ejercicio5DataSet ejercicio5DataSet;
        private System.Windows.Forms.BindingSource suministraBindingSource;
        private Ejercicio5DataSetTableAdapters.suministraTableAdapter suministraTableAdapter;
        private Ejercicio5DataSet1 ejercicio5DataSet1;
        private System.Windows.Forms.BindingSource totalporcategoriaBindingSource;
        private Ejercicio5DataSet1TableAdapters.total_por_categoriaTableAdapter total_por_categoriaTableAdapter;
        private System.Windows.Forms.BindingSource suministraBindingSource1;
        private Ejercicio5DataSet1TableAdapters.suministraTableAdapter suministraTableAdapter1;
    }
}