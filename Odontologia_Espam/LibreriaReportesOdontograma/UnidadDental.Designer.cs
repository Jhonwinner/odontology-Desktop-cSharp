namespace OdontogramaLib
{
    partial class UnidadDental
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LunaInferior2 = new System.Windows.Forms.PictureBox();
            this.LunaSuperior2 = new System.Windows.Forms.PictureBox();
            this.LunaCentral = new System.Windows.Forms.PictureBox();
            this.LunaDerecha = new System.Windows.Forms.PictureBox();
            this.LunaIzquierda = new System.Windows.Forms.PictureBox();
            this.LunaSuperior1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LunaInferior2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaSuperior2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaIzquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaSuperior1)).BeginInit();
            this.SuspendLayout();
            // 
            // LunaInferior2
            // 
            this.LunaInferior2.BackColor = System.Drawing.Color.Transparent;
            this.LunaInferior2.Location = new System.Drawing.Point(28, 79);
            this.LunaInferior2.Name = "LunaInferior2";
            this.LunaInferior2.Size = new System.Drawing.Size(47, 27);
            this.LunaInferior2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LunaInferior2.TabIndex = 2;
            this.LunaInferior2.TabStop = false;
            this.LunaInferior2.Click += new System.EventHandler(this.LunaInferior2_Click);
            // 
            // LunaSuperior2
            // 
            this.LunaSuperior2.BackColor = System.Drawing.Color.Transparent;
            this.LunaSuperior2.Location = new System.Drawing.Point(28, 14);
            this.LunaSuperior2.Name = "LunaSuperior2";
            this.LunaSuperior2.Size = new System.Drawing.Size(47, 27);
            this.LunaSuperior2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LunaSuperior2.TabIndex = 2;
            this.LunaSuperior2.TabStop = false;
            this.LunaSuperior2.Click += new System.EventHandler(this.LunaSuperior2_Click);
            // 
            // LunaCentral
            // 
            this.LunaCentral.BackColor = System.Drawing.Color.Transparent;
            this.LunaCentral.Location = new System.Drawing.Point(34, 43);
            this.LunaCentral.Name = "LunaCentral";
            this.LunaCentral.Size = new System.Drawing.Size(36, 36);
            this.LunaCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LunaCentral.TabIndex = 1;
            this.LunaCentral.TabStop = false;
            this.LunaCentral.Click += new System.EventHandler(this.LunaCentral_Click);
            // 
            // LunaDerecha
            // 
            this.LunaDerecha.BackColor = System.Drawing.Color.Transparent;
            this.LunaDerecha.Location = new System.Drawing.Point(70, 38);
            this.LunaDerecha.Name = "LunaDerecha";
            this.LunaDerecha.Size = new System.Drawing.Size(25, 44);
            this.LunaDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LunaDerecha.TabIndex = 1;
            this.LunaDerecha.TabStop = false;
            this.LunaDerecha.Click += new System.EventHandler(this.LunaDerecha_Click);
            // 
            // LunaIzquierda
            // 
            this.LunaIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.LunaIzquierda.Location = new System.Drawing.Point(8, 38);
            this.LunaIzquierda.Name = "LunaIzquierda";
            this.LunaIzquierda.Size = new System.Drawing.Size(25, 44);
            this.LunaIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LunaIzquierda.TabIndex = 1;
            this.LunaIzquierda.TabStop = false;
            this.LunaIzquierda.Click += new System.EventHandler(this.LunaIzquierda_Click);
            // 
            // LunaSuperior1
            // 
            this.LunaSuperior1.BackColor = System.Drawing.Color.Transparent;
            this.LunaSuperior1.Location = new System.Drawing.Point(13, 112);
            this.LunaSuperior1.Name = "LunaSuperior1";
            this.LunaSuperior1.Size = new System.Drawing.Size(74, 72);
            this.LunaSuperior1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LunaSuperior1.TabIndex = 1;
            this.LunaSuperior1.TabStop = false;
            this.LunaSuperior1.Click += new System.EventHandler(this.LunaSuperior1_Click);
            // 
            // UnidadDental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LunaCentral);
            this.Controls.Add(this.LunaInferior2);
            this.Controls.Add(this.LunaSuperior2);
            this.Controls.Add(this.LunaDerecha);
            this.Controls.Add(this.LunaIzquierda);
            this.Controls.Add(this.LunaSuperior1);
            this.DoubleBuffered = true;
            this.Name = "UnidadDental";
            this.Size = new System.Drawing.Size(107, 187);
            this.Load += new System.EventHandler(this.UnidadDental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LunaInferior2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaSuperior2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaIzquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LunaSuperior1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LunaSuperior2;
        private System.Windows.Forms.PictureBox LunaSuperior1;
        private System.Windows.Forms.PictureBox LunaIzquierda;
        private System.Windows.Forms.PictureBox LunaInferior2;
        private System.Windows.Forms.PictureBox LunaDerecha;
        private System.Windows.Forms.PictureBox LunaCentral;
    }
}
