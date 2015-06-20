namespace Presentacion
{
    partial class frm_CrudLogin
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
            this.txt_PassActual = new System.Windows.Forms.TextBox();
            this.txt_PassNueva = new System.Windows.Forms.TextBox();
            this.txt_PassConfirmacion = new System.Windows.Forms.TextBox();
            this.Lab_OdontoloNameInfo = new System.Windows.Forms.Label();
            this.lbl_NombreDoctor = new System.Windows.Forms.Label();
            this.lab_Pass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PassActual
            // 
            this.txt_PassActual.Location = new System.Drawing.Point(236, 57);
            this.txt_PassActual.Multiline = true;
            this.txt_PassActual.Name = "txt_PassActual";
            this.txt_PassActual.PasswordChar = '*';
            this.txt_PassActual.Size = new System.Drawing.Size(142, 24);
            this.txt_PassActual.TabIndex = 0;
            // 
            // txt_PassNueva
            // 
            this.txt_PassNueva.Location = new System.Drawing.Point(236, 87);
            this.txt_PassNueva.Multiline = true;
            this.txt_PassNueva.Name = "txt_PassNueva";
            this.txt_PassNueva.PasswordChar = '*';
            this.txt_PassNueva.Size = new System.Drawing.Size(142, 24);
            this.txt_PassNueva.TabIndex = 1;
            // 
            // txt_PassConfirmacion
            // 
            this.txt_PassConfirmacion.Location = new System.Drawing.Point(236, 117);
            this.txt_PassConfirmacion.Multiline = true;
            this.txt_PassConfirmacion.Name = "txt_PassConfirmacion";
            this.txt_PassConfirmacion.PasswordChar = '*';
            this.txt_PassConfirmacion.Size = new System.Drawing.Size(142, 24);
            this.txt_PassConfirmacion.TabIndex = 2;
            // 
            // Lab_OdontoloNameInfo
            // 
            this.Lab_OdontoloNameInfo.AutoSize = true;
            this.Lab_OdontoloNameInfo.BackColor = System.Drawing.Color.Transparent;
            this.Lab_OdontoloNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_OdontoloNameInfo.Location = new System.Drawing.Point(9, 11);
            this.Lab_OdontoloNameInfo.Name = "Lab_OdontoloNameInfo";
            this.Lab_OdontoloNameInfo.Size = new System.Drawing.Size(76, 13);
            this.Lab_OdontoloNameInfo.TabIndex = 3;
            this.Lab_OdontoloNameInfo.Text = "Odontologo:";
            // 
            // lbl_NombreDoctor
            // 
            this.lbl_NombreDoctor.AutoSize = true;
            this.lbl_NombreDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreDoctor.Location = new System.Drawing.Point(91, 11);
            this.lbl_NombreDoctor.Name = "lbl_NombreDoctor";
            this.lbl_NombreDoctor.Size = new System.Drawing.Size(0, 13);
            this.lbl_NombreDoctor.TabIndex = 4;
            // 
            // lab_Pass
            // 
            this.lab_Pass.AutoSize = true;
            this.lab_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lab_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Pass.Location = new System.Drawing.Point(89, 61);
            this.lab_Pass.Name = "lab_Pass";
            this.lab_Pass.Size = new System.Drawing.Size(138, 16);
            this.lab_Pass.TabIndex = 5;
            this.lab_Pass.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar Contrase:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Lock;
            this.pictureBox1.Location = new System.Drawing.Point(-39, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Location = new System.Drawing.Point(302, 147);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 28);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Location = new System.Drawing.Point(208, 147);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 28);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // frm_CrudLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(395, 183);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Pass);
            this.Controls.Add(this.lbl_NombreDoctor);
            this.Controls.Add(this.Lab_OdontoloNameInfo);
            this.Controls.Add(this.txt_PassConfirmacion);
            this.Controls.Add(this.txt_PassNueva);
            this.Controls.Add(this.txt_PassActual);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CrudLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Pass";
            this.Load += new System.EventHandler(this.frm_CrudLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PassActual;
        private System.Windows.Forms.TextBox txt_PassNueva;
        private System.Windows.Forms.TextBox txt_PassConfirmacion;
        private System.Windows.Forms.Label Lab_OdontoloNameInfo;
        private System.Windows.Forms.Label lbl_NombreDoctor;
        private System.Windows.Forms.Label lab_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Guardar;
    }
}