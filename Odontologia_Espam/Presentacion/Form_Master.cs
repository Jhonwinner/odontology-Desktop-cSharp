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
using System.Windows.Forms.Calendar;
using System.IO;
using Reportes;
using System.Diagnostics;




namespace Presentacion
{

    public partial class Form_Master : Form
    {
        #region Objetos Globales del calendario 
         List<CalendarItem> _items = new List<CalendarItem>();
        #endregion 

        #region Variables Gloabales 
        private int sesion_id;  // Id De usuario que acaba de Iniciar Sesion 
        #endregion 

        #region Objetos Globales de catalogos de la capa Negocio

        Catalogo_Usuario ojt_Usuario = new Catalogo_Usuario();
        Catalogo_Persona Persona = new Catalogo_Persona();
        Catalogo_Historia objHistoria = new Catalogo_Historia();
        #endregion 

        #region Zona de los Constructores 
        public Form_Master(int id_user)
        {
            InitializeComponent();
            this.sesion_id = id_user;
        }

        public Form_Master()
        {
            InitializeComponent();

        }

        #endregion 
        
        #region Carga Grafica del Formulario Master Load 
        
        private void Form_Master_Load(object sender, EventArgs e)
        {
         
            try
            {
                Lab_Nombre_Odonlogo.Text = ojt_Usuario.Funt_Retorna_NOmbre_Inicia_Sesion(sesion_id);
                Cont_Buscar.Focus();
                Grup_Busqueda.Visible = false; 
                txt_CantidadConsultasTotales.Text = objHistoria.NumerodeConsultaTotales().ToString();
                llenar_dataGridConlasUltimasPersonas();
                lbl_FechaActual.Text = DateTime.Now.ToLongDateString();
                fechasDeCargosCalendario();

                
            }
            catch (Exception)
            {
                
              
            }
         

        }

        #region LoadDeFechasEditables 

        private void fechasDeCargosCalendario() {
            _items.Clear();
            calendar1.SetViewRange(DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15));
            LlenarCalendarWihtItems(DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15));
            PlaceItems();
        
        }

        #endregion 

        #endregion

        #region Datagrib Carga de valores  y todos los datos de las personas Ademas Estan Incluidos eventos

        #region Este Metodo Llena el dataGrid solo con 20 personas las ultimas registradas

        private void llenar_dataGridConlasUltimasPersonas()
        {
            int indice = 0;

            DG_persona.Rows.Clear();

            foreach (var item in Persona.Consulta_Top_PErsona())
            {
                DG_persona.Rows.Add();
                DG_persona.Rows[indice].Cells[0].Value = item.var_Id_persona;
                DG_persona.Rows[indice].Cells[1].Value = item.var_Cedula_identidad;
                DG_persona.Rows[indice].Cells[2].Value = item.var_Nombres + " " + item.var_Apellidos;
                indice++;
            }

        }

        #endregion 

       #region Este Metodo Llena el dataGrid con el metodo Buscar  recibe el parametr cedula y nombres 

        private void llenar_dataGrid_con_busq(string Cedula, string Nombres)
        {
            int indice = 0;

            DG_persona.Rows.Clear();

            foreach (var item in Persona.Busca_PErsona_CI_Historia(new Persona(Cedula, Nombres)))
            {
                DG_persona.Rows.Add();
                DG_persona.Rows[indice].Cells[0].Value = item.var_Id_persona;
                DG_persona.Rows[indice].Cells[1].Value = item.var_Cedula_identidad;
                DG_persona.Rows[indice].Cells[2].Value = item.var_Nombres + " " + item.var_Apellidos;
                indice++;
            }

        }

        #endregion  


        private void DG_persona_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes((Int32)DG_persona.CurrentRow.Cells[0].Value,sesion_id);
                ObjetoAdminstra.ShowDialog();
                fechasDeCargosCalendario();

            }
            catch { }
        }


        #endregion 

        #region Este Metodo cierra la aplicacion Por completo

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        #endregion 
        
        #region Evento que capta las pulsaciones de el teclado cuando se esscribe en el texbox de busqueda
        private void Cont_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
                estado_checks();

            }
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        #endregion 
               
        #region Menu De la banda Superior de la Aplicacion 

        #region Menu --->   Parte de la  Ayuda  -->  Responde a los Eventos del Click de cada opcion

        #region Ejecutar El formualrio Sobre la informacion de la Aplicacion
        private void acercaDeLaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Acerca_de_app form_Informacion_App = new Form_Acerca_de_app();
            form_Informacion_App.Show();


        }
        #endregion 
              
        #region Ejecutar El formualrio Sobre la informacion de algun error 
        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Informar_Error Errores = new Form_Informar_Error(sesion_id);
            Errores.ShowDialog();
        }
        #endregion 

        #region Ejecutar El formualrio Sobre Ayuda  y consejos sobre la aplicacion 
        private void consejosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            Help.ShowHelp(this, Application.StartupPath + "\\ayuda.chm");
            Cursor = Cursors.Default;
        }
        #endregion 

        #endregion 


        #region Menu --->   Parte de la  Sesiones   -->  Responde a los Eventos del Click de cada opcion


        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Cerrar la Sesion", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CrudLogin obj_Login = new frm_CrudLogin(sesion_id);
            obj_Login.ShowDialog();
        }


     


        #endregion 

        #region Menu --->   Parte de la  Herramientas   -->  Responde a los Eventos del Click de cada opcion
        private void busquedaDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (busquedaDePacientesToolStripMenuItem.Checked == false)
            {
                rb_CI.Checked = true;
                busquedaDePacientesToolStripMenuItem.Checked = true;
                Grup_Busqueda.Visible = true;
                llenar_dataGridConlasUltimasPersonas();

            }
            else
            {

                busquedaDePacientesToolStripMenuItem.Checked = false;
                Grup_Busqueda.Visible = false;
                Cont_Buscar.Clear();

            }
        }

        #endregion

        #region Menu --->   Parte de la  Administracion    -->  Responde a los Eventos del Click de cada opcion

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes("Estudiante", sesion_id);
            ObjetoAdminstra.ShowDialog();
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes("Administrativo", sesion_id);
            ObjetoAdminstra.ShowDialog();
        }

        private void vinculacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes("Comunidad", sesion_id);
            ObjetoAdminstra.ShowDialog();

        }

        private void deServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes("Personal de Servicio", sesion_id);
            ObjetoAdminstra.ShowDialog();

        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes("Docente", sesion_id);
            ObjetoAdminstra.ShowDialog();
        }
        #endregion 

        #endregion

        #region Metodos de Busqueda para traer de la Base de Datos a los pacientes


        private void estado_checks()
        {

            if (rb_CI.Checked == true)
            {
                llenar_dataGrid_con_busq(Cont_Buscar.Text, null);
            }
            else
            {
                llenar_dataGrid_con_busq(null, Cont_Buscar.Text);
            }


        }







        #endregion 
   
        #region Zona de el Calendario Eventos y Funciones 

        //Evento que se ejecuta al seleccionar Fechas Con el Mouse 

        private void monthView1_SelectionChanged_1(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
            _items.Clear();
            LlenarCalendarWihtItems(monthView1.SelectionStart, monthView1.SelectionEnd);
           
            
        }

        #region Funcion Que Permite cargar elementos en la Agenda 
        private void LlenarCalendarWihtItems(DateTime StartDate, DateTime EndDate)
        {

           
                Catalogo_Historia objConsultas = new Catalogo_Historia();

                foreach (var item in objConsultas.ConsultarLasConsultasPorFecha(StartDate, EndDate))
                {
                    CalendarItem cal = new CalendarItem(calendar1, item.FechaHoraInicio, item.FechaHoraFin, item.Detalles_Consulta, item.id_consulta);

                    if (item.status == false)
                    {
                        cal.ApplyColor(Color.LightSkyBlue);
                    }
                    else
                    {
                        cal.ApplyColor(Color.Green);
                    }
                    _items.Add(cal);
                }

        }
        #endregion 

        //Esta funcion se ejecuta al hacer una seleccion al calendario Primario 

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        #region Permite Colocar Item en la Agenda Principal 

        private void PlaceItems()
        {
            foreach (CalendarItem item in _items)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }
        #endregion 


        #endregion

        #region Timer Elemento y eventos 
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_Relog.Text = DateTime.Now.ToLongTimeString();

        }
        #endregion 

        #region Menu Strip click Modifcar Eliminar etc 

        private void modificarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_administra_pacientes ObjetoAdminstra = new Form_administra_pacientes((Int32)DG_persona.CurrentRow.Cells[0].Value, sesion_id);
            ObjetoAdminstra.ShowDialog();
            fechasDeCargosCalendario(); 
             
        }

        private void eliminarElPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("♦♦♦  "+Persona.DeletePatient((Int32)DG_persona.CurrentRow.Cells[0].Value)+"  ♦♦♦", "Mensaje");
        }

        private void detallesDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PersonaDetalles PersonaDetalles = new frm_PersonaDetalles((Int32)DG_persona.CurrentRow.Cells[0].Value);
            PersonaDetalles.ShowDialog();
        }

        #endregion 

        private void reporteDeActivdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo_Historia obtHistoria = new Catalogo_Historia();

            RptActividadesPorSemanas obt_Reportes = new RptActividadesPorSemanas(obtHistoria.IdDoctor_Usuario(sesion_id));
            obt_Reportes.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process programa = new Process();
            ProcessStartInfo info = new ProcessStartInfo("calc.exe");
            info.WindowStyle = ProcessWindowStyle.Minimized; //Iniciamos la aplicación minimizada 
            programa = Process.Start(info); 
        }

        private void blocDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process programa = new Process();
            ProcessStartInfo info = new ProcessStartInfo("notepad.exe");
            info.WindowStyle = ProcessWindowStyle.Minimized; //Iniciamos la aplicación minimizada 
            programa = Process.Start(info); 
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process programa = new Process();
            ProcessStartInfo info = new ProcessStartInfo("StikyNot.exe");
            info.WindowStyle = ProcessWindowStyle.Minimized; //Iniciamos la aplicación minimizada 
            programa = Process.Start(info); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Reportes OBT = new frm_Reportes();
            OBT.ShowDialog();
        }


    }
}
