namespace Presentacion
{
    partial class Form_News_Ordenes_Examenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_News_Ordenes_Examenes));
            this.but_Guardar = new System.Windows.Forms.Button();
            this.DT_Envio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Recep = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Caract = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lab_Num_his = new System.Windows.Forms.Label();
            this.lab_NumCo = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Guardar
            // 
            this.but_Guardar.BackgroundImage = global::Presentacion.Properties.Resources.save;
            this.but_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Guardar.ForeColor = System.Drawing.Color.Transparent;
            this.but_Guardar.Location = new System.Drawing.Point(24, 74);
            this.but_Guardar.Name = "but_Guardar";
            this.but_Guardar.Size = new System.Drawing.Size(75, 68);
            this.but_Guardar.TabIndex = 1;
            this.but_Guardar.UseVisualStyleBackColor = true;
            this.but_Guardar.Click += new System.EventHandler(this.but_Guardar_Click);
            // 
            // DT_Envio
            // 
            this.DT_Envio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Envio.Location = new System.Drawing.Point(301, 49);
            this.DT_Envio.Name = "DT_Envio";
            this.DT_Envio.Size = new System.Drawing.Size(100, 20);
            this.DT_Envio.TabIndex = 2;
            this.DT_Envio.Value = new System.DateTime(2013, 9, 29, 3, 23, 11, 0);
            this.DT_Envio.ValueChanged += new System.EventHandler(this.DT_Envio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Envio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Recepcion:";
            // 
            // DT_Recep
            // 
            this.DT_Recep.Checked = false;
            this.DT_Recep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Recep.Location = new System.Drawing.Point(342, 87);
            this.DT_Recep.MinDate = new System.DateTime(1899, 12, 26, 0, 0, 0, 0);
            this.DT_Recep.Name = "DT_Recep";
            this.DT_Recep.Size = new System.Drawing.Size(100, 20);
            this.DT_Recep.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entregado",
            "Sin Entregar"});
            this.comboBox1.Location = new System.Drawing.Point(215, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Caract
            // 
            this.Caract.Location = new System.Drawing.Point(48, 239);
            this.Caract.Multiline = true;
            this.Caract.Name = "Caract";
            this.Caract.Size = new System.Drawing.Size(187, 222);
            this.Caract.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Resultados);
            this.groupBox1.Location = new System.Drawing.Point(24, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 293);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(245, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "  Resultados\r\n  del examen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 32);
            this.label10.TabIndex = 17;
            this.label10.Text = "Caracteristicas\r\n  del Examen";
            // 
            // Resultados
            // 
            this.Resultados.Location = new System.Drawing.Point(226, 55);
            this.Resultados.Multiline = true;
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(187, 222);
            this.Resultados.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "N Historia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "N Consulta:";
            // 
            // Lab_Num_his
            // 
            this.Lab_Num_his.AutoSize = true;
            this.Lab_Num_his.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Num_his.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Num_his.Location = new System.Drawing.Point(138, 10);
            this.Lab_Num_his.Name = "Lab_Num_his";
            this.Lab_Num_his.Size = new System.Drawing.Size(0, 16);
            this.Lab_Num_his.TabIndex = 14;
            // 
            // lab_NumCo
            // 
            this.lab_NumCo.AutoSize = true;
            this.lab_NumCo.BackColor = System.Drawing.Color.Transparent;
            this.lab_NumCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_NumCo.Location = new System.Drawing.Point(365, 9);
            this.lab_NumCo.Name = "lab_NumCo";
            this.lab_NumCo.Size = new System.Drawing.Size(0, 16);
            this.lab_NumCo.TabIndex = 15;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Presentacion.Properties.Resources.imprimir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(396, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_News_Ordenes_Examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(477, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_NumCo);
            this.Controls.Add(this.Lab_Num_his);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Caract);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DT_Recep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_Envio);
            this.Controls.Add(this.but_Guardar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_News_Ordenes_Examenes";
            this.Opacity = 0.9D;
            this.Text = "Ordenes  de Examen";
            this.Load += new System.EventHandler(this.Form_News_Ordenes_Examenes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Guardar;
        private System.Windows.Forms.DateTimePicker DT_Envio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Caract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lab_Num_his;
        private System.Windows.Forms.Label lab_NumCo;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DT_Recep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Resultados;
    }
}