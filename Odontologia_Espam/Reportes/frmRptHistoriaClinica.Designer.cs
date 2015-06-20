namespace Reportes
{
    partial class frmRptHistoriaClinica
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
            this.RptVisualizaSesion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cbox_Consulta = new System.Windows.Forms.CheckBox();
            this.Odontologia_EspamDataSet = new Reportes.Odontologia_EspamDataSet();
            this.spRptConsultarConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spRptConsultarConsultaTableAdapter = new Reportes.Odontologia_EspamDataSetTableAdapters.spRptConsultarConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Odontologia_EspamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRptConsultarConsultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RptVisualizaSesion
            // 
            reportDataSource1.Name = "HistoriaPaciente";
            reportDataSource1.Value = this.spRptConsultarConsultaBindingSource;
            this.RptVisualizaSesion.LocalReport.DataSources.Add(reportDataSource1);
            this.RptVisualizaSesion.LocalReport.ReportEmbeddedResource = "Reportes.Report1.rdlc";
            this.RptVisualizaSesion.Location = new System.Drawing.Point(12, 53);
            this.RptVisualizaSesion.Name = "RptVisualizaSesion";
            this.RptVisualizaSesion.Size = new System.Drawing.Size(724, 578);
            this.RptVisualizaSesion.TabIndex = 0;
          
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filtrar.Location = new System.Drawing.Point(12, 15);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(114, 23);
            this.btn_Filtrar.TabIndex = 15;
            this.btn_Filtrar.Text = "Generar Reporte";
            this.btn_Filtrar.UseVisualStyleBackColor = false;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Location = new System.Drawing.Point(692, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(43, 23);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cbox_Consulta
            // 
            this.cbox_Consulta.AutoSize = true;
            this.cbox_Consulta.BackColor = System.Drawing.Color.Transparent;
            this.cbox_Consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Consulta.Location = new System.Drawing.Point(141, 19);
            this.cbox_Consulta.Name = "cbox_Consulta";
            this.cbox_Consulta.Size = new System.Drawing.Size(201, 20);
            this.cbox_Consulta.TabIndex = 16;
            this.cbox_Consulta.Text = "Filtrar por consulta Realizada";
            this.cbox_Consulta.UseVisualStyleBackColor = false;
            // 
            // Odontologia_EspamDataSet
            // 
            this.Odontologia_EspamDataSet.DataSetName = "Odontologia_EspamDataSet";
            this.Odontologia_EspamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spRptConsultarConsultaBindingSource
            // 
            this.spRptConsultarConsultaBindingSource.DataMember = "spRptConsultarConsulta";
            this.spRptConsultarConsultaBindingSource.DataSource = this.Odontologia_EspamDataSet;
            // 
            // spRptConsultarConsultaTableAdapter
            // 
            this.spRptConsultarConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reportes.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(748, 643);
            this.Controls.Add(this.cbox_Consulta);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.RptVisualizaSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRptHistoriaClinica";
            this.Load += new System.EventHandler(this.frmRptHistoriaClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Odontologia_EspamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRptConsultarConsultaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptVisualizaSesion;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.CheckBox cbox_Consulta;
        private System.Windows.Forms.BindingSource spRptConsultarConsultaBindingSource;
        private Odontologia_EspamDataSet Odontologia_EspamDataSet;
        private Odontologia_EspamDataSetTableAdapters.spRptConsultarConsultaTableAdapter spRptConsultarConsultaTableAdapter;
    }
}