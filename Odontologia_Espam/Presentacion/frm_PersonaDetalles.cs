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
    public partial class frm_PersonaDetalles : Form
    {

        System.Resources.ResourceManager Recursos = new System.Resources.ResourceManager(typeof(RecursosDeFotos));
        Catalogo_Persona objt_persona = new Catalogo_Persona();
        Catalogo_Ubicacion CATA_PC = new Catalogo_Ubicacion();
        private int idPersona;
        
        public frm_PersonaDetalles()
        {
            InitializeComponent();
        }

        public frm_PersonaDetalles(int par_idPersona)
        {
            InitializeComponent();
            this.idPersona = par_idPersona;
        }

        private void frm_PersonaDetalles_Load(object sender, EventArgs e)
        {
            llenarTextBox();
            EvaluaSiesMujerOhombre();
            bloquearTextos(true);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarTextBox() {


            foreach (var item in objt_persona.Busca_PErsona_CI_Nombre_Base_Local(idPersona))
            {
                txt_Nombres.Text = item.var_Nombres;
                txt_Apellidos.Text = item.var_Apellidos;
                txt_Cedula.Text = item.var_Cedula_identidad;
                txt_Direccion.Text = item.var_Direccion;
                txt_telefono.Text = item.var_telefono;
                txt_Nacionalidad.Text = CATA_PC.NombreDePais(Convert.ToInt32(item.var_nacionalidad));
                txt_Provincias.Text = CATA_PC.NombreDeProvincia(item.var_provincia);
                txt_Canton.Text = CATA_PC.NombreDeCanton(item.var_provincia, item.var_canton);
                txt_FechaNacimiento.Text = item.var_Fecha_nacimiento.ToLongDateString(); 
                txt_Genero.Text = item.var_Genero;
                txt_Email.Text = item.var_correo;
                txt_PacienteTipo.Text = item.var_Tipo_User;
                txt_edad.Text = (DateTime.Today.Year - item.var_Fecha_nacimiento.Year).ToString();

            }

        
        }


        private void EvaluaSiesMujerOhombre() {

            if (txt_Genero.Text == "Femenino")
            {
                ptbx_imagenGenero.Image = (Image)Recursos.GetObject("Woman");
            }
            else
            {
                ptbx_imagenGenero.Image = (Image)Recursos.GetObject("man");
            }
        
        }


        private void bloquearTextos(bool estado) {


            txt_Nombres.ReadOnly = estado;
            txt_Apellidos.ReadOnly = estado;
            txt_Cedula.ReadOnly = estado;
            txt_Direccion.ReadOnly = estado;
            txt_telefono.ReadOnly = estado;
            txt_Nacionalidad.ReadOnly = estado;
            txt_Provincias.ReadOnly = estado;
            txt_Canton.ReadOnly = estado;
            txt_FechaNacimiento.ReadOnly = estado;
            txt_Genero.ReadOnly = estado;
            txt_Email.ReadOnly = estado;
            txt_PacienteTipo.ReadOnly = estado;
            txt_edad.ReadOnly = estado;
        
        
        
        }

    }
}
