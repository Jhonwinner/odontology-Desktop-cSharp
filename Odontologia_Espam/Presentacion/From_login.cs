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
    public partial class For_Login : Form
    {
        #region Constructor 
        public For_Login()
        {
            InitializeComponent();

        }
        #endregion 
                
        #region Boton Aceptar Click 
        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo_Usuario objt_Usuario = new Catalogo_Usuario(); // Objeto de La clase Catalogo Usuario Contenedora de los metodos del crud y algunas funciones

            int id;



            if (objt_Usuario.ValidarLogin(txt_Usuario.Text, Cont_Contrase.Text) == true)
            {
                id = objt_Usuario.Funt_retorna_ID(new Usuario(txt_Usuario.Text, Cont_Contrase.Text));
                objt_Usuario.InsertaLogSesion(id);
                Form form_master = new Form_Master(id);
                Cont_Contrase.Clear();
                txt_Usuario.Clear();
                this.Hide();
                form_master.ShowDialog(this);
                this.Show();
               
                
            }

            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cont_Contrase.Clear();
                txt_Usuario.Clear();
            }

         
            
        }

        #endregion 

        #region Boton Salir
        private void bot_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region Load Formaulario 
        private void For_Login_Load(object sender, EventArgs e)
        {
             
             txt_Usuario.Focus();
             Properties.Settings.Default.User = "0";        
        }
        #endregion 

        #region Eventos de Controles del lo elementos del Formulario 
        private void Cont_Contrase_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = Bot_Ingresar;    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txt_Usuario.Focus();
        }
        #endregion 
        
    }
}