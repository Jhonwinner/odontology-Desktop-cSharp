namespace Presentacion
{
    partial class Form_PlandeTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PlandeTrabajo));
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_descripciom = new System.Windows.Forms.TextBox();
            this.cbox_EstadoConsulta = new System.Windows.Forms.CheckBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_endHora = new System.Windows.Forms.TextBox();
            this.txt_HoraInicio = new System.Windows.Forms.TextBox();
            this.btn_CrearOrden = new System.Windows.Forms.Button();
            this.lbl_FechaCreacion = new System.Windows.Forms.Label();
            this.lbl_nroHistoria = new System.Windows.Forms.Label();
            this.mkTxt_FechaConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lbl_FinConsulta = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.Historia = new System.Windows.Forms.Label();
            this.lbl_horaIncio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_NombreDoctor = new System.Windows.Forms.Label();
            this.Lab_OdontoloNameInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Location = new System.Drawing.Point(834, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 28);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_descripciom
            // 
            this.txt_descripciom.Location = new System.Drawing.Point(140, 18);
            this.txt_descripciom.Multiline = true;
            this.txt_descripciom.Name = "txt_descripciom";
            this.txt_descripciom.Size = new System.Drawing.Size(241, 115);
            this.txt_descripciom.TabIndex = 2;
            // 
            // cbox_EstadoConsulta
            // 
            this.cbox_EstadoConsulta.AutoSize = true;
            this.cbox_EstadoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.cbox_EstadoConsulta.Location = new System.Drawing.Point(396, 90);
            this.cbox_EstadoConsulta.Name = "cbox_EstadoConsulta";
            this.cbox_EstadoConsulta.Size = new System.Drawing.Size(113, 17);
            this.cbox_EstadoConsulta.TabIndex = 3;
            this.cbox_EstadoConsulta.Text = "Paciente Atendido";
            this.cbox_EstadoConsulta.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(12, 162);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 28);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Añadir";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_NombreDoctor);
            this.groupBox1.Controls.Add(this.txt_endHora);
            this.groupBox1.Controls.Add(this.Lab_OdontoloNameInfo);
            this.groupBox1.Controls.Add(this.txt_HoraInicio);
            this.groupBox1.Controls.Add(this.lbl_FechaCreacion);
            this.groupBox1.Controls.Add(this.lbl_nroHistoria);
            this.groupBox1.Controls.Add(this.mkTxt_FechaConsulta);
            this.groupBox1.Controls.Add(this.lbl_FinConsulta);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.Historia);
            this.groupBox1.Controls.Add(this.txt_descripciom);
            this.groupBox1.Controls.Add(this.lbl_horaIncio);
            this.groupBox1.Controls.Add(this.cbox_EstadoConsulta);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elaborar Detalle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_endHora
            // 
            this.txt_endHora.Location = new System.Drawing.Point(598, 49);
            this.txt_endHora.Name = "txt_endHora";
            this.txt_endHora.Size = new System.Drawing.Size(44, 20);
            this.txt_endHora.TabIndex = 18;
            // 
            // txt_HoraInicio
            // 
            this.txt_HoraInicio.Location = new System.Drawing.Point(472, 50);
            this.txt_HoraInicio.Name = "txt_HoraInicio";
            this.txt_HoraInicio.Size = new System.Drawing.Size(44, 20);
            this.txt_HoraInicio.TabIndex = 17;
            this.txt_HoraInicio.TextChanged += new System.EventHandler(this.txt_HoraInicio_TextChanged);
            // 
            // btn_CrearOrden
            // 
            this.btn_CrearOrden.BackColor = System.Drawing.Color.Transparent;
            this.btn_CrearOrden.BackgroundImage = global::Presentacion.Properties.Resources.document_add21;
            this.btn_CrearOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CrearOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearOrden.Location = new System.Drawing.Point(830, 67);
            this.btn_CrearOrden.Name = "btn_CrearOrden";
            this.btn_CrearOrden.Size = new System.Drawing.Size(75, 79);
            this.btn_CrearOrden.TabIndex = 8;
            this.btn_CrearOrden.Text = "Crear Orden Examen";
            this.btn_CrearOrden.UseVisualStyleBackColor = false;
            this.btn_CrearOrden.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_FechaCreacion
            // 
            this.lbl_FechaCreacion.AutoSize = true;
            this.lbl_FechaCreacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaCreacion.Location = new System.Drawing.Point(393, 26);
            this.lbl_FechaCreacion.Name = "lbl_FechaCreacion";
            this.lbl_FechaCreacion.Size = new System.Drawing.Size(73, 13);
            this.lbl_FechaCreacion.TabIndex = 16;
            this.lbl_FechaCreacion.Text = "Fecha de Cita";
            // 
            // lbl_nroHistoria
            // 
            this.lbl_nroHistoria.AutoSize = true;
            this.lbl_nroHistoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nroHistoria.Font = new System.Drawing.Font("Eurostile", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_nroHistoria.ForeColor = System.Drawing.Color.Black;
            this.lbl_nroHistoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nroHistoria.Location = new System.Drawing.Point(675, 16);
            this.lbl_nroHistoria.Name = "lbl_nroHistoria";
            this.lbl_nroHistoria.Size = new System.Drawing.Size(81, 30);
            this.lbl_nroHistoria.TabIndex = 9;
            this.lbl_nroHistoria.Text = "0000";
            // 
            // mkTxt_FechaConsulta
            // 
            this.mkTxt_FechaConsulta.Location = new System.Drawing.Point(472, 23);
            this.mkTxt_FechaConsulta.Mask = "00/00/0000";
            this.mkTxt_FechaConsulta.Name = "mkTxt_FechaConsulta";
            this.mkTxt_FechaConsulta.Size = new System.Drawing.Size(88, 20);
            this.mkTxt_FechaConsulta.TabIndex = 15;
            this.mkTxt_FechaConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_FinConsulta
            // 
            this.lbl_FinConsulta.AutoSize = true;
            this.lbl_FinConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FinConsulta.Location = new System.Drawing.Point(534, 53);
            this.lbl_FinConsulta.Name = "lbl_FinConsulta";
            this.lbl_FinConsulta.Size = new System.Drawing.Size(65, 13);
            this.lbl_FinConsulta.TabIndex = 14;
            this.lbl_FinConsulta.Text = "Fin Consulta";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(19, 26);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(115, 13);
            this.lbl_Descripcion.TabIndex = 4;
            this.lbl_Descripcion.Text = "Detalles de la Consulta";
            // 
            // Historia
            // 
            this.Historia.AutoSize = true;
            this.Historia.BackColor = System.Drawing.Color.Transparent;
            this.Historia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Historia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Historia.Location = new System.Drawing.Point(595, 23);
            this.Historia.Name = "Historia";
            this.Historia.Size = new System.Drawing.Size(74, 16);
            this.Historia.TabIndex = 8;
            this.Historia.Text = "Historia #";
            // 
            // lbl_horaIncio
            // 
            this.lbl_horaIncio.AutoSize = true;
            this.lbl_horaIncio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_horaIncio.Location = new System.Drawing.Point(393, 54);
            this.lbl_horaIncio.Name = "lbl_horaIncio";
            this.lbl_horaIncio.Size = new System.Drawing.Size(76, 13);
            this.lbl_horaIncio.TabIndex = 12;
            this.lbl_horaIncio.Text = "Inicio Consulta";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_NombreDoctor
            // 
            this.lbl_NombreDoctor.AutoSize = true;
            this.lbl_NombreDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreDoctor.Location = new System.Drawing.Point(474, 117);
            this.lbl_NombreDoctor.Name = "lbl_NombreDoctor";
            this.lbl_NombreDoctor.Size = new System.Drawing.Size(0, 13);
            this.lbl_NombreDoctor.TabIndex = 9;
            // 
            // Lab_OdontoloNameInfo
            // 
            this.Lab_OdontoloNameInfo.AutoSize = true;
            this.Lab_OdontoloNameInfo.BackColor = System.Drawing.Color.Transparent;
            this.Lab_OdontoloNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_OdontoloNameInfo.Location = new System.Drawing.Point(392, 117);
            this.Lab_OdontoloNameInfo.Name = "Lab_OdontoloNameInfo";
            this.Lab_OdontoloNameInfo.Size = new System.Drawing.Size(76, 13);
            this.Lab_OdontoloNameInfo.TabIndex = 8;
            this.Lab_OdontoloNameInfo.Text = "Odontologo:";
            // 
            // Form_PlandeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(921, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_CrearOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PlandeTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan de Trabajo";
            this.Load += new System.EventHandler(this.Form_PlandeTrabajo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_descripciom;
        private System.Windows.Forms.CheckBox cbox_EstadoConsulta;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_nroHistoria;
        private System.Windows.Forms.Label Historia;
        private System.Windows.Forms.Label lbl_horaIncio;
        private System.Windows.Forms.Label lbl_FinConsulta;
        private System.Windows.Forms.Button btn_CrearOrden;
        private System.Windows.Forms.Label lbl_FechaCreacion;
        private System.Windows.Forms.MaskedTextBox mkTxt_FechaConsulta;
        private System.Windows.Forms.TextBox txt_HoraInicio;
        private System.Windows.Forms.TextBox txt_endHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_NombreDoctor;
        private System.Windows.Forms.Label Lab_OdontoloNameInfo;
    }
}