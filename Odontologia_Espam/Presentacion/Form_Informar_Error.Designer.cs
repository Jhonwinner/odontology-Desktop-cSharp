namespace Presentacion
{
    partial class Form_Informar_Error
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LAb_Fecha = new System.Windows.Forms.Label();
            this.Lab_Hora = new System.Windows.Forms.Label();
            this.lab_Odontologo = new System.Windows.Forms.Label();
            this.Timer_Error = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 187);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar error";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LAb_Fecha
            // 
            this.LAb_Fecha.AutoSize = true;
            this.LAb_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.LAb_Fecha.Location = new System.Drawing.Point(28, 9);
            this.LAb_Fecha.Name = "LAb_Fecha";
            this.LAb_Fecha.Size = new System.Drawing.Size(35, 13);
            this.LAb_Fecha.TabIndex = 2;
            this.LAb_Fecha.Text = "label1";
            // 
            // Lab_Hora
            // 
            this.Lab_Hora.AutoSize = true;
            this.Lab_Hora.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Hora.Location = new System.Drawing.Point(130, 9);
            this.Lab_Hora.Name = "Lab_Hora";
            this.Lab_Hora.Size = new System.Drawing.Size(35, 13);
            this.Lab_Hora.TabIndex = 3;
            this.Lab_Hora.Text = "label1";
            // 
            // lab_Odontologo
            // 
            this.lab_Odontologo.AutoSize = true;
            this.lab_Odontologo.BackColor = System.Drawing.Color.Transparent;
            this.lab_Odontologo.Location = new System.Drawing.Point(28, 46);
            this.lab_Odontologo.Name = "lab_Odontologo";
            this.lab_Odontologo.Size = new System.Drawing.Size(35, 13);
            this.lab_Odontologo.TabIndex = 4;
            this.lab_Odontologo.Text = "label1";
            // 
            // Timer_Error
            // 
            this.Timer_Error.Enabled = true;
            this.Timer_Error.Tick += new System.EventHandler(this.Timer_Error_Tick);
            // 
            // Form_Informar_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(300, 274);
            this.Controls.Add(this.lab_Odontologo);
            this.Controls.Add(this.Lab_Hora);
            this.Controls.Add(this.LAb_Fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Informar_Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Errores  de la Aplicacion";
            this.Load += new System.EventHandler(this.Form_Informar_Error_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LAb_Fecha;
        private System.Windows.Forms.Label Lab_Hora;
        private System.Windows.Forms.Label lab_Odontologo;
        private System.Windows.Forms.Timer Timer_Error;
    }
}