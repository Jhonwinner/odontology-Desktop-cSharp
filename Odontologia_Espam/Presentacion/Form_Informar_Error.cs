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
    public partial class Form_Informar_Error : Form
    {
        private int User_id; // Variable que se carga en el construtor para tener el id del Usuario 

        #region Constructores
        public Form_Informar_Error(int user_id_other)
        {
            InitializeComponent();
            this.User_id = user_id_other;
        }

        #endregion 

        #region Carga Grafica del formulario Evento Load 
        private void Form_Informar_Error_Load(object sender, EventArgs e)
        { 
            Catalogo_Usuario obj_Usuario = new Catalogo_Usuario();
            lab_Odontologo.Text = "Reporta : " + obj_Usuario.Funt_Retorna_NOmbre_Inicia_Sesion(User_id);
        }
        #endregion 

        #region Controles de timer 
        private void Timer_Error_Tick(object sender, EventArgs e)
        {
            LAb_Fecha.Text = DateTime.Now.ToShortDateString();
            Lab_Hora.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion 

        #region Evento Click del Boton guardar
        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo_Usuario obj_Usuario = new Catalogo_Usuario();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Nesecita Escribir Algo de Informacion", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            
            }
            else
            {
                obj_Usuario.Fun_Ingresar_Error(new Reporta_Error(User_id, textBox1.Text));
                MessageBox.Show("Mensaje Enviado Correctamente", "Status : Enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Clear();

             }


        }
        #endregion 

    }
}
