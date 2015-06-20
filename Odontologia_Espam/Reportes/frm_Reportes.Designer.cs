namespace Reportes
{
    partial class frm_Reportes
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
            this.spRptUsoDelaAplicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Odontologia_EspamDataSet = new Reportes.Odontologia_EspamDataSet();
            this.btn_salir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spRptUsoDelaAplicacionTableAdapter = new Reportes.Odontologia_EspamDataSetTableAdapters.spRptUsoDelaAplicacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spRptUsoDelaAplicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odontologia_EspamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spRptUsoDelaAplicacionBindingSource
            // 
            this.spRptUsoDelaAplicacionBindingSource.DataMember = "spRptUsoDelaAplicacion";
            this.spRptUsoDelaAplicacionBindingSource.DataSource = this.Odontologia_EspamDataSet;
            // 
            // Odontologia_EspamDataSet
            // 
            this.Odontologia_EspamDataSet.DataSetName = "Odontologia_EspamDataSet";
            this.Odontologia_EspamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Location = new System.Drawing.Point(728, 9);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(43, 23);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Seesiones";
            reportDataSource1.Value = this.spRptUsoDelaAplicacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.rpt_Sesiones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(758, 566);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spRptUsoDelaAplicacionTableAdapter
            // 
            this.spRptUsoDelaAplicacionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reportes.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(782, 644);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Reportes";
            this.Load += new System.EventHandler(this.frm_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spRptUsoDelaAplicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odontologia_EspamDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spRptUsoDelaAplicacionBindingSource;
        private Odontologia_EspamDataSet Odontologia_EspamDataSet;
        private Odontologia_EspamDataSetTableAdapters.spRptUsoDelaAplicacionTableAdapter spRptUsoDelaAplicacionTableAdapter;
    }
}