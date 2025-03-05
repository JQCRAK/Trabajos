namespace CapaPresentacion
{
    partial class FRMREPORTERESUMENCATEGORIA
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
            this.ejercicio5DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalporcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_por_categoriaTableAdapter = new CapaPresentacion.Ejercicio5DataSet1TableAdapters.total_por_categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalporcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.totalporcategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ejercicio5DataSet1
            // 
            this.ejercicio5DataSet1.DataSetName = "Ejercicio5DataSet1";
            this.ejercicio5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejercicio5DataSet1BindingSource
            // 
            this.ejercicio5DataSet1BindingSource.DataSource = this.ejercicio5DataSet1;
            this.ejercicio5DataSet1BindingSource.Position = 0;
            // 
            // totalporcategoriaBindingSource
            // 
            this.totalporcategoriaBindingSource.DataMember = "total_por_categoria";
            this.totalporcategoriaBindingSource.DataSource = this.ejercicio5DataSet1BindingSource;
            // 
            // total_por_categoriaTableAdapter
            // 
            this.total_por_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTERESUMENCATEGORIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTERESUMENCATEGORIA";
            this.Text = "Resumen de Categorias";
            this.Load += new System.EventHandler(this.FRMREPORTERESUMENCATEGORIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio5DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalporcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ejercicio5DataSet1 ejercicio5DataSet1;
        private System.Windows.Forms.BindingSource ejercicio5DataSet1BindingSource;
        private System.Windows.Forms.BindingSource totalporcategoriaBindingSource;
        private Ejercicio5DataSet1TableAdapters.total_por_categoriaTableAdapter total_por_categoriaTableAdapter;
    }
}