namespace Presentacion
{
    partial class Form_Crea_Preguntas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lab_Nhistory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 40);
            this.textBox1.TabIndex = 0;
            // 
            // Lab_Nhistory
            // 
            this.Lab_Nhistory.AutoSize = true;
            this.Lab_Nhistory.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Nhistory.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.Lab_Nhistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lab_Nhistory.Location = new System.Drawing.Point(26, 17);
            this.Lab_Nhistory.Name = "Lab_Nhistory";
            this.Lab_Nhistory.Size = new System.Drawing.Size(176, 36);
            this.Lab_Nhistory.TabIndex = 12;
            this.Lab_Nhistory.Text = "Por favor ingrese su \r\nnueva Pregunta:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(769, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Crea_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(913, 72);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lab_Nhistory);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Crea_Preguntas";
            this.Text = "Crea_Preguntas";
            this.Load += new System.EventHandler(this.Form_Crea_Preguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lab_Nhistory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}