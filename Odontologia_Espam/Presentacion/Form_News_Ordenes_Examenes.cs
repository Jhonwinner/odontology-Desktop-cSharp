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
    public partial class Form_News_Ordenes_Examenes : Form
    {
        private int id_His { set; get;}
        private int id_Cons { set; get; }
        Catalogo_Persona persona = new Catalogo_Persona();
        private string Date_recepcion= null;
        private bool sa_UP {set;get;}

        public Form_News_Ordenes_Examenes()
        {
            InitializeComponent();
            comboBox1.Text = "No Entregado";
            sa_UP = false;
        }

        public Form_News_Ordenes_Examenes(int id_Cons_,int id_Hist_)
        {
            InitializeComponent();
            this.id_His  = id_Hist_;
            this.id_Cons = id_Cons_;
            sa_UP = true;
            inserta_text_Actualiza();
            
        }


        private void Form_News_Ordenes_Examenes_Load(object sender, EventArgs e)
        {
            DT_Recep.Visible = false;
            Resultados.Visible = false;
            validacion_de_estado();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }

        private void validacion_de_estado() {

            if (comboBox1.Text == "Entregado")
            {
                DT_Recep.Visible = true;
                Resultados.Visible = true;
                Date_recepcion = DT_Recep.Value.ToShortDateString();
            }
            else
            {
                DT_Recep.Visible = false;
                Resultados.Visible = false;
            } 
        }

        private void but_Guardar_Click(object sender, EventArgs e)
        {
            valida_save_or_update();       
                         
        }

        private void evento_save()
        {
            if (sa_UP == false)
            {
                persona.INGRESAR_ORdEN_CLinica(new Ordenes_Examen(Convert.ToDateTime(DT_Envio.Value.ToShortDateString()), Convert.ToDateTime(Date_recepcion), comboBox1.Text.ToString(), Caract.Text, Resultados.Text, 3, 2));
                MessageBox.Show("Sus Datos han sido Guardados\n Correctamente", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {

                persona.Modificar_orden(new Ordenes_Examen(Convert.ToDateTime(DT_Envio.Value.ToShortDateString()), Convert.ToDateTime(Date_recepcion), comboBox1.Text.ToString(), Caract.Text, Resultados.Text,Convert.ToInt16(id_His),Convert.ToInt16(id_Cons)));
                MessageBox.Show("Sus Datos han sido Actualizados\n Correctamente", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
           

        }

        private void DT_Envio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            validacion_de_estado();
        }

        private void inserta_text_Actualiza()
        {
            foreach (var item in persona.Consultar_Para_Saber_Que_ACtualizar(new Ordenes_Examen(Convert.ToInt32(id_His),Convert.ToInt32(id_Cons))))
            {
                Lab_Num_his.Text = item.Id_historia.ToString();
                lab_NumCo.Text = item.Id_Consulta.ToString();
                comboBox1.Text = item.status;
                Caract.Text = item.Descp_Exam;
                Resultados.Text = item.Resultad;
                DT_Envio.Value = item.Fecha_de_Envio;
 
            }
        }

        private bool chekea_text() {

            bool estado = false;

            if (string.IsNullOrWhiteSpace(Caract.Text) || (string.IsNullOrWhiteSpace(Resultados.Text) && Resultados.Visible == true))
            {
                estado = true;
            }

            return estado;
        
        }



        private void valida_save_or_update() {

            if (sa_UP == true)
            {
                if (chekea_text() == true)
                {
                    MessageBox.Show("Nesecita Escribir Algo de Informacion\nEn el Cuadro de Descripcion\no resultados", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    evento_save();
                    Caract.Clear();
                    Resultados.Clear();
                    this.Close();
                }
            }
            else
            {
                if (chekea_text() == true)
                {
                    MessageBox.Show("Nesecita Escribir Algo de Informacion\nEn el Cuadro de Descripcion\no resultados", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    evento_save();
                    Caract.Clear();
                    Resultados.Clear();
                    this.Close();
                }

            }
        
        }


    }
}
