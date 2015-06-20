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
    public partial class frmDiente : Form
    {

        catalogoOdontograma objt_Odontograma = new catalogoOdontograma();
        Catalogo_Historia objt_Consultas = new Catalogo_Historia();

        int cod_diente;
        int cod_Odontograma;
        int cod_ParteDental;
        int cod_HistoriaClinica;
        int IdDoctor; 
    

        public frmDiente()
        {
            InitializeComponent();
        }

        public frmDiente(int parIdOdontograma , int par_codDiente, int par_IdDoctor)
        {
            InitializeComponent();
            this.cod_diente = par_codDiente;
            this.cod_Odontograma = parIdOdontograma; 
            lbl_NumeroDiente.Text = par_codDiente.ToString();
            this.cod_HistoriaClinica = objt_Consultas.IdHistoriaClinicaPorOdontograma(parIdOdontograma);
            this.IdDoctor = par_IdDoctor; 
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiente_Load(object sender, EventArgs e)
        {
            ConsultarTodosLosProcedientosDelDiente();
             LlenarAlDienteConInformacionReciente();
        }

        private void but_Guardar_Click(object sender, EventArgs e)
        {
            
            
            if (objt_Odontograma.ExisteOdontogramaDiente(cod_Odontograma, cod_diente))
            {
               ModificarDiente();

               if (ValidacionSielDienteHasidoExtraido() == false)
               {

                   if (VAlidaIgualdadad() == false)
                   {
                       if (cbox_Esconsulta.Checked == true )
                       {
                           if (!string.IsNullOrWhiteSpace(txt_Observacion.Text))
                           {
                               InsersionDienteProcedimiento();
                               objt_Consultas.InsertConsultas(new Consulta(cod_HistoriaClinica, objt_Consultas.ValorMaximoDeConsulta(cod_HistoriaClinica) + 1 , txt_Observacion.Text, DateTime.Now, DateTime.Now.AddHours(1), cbox_Esconsulta.Checked,objt_Consultas.IdDoctor_Usuario( IdDoctor)));
                               MessageBox.Show("Proceso de Guardado se ha realizado correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                               ConsultarTodosLosProcedientosDelDiente();
                               LlenarAlDienteConInformacionReciente();
                               txt_Observacion.Clear();
                           }
                           else
                           {
                               MessageBox.Show("Por favor redacte una descripcion del proceso"
                                   , "Informacion", MessageBoxButtons.OK); txt_Observacion.Focus();
                           }


                       }
                       else
                       {
                           MessageBox.Show(InsersionDienteProcedimiento());
                           ConsultarTodosLosProcedientosDelDiente();
                           LlenarAlDienteConInformacionReciente();
                           txt_Observacion.Clear();
                       }

                   }
                   else
                   {
                       MessageBox.Show("No se puede crear un procedimiento\nigual al realizado en la seesion Anterior"
                           , "Informacion", MessageBoxButtons.OK);
                   }
               }
               else
               {
                   MessageBox.Show("El diente extraido no puede ser modificado\nelimine el ultimo procedimiento"
                           , "Informacion", MessageBoxButtons.OK);
               }


            }
            else
            {
                if (cbox_Esconsulta.Checked == true)
                {
                    InsersionDiente();
                    MessageBox.Show(InsersionDienteProcedimiento());
                    ConsultarTodosLosProcedientosDelDiente();
                    LlenarAlDienteConInformacionReciente();
                    txt_Observacion.Clear();
                }
                else
                {
                    InsersionDiente();
                    MessageBox.Show(InsersionDienteProcedimiento());
                    ConsultarTodosLosProcedientosDelDiente();
                    LlenarAlDienteConInformacionReciente();
                    txt_Observacion.Clear();
                }
            }
        }

        private string InsersionDiente() {

            return (objt_Odontograma.InsertarOdontogramaDiente(new OdontogramaDiente(cod_Odontograma, cod_diente, unidadDental1.EstadoLunaSuperior1, DateTime.Now)));
        }
        
        private string  ModificarDiente()
        {
           return  objt_Odontograma.ModificarOdontogramaDiente(new OdontogramaDiente(cod_Odontograma, cod_diente, unidadDental1.EstadoLunaSuperior1, DateTime.Now));
        }

        private string InsersionDienteProcedimiento()
        {
           return objt_Odontograma.InsertarOdontogramaDienteProcedimiento(new OdonDienteProcedimiento(0,cod_Odontograma,cod_diente,unidadDental1.EstadoLunaCentral,unidadDental1.EstadoLunaSuperior2,unidadDental1.EstadoLunaInferior2
                ,unidadDental1.EstadoLunaDerecha,unidadDental1.EstadoLunaIzquierda,DateTime.Now,txt_Observacion.Text));           
        }
        private void ConsultarTodosLosProcedientosDelDiente() {

            cbx_TodosLosProcemientos.DataSource = objt_Odontograma.ConsultarOdontgramaDienteTodoslosDelaPersona(cod_Odontograma, cod_diente);
            cbx_TodosLosProcemientos.DisplayMember = "FechaDeCreacionParte";
            cbx_TodosLosProcemientos.ValueMember = "IdParteDental"; 
        
        }

        private void cbx_TodosLosProcemientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loc_IdParteDental = 0;

            try
            {
                loc_IdParteDental = int .Parse(cbx_TodosLosProcemientos.SelectedValue.ToString());
            }
            catch {}

            LlenarAlDienteConInformaciondelIDPArteDental(loc_IdParteDental);
        }

        private void LlenarAlDienteConInformacionReciente()
        {
            int loc_Aux = 0 ; 

            foreach (var item in objt_Odontograma.ConsultarOdontgramaDiente(cod_Odontograma,cod_diente))
            {

                foreach (var alfa in objt_Odontograma.ConsultarOdontgramaDienteProcedimientoUltimaFecha(cod_Odontograma, cod_diente))
                {
                    cod_ParteDental = alfa.IdParteDental; 
                    unidadDental1.EstadoLunaCentral = alfa.EstadoLunaCentral;
                    unidadDental1.EstadoLunaSuperior2 = alfa.EstadoLunaSuperior;
                    unidadDental1.EstadoLunaInferior2 = alfa.EstadoLunaInferior;
                    unidadDental1.EstadoLunaIzquierda = alfa.EstadoLunaIzquierda;
                    unidadDental1.EstadoLunaDerecha = alfa.EstadoLunaDerecha;
                    txt_Observacion.Text = alfa.Observaciones;
                    loc_Aux++;

                }

                if (loc_Aux == 0)
                {
                    unidadDental1.EstadoLunaCentral = 1;
                    unidadDental1.EstadoLunaSuperior2 = 1;
                    unidadDental1.EstadoLunaInferior2 = 1;
                    unidadDental1.EstadoLunaIzquierda = 1;
                    unidadDental1.EstadoLunaDerecha = 1;
                }
                unidadDental1.EstadoLunaSuperior1 = item.EstadoDiente; 

            }

 
        
        
        }

        private bool VAlidaIgualdadad() {

            bool estado = false; 

            foreach (var alfa in objt_Odontograma.ConsultarOdontgramaDienteProcedimientoUltimaFecha(cod_Odontograma, cod_diente))
            {

                if (unidadDental1.EstadoLunaCentral == alfa.EstadoLunaCentral &&
                unidadDental1.EstadoLunaSuperior2 == alfa.EstadoLunaSuperior &&
                unidadDental1.EstadoLunaInferior2 == alfa.EstadoLunaInferior &&
                unidadDental1.EstadoLunaIzquierda == alfa.EstadoLunaIzquierda &&
                unidadDental1.EstadoLunaDerecha == alfa.EstadoLunaDerecha)
                {  estado = true; }

            }

            return estado; 
        }



        private bool ValidacionSielDienteHasidoExtraido()
        {

            bool estado = false;

            foreach (var alfa in objt_Odontograma.ConsultarOdontgramaDienteProcedimientoUltimaFecha(cod_Odontograma, cod_diente))
            {
                if (alfa.EstadoLunaCentral == 3 && alfa.EstadoLunaSuperior == 3 &&
                    alfa.EstadoLunaInferior == 3 && alfa.EstadoLunaIzquierda == 3 &&
                    alfa.EstadoLunaDerecha == 3)
                {
                    estado = true;

                }

            }

            return estado;
        }



        private void LlenarAlDienteConInformaciondelIDPArteDental(int parIdPArteDental)
        {

            foreach (var alfa in objt_Odontograma.ConsultarOdontgramaDienteProcesosPorSuId(parIdPArteDental))
            {

                unidadDental1.EstadoLunaCentral = alfa.EstadoLunaCentral;
                unidadDental1.EstadoLunaSuperior2 = alfa.EstadoLunaSuperior;
                unidadDental1.EstadoLunaInferior2 = alfa.EstadoLunaInferior;
                unidadDental1.EstadoLunaIzquierda = alfa.EstadoLunaIzquierda;
                unidadDental1.EstadoLunaDerecha = alfa.EstadoLunaDerecha;
                txt_Observacion.Text = alfa.Observaciones;

            }


        }

        private void unidadDental1_LunaSuperior1Click(object sender, EventArgs e)
        {

            if (ValidacionSielDienteHasidoExtraido() == true )
            {
                MessageBox.Show("No se puede realizar esta accion el diente  ha sido extraido\n si ha cometido elgun error\nelimine el ultimo cambio al diente"
                          , "Informacion", MessageBoxButtons.OK);
                unidadDental1.EstadoLunaSuperior1 = 3;
            }
            else
            {


                if (MessageBox.Show("♦♦♦ Esta seguro de cambiar el estado del diente ♦♦♦",
                     "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    unidadDental1.EstadoLunaCentral = unidadDental1.EstadoLunaSuperior1;
                    unidadDental1.EstadoLunaSuperior2 = unidadDental1.EstadoLunaSuperior1;
                    unidadDental1.EstadoLunaInferior2 = unidadDental1.EstadoLunaSuperior1;
                    unidadDental1.EstadoLunaIzquierda = unidadDental1.EstadoLunaSuperior1;
                    unidadDental1.EstadoLunaDerecha = unidadDental1.EstadoLunaSuperior1;
                }
                else
                {
                    unidadDental1.EstadoLunaSuperior1 = unidadDental1.EstadoLunaSuperior1 - 1;
                }

            }

            }

        private void btn_Deshaser_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("♦♦♦ Esta usted seguro de deshaser el ultimo cambio ♦♦♦",
                              "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                objt_Odontograma.EliminarOdontogramaDienteProcedimientoXID(cod_ParteDental);

                foreach (var item in objt_Odontograma.ConsultarOdontgramaDiente(cod_Odontograma,cod_diente))
                {
                    if (item.EstadoDiente == 3) { unidadDental1.EstadoLunaSuperior1 = 2; ModificarDiente(); }
                    if (item.EstadoDiente == 2) { unidadDental1.EstadoLunaSuperior1 = 1; ModificarDiente(); }
                }
                
                ConsultarTodosLosProcedientosDelDiente();
                LlenarAlDienteConInformacionReciente();
                 
            }


        }

        private void unidadDental1_LunaCentralClick(object sender, EventArgs e)
        {
            txt_Observacion.Clear();
        }

        private void unidadDental1_LunaDerechaClick(object sender, EventArgs e)
        {
            txt_Observacion.Clear();
        }

        private void unidadDental1_LunaInferior1Click(object sender, EventArgs e)
        {
            txt_Observacion.Clear();
        }

        private void unidadDental1_LunaInferior2Click(object sender, EventArgs e)
        {
            txt_Observacion.Clear();
        }

        private void unidadDental1_LunaIzquierdaClick(object sender, EventArgs e)
        {
            txt_Observacion.Clear();
        }





 
    }
}
