using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace Presentacion
{
    public partial class Form_Crea_Preguntas : Form
    {
        int Cod_pregrunta { set; get; }
        string  pregrunta { set; get; }
        int tipo { set; get; }
        bool estado = false;

        public Form_Crea_Preguntas()
        {
            InitializeComponent();
            textBox1.Clear();
        }
       
        public Form_Crea_Preguntas(int id_Pre,string Quest,int tipo_)
        {
            InitializeComponent();
            this.Cod_pregrunta = id_Pre;
            this.pregrunta = Quest;
            this.tipo = tipo_;
            estado = true;

        }

        public Form_Crea_Preguntas(int Tipos)
        {
            InitializeComponent();
            this.tipo = Tipos;
         
        }



        Catalogo_Test Test = new Catalogo_Test();
        private int Var;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length < 20)
            {
                MessageBox.Show("Nesecita Escribir Al menos 20 palabras", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {

                if (estado == true)
                {
                    eventos_update();
                }
                else
                {
                    eventos_insert();
                }
            }
      
        
        }

        private void eventos_insert() {
           
            Var = Test.Insertar_Preguntas(new Preguntas(0, textBox1.Text,tipo));
            textBox1.Clear();
            this.Close();        
        }

        private void eventos_update()
        {

            Test.modifica_pregunta(new Preguntas(Cod_pregrunta, textBox1.Text,tipo));
            textBox1.Clear();
            this.Close(); 
        }

        private void Form_Crea_Preguntas_Load(object sender, EventArgs e)
        {
            textBox1.Text = pregrunta;
        }
    }
}
