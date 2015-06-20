namespace Presentacion
{
    partial class Administra_Odontologo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administra_Odontologo));
            this.GRoup = new System.Windows.Forms.GroupBox();
            this.RB_N_History = new System.Windows.Forms.RadioButton();
            this.rb_CI = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Cont_Buscar = new System.Windows.Forms.TextBox();
            this.DG_persona = new System.Windows.Forms.DataGridView();
            this.Cod_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GRoup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GRoup
            // 
            this.GRoup.BackColor = System.Drawing.Color.Transparent;
            this.GRoup.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.GRoup.Controls.Add(this.RB_N_History);
            this.GRoup.Controls.Add(this.rb_CI);
            this.GRoup.Controls.Add(this.label2);
            this.GRoup.Controls.Add(this.Cont_Buscar);
            this.GRoup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRoup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GRoup.Location = new System.Drawing.Point(12, 12);
            this.GRoup.Name = "GRoup";
            this.GRoup.Size = new System.Drawing.Size(277, 111);
            this.GRoup.TabIndex = 25;
            this.GRoup.TabStop = false;
            this.GRoup.Text = "Herramienta de Busqueda";
            this.GRoup.Enter += new System.EventHandler(this.GRoup_Enter);
            // 
            // RB_N_History
            // 
            this.RB_N_History.AutoSize = true;
            this.RB_N_History.BackColor = System.Drawing.Color.Transparent;
            this.RB_N_History.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_N_History.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RB_N_History.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RB_N_History.Location = new System.Drawing.Point(87, 71);
            this.RB_N_History.Name = "RB_N_History";
            this.RB_N_History.Size = new System.Drawing.Size(77, 19);
            this.RB_N_History.TabIndex = 28;
            this.RB_N_History.TabStop = true;
            this.RB_N_History.Text = "Nombres";
            this.RB_N_History.UseVisualStyleBackColor = false;
            // 
            // rb_CI
            // 
            this.rb_CI.AutoSize = true;
            this.rb_CI.BackColor = System.Drawing.Color.Transparent;
            this.rb_CI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_CI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_CI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_CI.Location = new System.Drawing.Point(46, 70);
            this.rb_CI.Name = "rb_CI";
            this.rb_CI.Size = new System.Drawing.Size(37, 19);
            this.rb_CI.TabIndex = 27;
            this.rb_CI.TabStop = true;
            this.rb_CI.Text = "CI";
            this.rb_CI.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar por:";
            // 
            // Cont_Buscar
            // 
            this.Cont_Buscar.Location = new System.Drawing.Point(20, 43);
            this.Cont_Buscar.Multiline = true;
            this.Cont_Buscar.Name = "Cont_Buscar";
            this.Cont_Buscar.Size = new System.Drawing.Size(222, 26);
            this.Cont_Buscar.TabIndex = 25;
            this.Cont_Buscar.TextChanged += new System.EventHandler(this.Cont_Buscar_TextChanged);
            // 
            // DG_persona
            // 
            this.DG_persona.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DG_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_persona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Persona,
            this.CI,
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Telefono,
            this.Correo});
            this.DG_persona.Location = new System.Drawing.Point(12, 142);
            this.DG_persona.Name = "DG_persona";
            this.DG_persona.Size = new System.Drawing.Size(1005, 252);
            this.DG_persona.TabIndex = 26;
            this.DG_persona.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_persona_CellClick);
            this.DG_persona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_persona_CellContentClick);
            // 
            // Cod_Persona
            // 
            this.Cod_Persona.HeaderText = "Cod Pers";
            this.Cod_Persona.Name = "Cod_Persona";
            this.Cod_Persona.Visible = false;
            // 
            // CI
            // 
            this.CI.HeaderText = "Cedula Identidad";
            this.CI.Name = "CI";
            this.CI.Width = 150;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(901, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 56);
            this.label1.TabIndex = 28;
            this.label1.Text = "Busqueda Avanzada";
            // 
            // Administra_Odontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1036, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DG_persona);
            this.Controls.Add(this.GRoup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administra_Odontologo";
            this.Text = "Buscar alumnos de la Universidad ";
            this.Load += new System.EventHandler(this.Administra_Odontologo_Load);
            this.GRoup.ResumeLayout(false);
            this.GRoup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRoup;
        private System.Windows.Forms.RadioButton RB_N_History;
        private System.Windows.Forms.RadioButton rb_CI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cont_Buscar;
        private System.Windows.Forms.DataGridView DG_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}