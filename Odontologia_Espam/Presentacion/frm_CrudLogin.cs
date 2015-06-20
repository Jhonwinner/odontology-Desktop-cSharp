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
    public partial class frm_CrudLogin : Form
    {
        private int idSesion;
        Catalogo_Usuario obj_Usuario = new Catalogo_Usuario();

        public frm_CrudLogin()
        {
            InitializeComponent();
        }

        public frm_CrudLogin(int par_idSesion)
        {
            InitializeComponent();
            this.idSesion = par_idSesion; 
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CrudLogin_Load(object sender, EventArgs e)
        {
            lbl_NombreDoctor.Text = obj_Usuario.Funt_Retorna_NOmbre_Inicia_Sesion(idSesion);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_PassNueva.Text == txt_PassConfirmacion.Text)
                {
                    MessageBox.Show(obj_Usuario.ModficarContraseania(idSesion,txt_PassActual.Text , txt_PassNueva.Text),"Error");
                    txt_PassActual.Clear();
                    txt_PassConfirmacion.Clear();
                    txt_PassNueva.Clear();
                }
                else { MessageBox.Show("Contraseñas Nuevas No coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception)
            {
            }
        }



    }
}
