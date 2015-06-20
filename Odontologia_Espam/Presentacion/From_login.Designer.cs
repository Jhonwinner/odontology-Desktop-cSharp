namespace Presentacion
{
    partial class For_Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(For_Login));
            this.Bot_Ingresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_Pass = new System.Windows.Forms.Label();
            this.bot_Salir = new System.Windows.Forms.Button();
            this.lab_user = new System.Windows.Forms.Label();
            this.Cont_Contrase = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bot_Ingresar
            // 
            this.Bot_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bot_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot_Ingresar.Location = new System.Drawing.Point(20, 122);
            this.Bot_Ingresar.Name = "Bot_Ingresar";
            this.Bot_Ingresar.Size = new System.Drawing.Size(72, 24);
            this.Bot_Ingresar.TabIndex = 1;
            this.Bot_Ingresar.Text = "Aceptar";
            this.Bot_Ingresar.UseMnemonic = false;
            this.Bot_Ingresar.UseVisualStyleBackColor = true;
            this.Bot_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lab_Pass);
            this.groupBox1.Controls.Add(this.bot_Salir);
            this.groupBox1.Controls.Add(this.lab_user);
            this.groupBox1.Controls.Add(this.Bot_Ingresar);
            this.groupBox1.Controls.Add(this.Cont_Contrase);
            this.groupBox1.Controls.Add(this.txt_Usuario);
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 203);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Odontologia ESPAM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Stomatologist;
            this.pictureBox1.Location = new System.Drawing.Point(243, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lab_Pass
            // 
            this.lab_Pass.AutoSize = true;
            this.lab_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lab_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Pass.Location = new System.Drawing.Point(17, 69);
            this.lab_Pass.Name = "lab_Pass";
            this.lab_Pass.Size = new System.Drawing.Size(91, 16);
            this.lab_Pass.TabIndex = 4;
            this.lab_Pass.Text = "Contraseña:";
            // 
            // bot_Salir
            // 
            this.bot_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bot_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bot_Salir.Location = new System.Drawing.Point(110, 122);
            this.bot_Salir.Name = "bot_Salir";
            this.bot_Salir.Size = new System.Drawing.Size(74, 24);
            this.bot_Salir.TabIndex = 1;
            this.bot_Salir.Text = "Salir";
            this.bot_Salir.UseMnemonic = false;
            this.bot_Salir.UseVisualStyleBackColor = true;
            this.bot_Salir.Click += new System.EventHandler(this.bot_Salir_Click);
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.BackColor = System.Drawing.Color.Transparent;
            this.lab_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_user.Location = new System.Drawing.Point(17, 25);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(66, 16);
            this.lab_user.TabIndex = 3;
            this.lab_user.Text = "Usuario:";
            // 
            // Cont_Contrase
            // 
            this.Cont_Contrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cont_Contrase.Location = new System.Drawing.Point(20, 88);
            this.Cont_Contrase.Multiline = true;
            this.Cont_Contrase.Name = "Cont_Contrase";
            this.Cont_Contrase.PasswordChar = '*';
            this.Cont_Contrase.Size = new System.Drawing.Size(164, 22);
            this.Cont_Contrase.TabIndex = 2;
            this.Cont_Contrase.TabStop = false;
            this.Cont_Contrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cont_Contrase.TextChanged += new System.EventHandler(this.Cont_Contrase_TextChanged);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Usuario.Location = new System.Drawing.Point(20, 44);
            this.txt_Usuario.Multiline = true;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(164, 22);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.TabStop = false;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // For_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(430, 220);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "For_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.Load += new System.EventHandler(this.For_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bot_Ingresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bot_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_Pass;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.TextBox Cont_Contrase;
        private System.Windows.Forms.TextBox txt_Usuario;

    }
}

