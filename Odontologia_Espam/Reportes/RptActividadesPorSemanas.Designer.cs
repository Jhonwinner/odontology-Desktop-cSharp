namespace Reportes
{
    partial class RptActividadesPorSemanas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptActividadesPorSemanas));
            this.spRptActividadesEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Odontologia_EspamDataSet = new Reportes.Odontologia_EspamDataSet();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtpx_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtpx_Fin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spRptActividadesEntreFechasTableAdapter = new Reportes.Odontologia_EspamDataSetTableAdapters.spRptActividadesEntreFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spRptActividadesEntreFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odontologia_EspamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spRptActividadesEntreFechasBindingSource
            // 
            this.spRptActividadesEntreFechasBindingSource.DataMember = "spRptActividadesEntreFechas";
            this.spRptActividadesEntreFechasBindingSource.DataSource = this.Odontologia_EspamDataSet;
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
            this.btn_salir.Location = new System.Drawing.Point(697, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(43, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtpx_Inicio
            // 
            this.dtpx_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpx_Inicio.Location = new System.Drawing.Point(135, 32);
            this.dtpx_Inicio.Name = "dtpx_Inicio";
            this.dtpx_Inicio.Size = new System.Drawing.Size(123, 20);
            this.dtpx_Inicio.TabIndex = 14;
            // 
            // dtpx_Fin
            // 
            this.dtpx_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpx_Fin.Location = new System.Drawing.Point(510, 34);
            this.dtpx_Fin.Name = "dtpx_Fin";
            this.dtpx_Fin.Size = new System.Drawing.Size(120, 20);
            this.dtpx_Fin.TabIndex = 15;
            this.dtpx_Fin.Value = new System.DateTime(2014, 1, 28, 0, 0, 0, 0);
            this.dtpx_Fin.ValueChanged += new System.EventHandler(this.dtpx_Fin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha de Inicio";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "entreFechas";
            reportDataSource1.Value = this.spRptActividadesEntreFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.rpt_Citas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 621);
            this.reportViewer1.TabIndex = 19;
            // 
            // spRptActividadesEntreFechasTableAdapter
            // 
            this.spRptActividadesEntreFechasTableAdapter.ClearBeforeFill = true;
            // 
            // RptActividadesPorSemanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 693);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpx_Fin);
            this.Controls.Add(this.dtpx_Inicio);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RptActividadesPorSemanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RptActividadesPorSemanas";
            this.Load += new System.EventHandler(this.RptActividadesPorSemanas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spRptActividadesEntreFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odontologia_EspamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DateTimePicker dtpx_Inicio;
        private System.Windows.Forms.DateTimePicker dtpx_Fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spRptActividadesEntreFechasBindingSource;
        private Odontologia_EspamDataSet Odontologia_EspamDataSet;
        private Odontologia_EspamDataSetTableAdapters.spRptActividadesEntreFechasTableAdapter spRptActividadesEntreFechasTableAdapter;
    }
}