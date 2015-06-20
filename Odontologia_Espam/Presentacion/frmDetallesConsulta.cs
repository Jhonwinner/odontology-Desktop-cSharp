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
    public partial class frmDetallesConsulta : Form
    {


        Catalogo_Historia objtHistoria = new Catalogo_Historia();
        Catalogo_Usuario use = new Catalogo_Usuario();

        int idHistoria;
        int idConsulta; 
       

        public frmDetallesConsulta(int par_IdHistoria, int par_IdConsulta, string NombrePaciente)
        {
            InitializeComponent();
            this.idHistoria = par_IdHistoria;
            this.idConsulta = par_IdConsulta;
            lbl_NombrePaciente.Text = NombrePaciente;
        }

        private void frmDetallesConsulta_Load(object sender, EventArgs e)
        {
            generarDatos();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generarDatos() {

            foreach (var item in objtHistoria.ConsultarLasConsultaEspecifica(idHistoria, idConsulta))
            {
                txt_Descripcion.Text = item.Detalles_Consulta;
                lbl_NombreDoctor.Text = objtHistoria.NombreDoctorIdDoctor(item.idUsuario);
                lbl_FEchaConsulta.Text = item.FechaHoraInicio.ToShortDateString() ;
            }
            txt_Descripcion.ReadOnly = true;        
        
        }


    }
}
