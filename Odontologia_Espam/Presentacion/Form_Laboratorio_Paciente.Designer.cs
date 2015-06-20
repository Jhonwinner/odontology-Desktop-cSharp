namespace Presentacion
{
    partial class Form_Laboratorio_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Laboratorio_Paciente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_ACtualiza_DAT = new System.Windows.Forms.Button();
            this.Lab_New = new System.Windows.Forms.Label();
            this.L_actua = new System.Windows.Forms.Label();
            this.lab_Modificar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lab_Eliminar = new System.Windows.Forms.Label();
            this.but_Borrar = new System.Windows.Forms.Button();
            this.but_Nuevo = new System.Windows.Forms.Button();
            this.Lab_Nhistory = new System.Windows.Forms.Label();
            this.Cont_Buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_CI = new System.Windows.Forms.RadioButton();
            this.RB_N_History = new System.Windows.Forms.RadioButton();
            this.but_bucar = new System.Windows.Forms.Button();
            this.Lab_Pac = new System.Windows.Forms.Label();
            this.DG_Ordenes = new System.Windows.Forms.DataGridView();
            this.Fecha_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descp_Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultados_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_HIstoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Exa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_Historia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Bt_ACtualiza_DAT);
            this.groupBox1.Controls.Add(this.Lab_New);
            this.groupBox1.Controls.Add(this.L_actua);
            this.groupBox1.Controls.Add(this.lab_Modificar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lab_Eliminar);
            this.groupBox1.Controls.Add(this.but_Borrar);
            this.groupBox1.Controls.Add(this.but_Nuevo);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Bt_ACtualiza_DAT
            // 
            this.Bt_ACtualiza_DAT.BackgroundImage = global::Presentacion.Properties.Resources.Sync__1_;
            resources.ApplyResources(this.Bt_ACtualiza_DAT, "Bt_ACtualiza_DAT");
            this.Bt_ACtualiza_DAT.Name = "Bt_ACtualiza_DAT";
            this.Bt_ACtualiza_DAT.UseVisualStyleBackColor = false;
            // 
            // Lab_New
            // 
            resources.ApplyResources(this.Lab_New, "Lab_New");
            this.Lab_New.BackColor = System.Drawing.Color.Transparent;
            this.Lab_New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lab_New.Name = "Lab_New";
            // 
            // L_actua
            // 
            resources.ApplyResources(this.L_actua, "L_actua");
            this.L_actua.BackColor = System.Drawing.Color.Transparent;
            this.L_actua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L_actua.Name = "L_actua";
            // 
            // lab_Modificar
            // 
            resources.ApplyResources(this.lab_Modificar, "lab_Modificar");
            this.lab_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.lab_Modificar.ForeColor = System.Drawing.Color.White;
            this.lab_Modificar.Name = "lab_Modificar";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Presentacion.Properties.Resources.documento_de_modificar_el_archivo_de_papel_icono_4468_96;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lab_Eliminar
            // 
            resources.ApplyResources(this.lab_Eliminar, "lab_Eliminar");
            this.lab_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.lab_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_Eliminar.Name = "lab_Eliminar";
            // 
            // but_Borrar
            // 
            this.but_Borrar.BackgroundImage = global::Presentacion.Properties.Resources.erase_delete_remove_wipe_out_512;
            resources.ApplyResources(this.but_Borrar, "but_Borrar");
            this.but_Borrar.Name = "but_Borrar";
            this.but_Borrar.UseVisualStyleBackColor = false;
            this.but_Borrar.Click += new System.EventHandler(this.but_Borrar_Click);
            // 
            // but_Nuevo
            // 
            this.but_Nuevo.BackgroundImage = global::Presentacion.Properties.Resources.document_add2;
            resources.ApplyResources(this.but_Nuevo, "but_Nuevo");
            this.but_Nuevo.ForeColor = System.Drawing.Color.Transparent;
            this.but_Nuevo.Name = "but_Nuevo";
            this.but_Nuevo.UseVisualStyleBackColor = true;
            this.but_Nuevo.Click += new System.EventHandler(this.but_Nuevo_Click);
            // 
            // Lab_Nhistory
            // 
            resources.ApplyResources(this.Lab_Nhistory, "Lab_Nhistory");
            this.Lab_Nhistory.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Nhistory.Name = "Lab_Nhistory";
            this.Lab_Nhistory.Click += new System.EventHandler(this.Lab_Nhistory_Click);
            // 
            // Cont_Buscar
            // 
            resources.ApplyResources(this.Cont_Buscar, "Cont_Buscar");
            this.Cont_Buscar.Name = "Cont_Buscar";
            this.Cont_Buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Cont_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // rb_CI
            // 
            resources.ApplyResources(this.rb_CI, "rb_CI");
            this.rb_CI.BackColor = System.Drawing.Color.Transparent;
            this.rb_CI.Name = "rb_CI";
            this.rb_CI.TabStop = true;
            this.rb_CI.UseVisualStyleBackColor = false;
            this.rb_CI.CheckedChanged += new System.EventHandler(this.rb_CI_CheckedChanged);
            // 
            // RB_N_History
            // 
            resources.ApplyResources(this.RB_N_History, "RB_N_History");
            this.RB_N_History.BackColor = System.Drawing.Color.Transparent;
            this.RB_N_History.Name = "RB_N_History";
            this.RB_N_History.TabStop = true;
            this.RB_N_History.UseVisualStyleBackColor = false;
            this.RB_N_History.CheckedChanged += new System.EventHandler(this.RB_N_History_CheckedChanged);
            // 
            // but_bucar
            // 
            this.but_bucar.BackgroundImage = global::Presentacion.Properties.Resources.searchhome__1_;
            resources.ApplyResources(this.but_bucar, "but_bucar");
            this.but_bucar.Name = "but_bucar";
            this.but_bucar.UseVisualStyleBackColor = false;
            this.but_bucar.Click += new System.EventHandler(this.but_bucar_Click);
            // 
            // Lab_Pac
            // 
            resources.ApplyResources(this.Lab_Pac, "Lab_Pac");
            this.Lab_Pac.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Pac.Name = "Lab_Pac";
            // 
            // DG_Ordenes
            // 
            this.DG_Ordenes.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.DG_Ordenes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_Ordenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DG_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Ordenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_E,
            this.Fecha_R,
            this.Status_,
            this.Descp_Examen,
            this.Resultados_,
            this.id_consulta,
            this.N_HIstoria,
            this.Cod_Exa});
            this.DG_Ordenes.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DG_Ordenes, "DG_Ordenes");
            this.DG_Ordenes.Name = "DG_Ordenes";
            this.DG_Ordenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Ordenes_CellClick);
            this.DG_Ordenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Ordenes_CellContentClick);
            this.DG_Ordenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Ordenes_CellDoubleClick);
            // 
            // Fecha_E
            // 
            resources.ApplyResources(this.Fecha_E, "Fecha_E");
            this.Fecha_E.Name = "Fecha_E";
            // 
            // Fecha_R
            // 
            resources.ApplyResources(this.Fecha_R, "Fecha_R");
            this.Fecha_R.Name = "Fecha_R";
            // 
            // Status_
            // 
            resources.ApplyResources(this.Status_, "Status_");
            this.Status_.Name = "Status_";
            // 
            // Descp_Examen
            // 
            resources.ApplyResources(this.Descp_Examen, "Descp_Examen");
            this.Descp_Examen.Name = "Descp_Examen";
            // 
            // Resultados_
            // 
            resources.ApplyResources(this.Resultados_, "Resultados_");
            this.Resultados_.Name = "Resultados_";
            // 
            // id_consulta
            // 
            resources.ApplyResources(this.id_consulta, "id_consulta");
            this.id_consulta.Name = "id_consulta";
            // 
            // N_HIstoria
            // 
            resources.ApplyResources(this.N_HIstoria, "N_HIstoria");
            this.N_HIstoria.Name = "N_HIstoria";
            // 
            // Cod_Exa
            // 
            resources.ApplyResources(this.Cod_Exa, "Cod_Exa");
            this.Cod_Exa.Name = "Cod_Exa";
            // 
            // lab_Historia
            // 
            resources.ApplyResources(this.lab_Historia, "lab_Historia");
            this.lab_Historia.BackColor = System.Drawing.Color.Transparent;
            this.lab_Historia.Name = "lab_Historia";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // Form_Laboratorio_Paciente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_Historia);
            this.Controls.Add(this.Lab_Pac);
            this.Controls.Add(this.RB_N_History);
            this.Controls.Add(this.rb_CI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cont_Buscar);
            this.Controls.Add(this.but_bucar);
            this.Controls.Add(this.Lab_Nhistory);
            this.Controls.Add(this.DG_Ordenes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Laboratorio_Paciente";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form_Laboratorio_Paciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_Borrar;
        private System.Windows.Forms.Button but_Nuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lab_New;
        private System.Windows.Forms.Label lab_Modificar;
        private System.Windows.Forms.Label lab_Eliminar;
        private System.Windows.Forms.Label Lab_Nhistory;
        private System.Windows.Forms.Button but_bucar;
        private System.Windows.Forms.TextBox Cont_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_CI;
        private System.Windows.Forms.RadioButton RB_N_History;
        private System.Windows.Forms.Label Lab_Pac;
        private System.Windows.Forms.DataGridView DG_Ordenes;
        private System.Windows.Forms.Label lab_Historia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_R;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descp_Examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultados_;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_HIstoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Exa;
        private System.Windows.Forms.Button Bt_ACtualiza_DAT;
        private System.Windows.Forms.Label L_actua;

    }
}