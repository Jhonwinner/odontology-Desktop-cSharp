namespace Presentacion
{
    partial class Form_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Test));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cod_pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuestas_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dat_Creacion = new System.Windows.Forms.DateTimePicker();
            this.Lab_FEcha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContHistoria = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.but_Nuevo = new System.Windows.Forms.Button();
            this.but_Borrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.but_bucar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Logo_espam;
            this.pictureBox1.Location = new System.Drawing.Point(507, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_pregunta,
            this.Pregunta_,
            this.Respuestas_});
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 329);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // Cod_pregunta
            // 
            this.Cod_pregunta.HeaderText = "Cod_Pregunta";
            this.Cod_pregunta.Name = "Cod_pregunta";
            this.Cod_pregunta.Visible = false;
            this.Cod_pregunta.Width = 25;
            // 
            // Pregunta_
            // 
            this.Pregunta_.HeaderText = "---  Preguntas  ---- ";
            this.Pregunta_.Name = "Pregunta_";
            this.Pregunta_.Width = 525;
            // 
            // Respuestas_
            // 
            this.Respuestas_.HeaderText = "SI o No";
            this.Respuestas_.Name = "Respuestas_";
            this.Respuestas_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Respuestas_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Respuestas_.Width = 50;
            // 
            // Dat_Creacion
            // 
            this.Dat_Creacion.Location = new System.Drawing.Point(173, 78);
            this.Dat_Creacion.Name = "Dat_Creacion";
            this.Dat_Creacion.Size = new System.Drawing.Size(200, 20);
            this.Dat_Creacion.TabIndex = 10;
            // 
            // Lab_FEcha
            // 
            this.Lab_FEcha.AutoSize = true;
            this.Lab_FEcha.BackColor = System.Drawing.Color.Transparent;
            this.Lab_FEcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_FEcha.ForeColor = System.Drawing.Color.Black;
            this.Lab_FEcha.Location = new System.Drawing.Point(8, 78);
            this.Lab_FEcha.Name = "Lab_FEcha";
            this.Lab_FEcha.Size = new System.Drawing.Size(160, 20);
            this.Lab_FEcha.TabIndex = 11;
            this.Lab_FEcha.Text = "Fecha de Creacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Test de caracteristicas del paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "N Historia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre del Paciente:";
            // 
            // ContHistoria
            // 
            this.ContHistoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContHistoria.Location = new System.Drawing.Point(102, 15);
            this.ContHistoria.Name = "ContHistoria";
            this.ContHistoria.Size = new System.Drawing.Size(122, 20);
            this.ContHistoria.TabIndex = 16;
            this.ContHistoria.TextChanged += new System.EventHandler(this.ContHistoria_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(176, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.but_Nuevo);
            this.groupBox1.Controls.Add(this.but_Borrar);
            this.groupBox1.Location = new System.Drawing.Point(9, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 70);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Herramientas de Preguntas";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Presentacion.Properties.Resources.documento_de_modificar_el_archivo_de_papel_icono_4468_96;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(110, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // but_Nuevo
            // 
            this.but_Nuevo.BackgroundImage = global::Presentacion.Properties.Resources.document_add2;
            this.but_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Nuevo.ForeColor = System.Drawing.Color.Transparent;
            this.but_Nuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_Nuevo.Location = new System.Drawing.Point(20, 20);
            this.but_Nuevo.Name = "but_Nuevo";
            this.but_Nuevo.Size = new System.Drawing.Size(40, 40);
            this.but_Nuevo.TabIndex = 21;
            this.but_Nuevo.UseVisualStyleBackColor = true;
            this.but_Nuevo.Click += new System.EventHandler(this.but_Nuevo_Click_1);
            // 
            // but_Borrar
            // 
            this.but_Borrar.BackgroundImage = global::Presentacion.Properties.Resources.erase_delete_remove_wipe_out_512;
            this.but_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Borrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_Borrar.Location = new System.Drawing.Point(66, 20);
            this.but_Borrar.Name = "but_Borrar";
            this.but_Borrar.Size = new System.Drawing.Size(38, 40);
            this.but_Borrar.TabIndex = 22;
            this.but_Borrar.UseVisualStyleBackColor = false;
            this.but_Borrar.Click += new System.EventHandler(this.but_Borrar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(180, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 70);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Herramientas de Test";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Crear un nuevo Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.save;
            this.pictureBox2.Location = new System.Drawing.Point(102, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // but_bucar
            // 
            this.but_bucar.BackgroundImage = global::Presentacion.Properties.Resources.searchhome__1_;
            this.but_bucar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_bucar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.but_bucar.Location = new System.Drawing.Point(228, 12);
            this.but_bucar.Name = "but_bucar";
            this.but_bucar.Size = new System.Drawing.Size(26, 25);
            this.but_bucar.TabIndex = 21;
            this.but_bucar.UseVisualStyleBackColor = false;
            this.but_bucar.Click += new System.EventHandler(this.but_bucar_Click);
            // 
            // Form_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(644, 575);
            this.Controls.Add(this.but_bucar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ContHistoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lab_FEcha);
            this.Controls.Add(this.Dat_Creacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Test";
            this.Text = "Ficha de Odontologia";
            this.Load += new System.EventHandler(this.Form_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Dat_Creacion;
        private System.Windows.Forms.Label Lab_FEcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Respuestas_;
        private System.Windows.Forms.TextBox ContHistoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_Nuevo;
        private System.Windows.Forms.Button but_Borrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button but_bucar;
    }
}