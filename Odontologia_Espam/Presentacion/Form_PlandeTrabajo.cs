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
using System.Threading;

namespace Presentacion
{
    public partial class Form_PlandeTrabajo : Form
    {
        private bool Estado = false;
        private DateTime FechaSeleccionadaPrincipio;
        private DateTime FechaSeleccionadaFin;
        private int IdHistoriaClinica;
        private int IdConsulta;
        private int IdUsuario;




        Catalogo_Historia objtConsultas = new Catalogo_Historia();
        Catalogo_Usuario obt_Usuario = new Catalogo_Usuario();
        private int tiempo;


        public Form_PlandeTrabajo()
        {
            InitializeComponent();
        }

        public Form_PlandeTrabajo(DateTime par_FechaSelectedStart, DateTime par_FechaSelectedEnd, int IdHistoria,int id_usuario)
        {
            InitializeComponent();
            this.FechaSeleccionadaPrincipio = par_FechaSelectedStart;
            this.FechaSeleccionadaFin = par_FechaSelectedEnd;
            this.IdHistoriaClinica = IdHistoria;
            this.IdUsuario = id_usuario;
        }

        public Form_PlandeTrabajo(int IdHistoria, int idConsulta, int id_usuario)
        {
            InitializeComponent();
            this.IdHistoriaClinica = IdHistoria;
            this.IdConsulta = idConsulta;
            this.IdUsuario = id_usuario; 
            Estado = true;
        }



        private void Form_PlandeTrabajo_Load(object sender, EventArgs e)
        {
            lbl_NombreDoctor.Text = obt_Usuario.Funt_Retorna_NOmbre_Inicia_Sesion(IdUsuario);

            if (Estado == false)
            {
                mkTxt_FechaConsulta.Text = FechaSeleccionadaPrincipio.ToString();
                lbl_nroHistoria.Text = IdHistoriaClinica.ToString();
                txt_HoraInicio.Text = FechaSeleccionadaPrincipio.ToShortTimeString();
                txt_endHora.Text = FechaSeleccionadaFin.ToShortTimeString();
            }
            else
            {
                btn_Add.Text = "Guardar";

                foreach (var item in objtConsultas.ConsultarLasConsultaEspecifica(IdHistoriaClinica,IdConsulta))
                {
                  mkTxt_FechaConsulta.Text = item.FechaHoraInicio.ToShortDateString();
                  lbl_nroHistoria.Text = item.id_historia.ToString(); 
                  txt_HoraInicio.Text = item.FechaHoraInicio.ToShortTimeString();
                  txt_endHora.Text = item.FechaHoraFin.ToShortTimeString();
                  cbox_EstadoConsulta.Checked = item.status;
                  txt_descripciom.Text = item.Detalles_Consulta; 
                }
                

            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo A Prueba","Sms");
        }

        private void Mkt_InicioHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            InsertaOActualizar();
            timer1.Enabled = true;
            tiempo = 20;

        }

        private void InsertaOActualizar()   {

            if (Estado == true)
            {
               ModificarConsulta();
            }
            else
            {
                insertarConsulta();
            }
        
        }


        private void txt_HoraInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertarConsulta()
        {

            string sms = "";
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_descripciom.Text))
                {

                    sms = objtConsultas.InsertConsultas(new Consulta(IdHistoriaClinica, objtConsultas.ValorMaximoDeConsulta(IdHistoriaClinica) + 1, txt_descripciom.Text, FechaSeleccionadaPrincipio, FechaSeleccionadaFin, cbox_EstadoConsulta.Checked,objtConsultas.IdDoctor_Usuario(IdUsuario) ));
                }
                else
                {
                    MessageBox.Show("Nesecita Escribir Algo de Informacion\n para poder registrar la cita", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception e)
            {
                sms = e.Message;
            }
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo = tiempo - 1;
            lbl_nroHistoria.Text = tiempo.ToString();
            Historia.Text = "Cierre en";
            if (tiempo == 0)
            {
                this.Close();
            }
        }


        private void ModificarConsulta()
        {

            string sms = "";
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_descripciom.Text))
                {
                    sms = objtConsultas.ModificarConsultas(new Consulta(IdHistoriaClinica, IdConsulta, txt_descripciom.Text, unionDeFechasyHora(mkTxt_FechaConsulta.Text, txt_HoraInicio.Text), unionDeFechasyHora(mkTxt_FechaConsulta.Text, txt_endHora.Text), cbox_EstadoConsulta.Checked));
                     
                }
                else
                {
                    MessageBox.Show("Nesecita Escribir Algo de Informacion\n para poder Modificar la cita", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception e)
            {
                sms = e.Message;
            }


        }


        private DateTime unionDeFechasyHora(string par_Fecha,string par_Hora) {
           
            DateTime loc_var = DateTime.Now;
            string temp="";

            if (par_Hora.Length == 4 )
            {
                temp = par_Hora;
                par_Hora = "0" + temp;                
            }

             loc_var =  DateTime.ParseExact(par_Fecha+" "+par_Hora, "dd/MM/yyyy HH:mm",null) ; 
             
            return loc_var;

        }


    }



}
