namespace Presentacion
{
    partial class frmDetallesConsulta
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_NombrePaciente = new System.Windows.Forms.Label();
            this.Lab_OdontoloNameInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NombreDoctor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_FEchaConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Location = new System.Drawing.Point(477, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 25);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Stomatologist;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_NombrePaciente
            // 
            this.lbl_NombrePaciente.AutoSize = true;
            this.lbl_NombrePaciente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombrePaciente.Font = new System.Drawing.Font("Buxton Sketch", 13.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NombrePaciente.Location = new System.Drawing.Point(229, 47);
            this.lbl_NombrePaciente.Name = "lbl_NombrePaciente";
            this.lbl_NombrePaciente.Size = new System.Drawing.Size(0, 23);
            this.lbl_NombrePaciente.TabIndex = 23;
            // 
            // Lab_OdontoloNameInfo
            // 
            this.Lab_OdontoloNameInfo.AutoSize = true;
            this.Lab_OdontoloNameInfo.BackColor = System.Drawing.Color.Transparent;
            this.Lab_OdontoloNameInfo.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_OdontoloNameInfo.Location = new System.Drawing.Point(147, 51);
            this.Lab_OdontoloNameInfo.Name = "Lab_OdontoloNameInfo";
            this.Lab_OdontoloNameInfo.Size = new System.Drawing.Size(70, 20);
            this.Lab_OdontoloNameInfo.TabIndex = 22;
            this.Lab_OdontoloNameInfo.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Descripcion:";
            // 
            // lbl_NombreDoctor
            // 
            this.lbl_NombreDoctor.AutoSize = true;
            this.lbl_NombreDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreDoctor.Font = new System.Drawing.Font("Buxton Sketch", 13.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreDoctor.Location = new System.Drawing.Point(191, 268);
            this.lbl_NombreDoctor.Name = "lbl_NombreDoctor";
            this.lbl_NombreDoctor.Size = new System.Drawing.Size(0, 23);
            this.lbl_NombreDoctor.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Doctor de la Atencion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha de la consulta";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Descripcion.Location = new System.Drawing.Point(234, 118);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(292, 84);
            this.txt_Descripcion.TabIndex = 25;
            this.txt_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_FEchaConsulta
            // 
            this.lbl_FEchaConsulta.AutoSize = true;
            this.lbl_FEchaConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FEchaConsulta.Font = new System.Drawing.Font("Buxton Sketch", 13.75F, System.Drawing.FontStyle.Bold);
            this.lbl_FEchaConsulta.Location = new System.Drawing.Point(238, 218);
            this.lbl_FEchaConsulta.Name = "lbl_FEchaConsulta";
            this.lbl_FEchaConsulta.Size = new System.Drawing.Size(0, 23);
            this.lbl_FEchaConsulta.TabIndex = 29;
            // 
            // frmDetallesConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(538, 318);
            this.Controls.Add(this.lbl_FEchaConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_NombreDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_NombrePaciente);
            this.Controls.Add(this.Lab_OdontoloNameInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_Descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetallesConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetallesConsulta";
            this.Load += new System.EventHandler(this.frmDetallesConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_NombrePaciente;
        private System.Windows.Forms.Label Lab_OdontoloNameInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NombreDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_FEchaConsulta;
    }
}