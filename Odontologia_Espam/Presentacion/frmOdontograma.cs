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
    public partial class frmOdontograma : Form
    {
        Catalogo_Persona obtpersona = new Catalogo_Persona();
        catalogoOdontograma obtOdontograma = new catalogoOdontograma();
       
        
        int loc_idPersona;
        int IdOdontograma;
        int IdDoctor;

        public frmOdontograma()
        {
            InitializeComponent();
        }

        public frmOdontograma(int idPersona, int parIdDoctor)
        {
            InitializeComponent();
            this.loc_idPersona = idPersona;
            this.IdDoctor = parIdDoctor; 
        }



        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOdontograma_Load(object sender, EventArgs e)
        {
            lbl_NombrePaciente.Text = obtpersona.NombreDelPAciente(loc_idPersona);
            ExisteONoRegistradoOdontograma(); 

       }

        public void VisvilidadDeobjetos(bool estado) {

            dientesTotales1.Visible = estado;
            groupBox1.Visible = estado;
            groupBox2.Visible = estado;
            OdontogramaPrimeraVez.Visible = estado;
            lbl_primeraConsulta.Visible = estado;
            lbl_procesosOdontograma.Visible = estado; 
        }


        private void ExisteONoRegistradoOdontograma()
        {
            if (obtOdontograma.ExisteOdontograma(loc_idPersona)==true)
            {
               btn_crearOdontogra.Text = "Odontograma";
               VisvilidadDeobjetos(true);
               IdOdontograma = obtOdontograma.idOdontogramaXPErsona(loc_idPersona);
               cargarLosUltimosDatosDentales();
               cargarlosDatosdelaprimeraCita();
            }
            else
            {
                VisvilidadDeobjetos(false);
                btn_crearOdontogra.Text = "Crear Odontograma";

            }
        }


        private void CargarDiente(int par_NumeroDiente) {
           
            frmDiente obt_Diente = new frmDiente(IdOdontograma,par_NumeroDiente,IdDoctor);
            obt_Diente.ShowDialog();
            cargarLosUltimosDatosDentales();
            cargarlosDatosdelaprimeraCita();
                  
        }


 public void cargarLosUltimosDatosDentales() {

            string loc_String = "";
            int loc_var = 0; 

            foreach (var item in obtOdontograma.ConsultarOdontgramaDiente(IdOdontograma))
            {
               
                foreach (var alfa in obtOdontograma.ConsultarOdontgramaDienteProcedimientoUltimaFecha(IdOdontograma, item.IdCodDiente))
                {
                    loc_String = alfa.EstadoLunaCentral.ToString() + alfa.EstadoLunaSuperior.ToString()
                        + alfa.EstadoLunaInferior.ToString() + alfa.EstadoLunaIzquierda.ToString()
                        + alfa.EstadoLunaDerecha.ToString();
                    EvaluarDienteCod(item.IdCodDiente, int.Parse(loc_String));
                    loc_var++;
                }


                if (loc_var == 0 )
                {
                    EvaluarDienteCod(item.IdCodDiente, 11111);
                }

            }
         
        }


 public void cargarlosDatosdelaprimeraCita()
 {

     string loc_String = "";


     foreach (var item in obtOdontograma.ConsultarOdontgramaDiente(IdOdontograma))
     {

         foreach (var alfa in obtOdontograma.ConsultarEstadoDientePRimeraVez(IdOdontograma, item.IdCodDiente))
         {
             loc_String = alfa.EstadoLunaCentral.ToString() + alfa.EstadoLunaSuperior.ToString()
                 + alfa.EstadoLunaInferior.ToString() + alfa.EstadoLunaIzquierda.ToString()
                 + alfa.EstadoLunaDerecha.ToString();
             EstadoDelaPrimeraCita(item.IdCodDiente, int.Parse(loc_String));
     
         }


     }

 }

        #region Click en los Dientes 
        #region Eventos De click de la zona 1

        private void dientesTotales1_DienteNumero11Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero12Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero13Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero14Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero15Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero16Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero17Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero18Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        #endregion 

        #region Eventos De click de la zona 2
        private void dientesTotales1_DienteNumero21Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero22Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero23Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero24Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero25Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero26Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero27Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero28Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }
        #endregion 

        
        #region Eventos De click de la zona 3

        private void dientesTotales1_DienteNumero31Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero32Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero33Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero34Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero35Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero36Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero37Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero38Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }


        #endregion 
       
        #region Eventos De click de la zona 4

        private void dientesTotales1_DienteNumero41Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero42Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero43Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero44Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero45Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero46Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero47Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        private void dientesTotales1_DienteNumero48Click(object sender, EventArgs e)
        {
            CargarDiente(dientesTotales1.CodDiente);
        }

        #endregion 

        private void btn_crearOdontogra_Click(object sender, EventArgs e)
        {
            if (obtOdontograma.ExisteOdontograma(loc_idPersona) == false)
            {
                IdOdontograma = obtOdontograma.InsertarOdontograma(new Odontograma(0, loc_idPersona, DateTime.Now));

                if (IdOdontograma <= 0)
                {
                    MessageBox.Show("♦♦♦ El odontograma no pudo ser creado conulte por el error \nal desarrollador ♦♦♦", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VisvilidadDeobjetos(false);
                }
                else
                {
                    MessageBox.Show("El Odontograma Fue Creado Sastisfatoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    VisvilidadDeobjetos(true);
                }
            }
            else {

                MessageBox.Show("♦♦♦ El paciente ya tiene registrado un Odontograma ♦♦♦", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }            

        }

        #endregion


        #region Condiciones  de La primer Cita
        
        private void EvaluarDienteCod(int IdCondigo,int Estado)
        {
            if (IdCondigo == 11) dientesTotales1.DienteNumero11 = Estado;
            if (IdCondigo == 12) dientesTotales1.DienteNumero12 = Estado;
            if (IdCondigo == 13) dientesTotales1.DienteNumero13 = Estado;
            if (IdCondigo == 14) dientesTotales1.DienteNumero14 = Estado;
            if (IdCondigo == 15) dientesTotales1.DienteNumero15 = Estado;
            if (IdCondigo == 16) dientesTotales1.DienteNumero16 = Estado;
            if (IdCondigo == 17) dientesTotales1.DienteNumero17 = Estado;
            if (IdCondigo == 18) dientesTotales1.DienteNumero18 = Estado;
            if (IdCondigo == 21) dientesTotales1.DienteNumero21 = Estado;
            if (IdCondigo == 22) dientesTotales1.DienteNumero22 = Estado;
            if (IdCondigo == 23) dientesTotales1.DienteNumero23 = Estado;
            if (IdCondigo == 24) dientesTotales1.DienteNumero24 = Estado;
            if (IdCondigo == 25) dientesTotales1.DienteNumero25 = Estado;
            if (IdCondigo == 26) dientesTotales1.DienteNumero26 = Estado;
            if (IdCondigo == 27) dientesTotales1.DienteNumero27 = Estado;
            if (IdCondigo == 28) dientesTotales1.DienteNumero28 = Estado;
            if (IdCondigo == 31) dientesTotales1.DienteNumero31 = Estado;
            if (IdCondigo == 32) dientesTotales1.DienteNumero32 = Estado;
            if (IdCondigo == 33) dientesTotales1.DienteNumero33 = Estado;
            if (IdCondigo == 34) dientesTotales1.DienteNumero34 = Estado;
            if (IdCondigo == 35) dientesTotales1.DienteNumero35 = Estado;
            if (IdCondigo == 36) dientesTotales1.DienteNumero36 = Estado;
            if (IdCondigo == 37) dientesTotales1.DienteNumero37 = Estado;
            if (IdCondigo == 38) dientesTotales1.DienteNumero38 = Estado;
            if (IdCondigo == 41) dientesTotales1.DienteNumero41 = Estado;
            if (IdCondigo == 42) dientesTotales1.DienteNumero42 = Estado;
            if (IdCondigo == 43) dientesTotales1.DienteNumero43 = Estado;
            if (IdCondigo == 44) dientesTotales1.DienteNumero44 = Estado;
            if (IdCondigo == 45) dientesTotales1.DienteNumero45 = Estado;
            if (IdCondigo == 46) dientesTotales1.DienteNumero46 = Estado;
            if (IdCondigo == 47) dientesTotales1.DienteNumero47 = Estado;
            if (IdCondigo == 48) dientesTotales1.DienteNumero48 = Estado;

        }
        #endregion 

        #region Parte de la primera Cita
        private void EstadoDelaPrimeraCita(int IdCondigo, int Estado)
        {
            if (IdCondigo == 11) OdontogramaPrimeraVez.DienteNumero11 = Estado;
            if (IdCondigo == 12) OdontogramaPrimeraVez.DienteNumero12 = Estado;
            if (IdCondigo == 13) OdontogramaPrimeraVez.DienteNumero13 = Estado;
            if (IdCondigo == 14) OdontogramaPrimeraVez.DienteNumero14 = Estado;
            if (IdCondigo == 15) OdontogramaPrimeraVez.DienteNumero15 = Estado;
            if (IdCondigo == 16) OdontogramaPrimeraVez.DienteNumero16 = Estado;
            if (IdCondigo == 17) OdontogramaPrimeraVez.DienteNumero17 = Estado;
            if (IdCondigo == 18) OdontogramaPrimeraVez.DienteNumero18 = Estado;
            if (IdCondigo == 21) OdontogramaPrimeraVez.DienteNumero21 = Estado;
            if (IdCondigo == 22) OdontogramaPrimeraVez.DienteNumero22 = Estado;
            if (IdCondigo == 23) OdontogramaPrimeraVez.DienteNumero23 = Estado;
            if (IdCondigo == 24) OdontogramaPrimeraVez.DienteNumero24 = Estado;
            if (IdCondigo == 25) OdontogramaPrimeraVez.DienteNumero25 = Estado;
            if (IdCondigo == 26) OdontogramaPrimeraVez.DienteNumero26 = Estado;
            if (IdCondigo == 27) OdontogramaPrimeraVez.DienteNumero27 = Estado;
            if (IdCondigo == 28) OdontogramaPrimeraVez.DienteNumero28 = Estado;
            if (IdCondigo == 31) OdontogramaPrimeraVez.DienteNumero31 = Estado;
            if (IdCondigo == 32) OdontogramaPrimeraVez.DienteNumero32 = Estado;
            if (IdCondigo == 33) OdontogramaPrimeraVez.DienteNumero33 = Estado;
            if (IdCondigo == 34) OdontogramaPrimeraVez.DienteNumero34 = Estado;
            if (IdCondigo == 35) OdontogramaPrimeraVez.DienteNumero35 = Estado;
            if (IdCondigo == 36) OdontogramaPrimeraVez.DienteNumero36 = Estado;
            if (IdCondigo == 37) OdontogramaPrimeraVez.DienteNumero37 = Estado;
            if (IdCondigo == 38) OdontogramaPrimeraVez.DienteNumero38 = Estado;
            if (IdCondigo == 41) OdontogramaPrimeraVez.DienteNumero41 = Estado;
            if (IdCondigo == 42) OdontogramaPrimeraVez.DienteNumero42 = Estado;
            if (IdCondigo == 43) OdontogramaPrimeraVez.DienteNumero43 = Estado;
            if (IdCondigo == 44) OdontogramaPrimeraVez.DienteNumero44 = Estado;
            if (IdCondigo == 45) OdontogramaPrimeraVez.DienteNumero45 = Estado;
            if (IdCondigo == 46) OdontogramaPrimeraVez.DienteNumero46 = Estado;
            if (IdCondigo == 47) OdontogramaPrimeraVez.DienteNumero47 = Estado;
            if (IdCondigo == 48) OdontogramaPrimeraVez.DienteNumero48 = Estado;

        }

        #endregion 

    }


}
