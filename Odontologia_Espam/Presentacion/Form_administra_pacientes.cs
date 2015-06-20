using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.Calendar;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Threading;
using System.IO;
using Reportes;


namespace Presentacion
{
    public partial class Form_administra_pacientes : Form
    {
        #region Objetos de Catalogos PErsona Ubicacion Y historia Clinica 

        Catalogo_Persona Persona = new Catalogo_Persona();
        Catalogo_Ubicacion CATA_PC = new Catalogo_Ubicacion();
        Catalogo_Test Test = new Catalogo_Test();
        Catalogo_Historia Historia_Clinica = new Catalogo_Historia();
        System.Resources.ResourceManager Recursos = new System.Resources.ResourceManager(typeof(RecursosDeFotos));
        
        #endregion 

        #region varibles Globales 

        //Zone of variables
        public int idPErsona { set; get; }
        bool estado = false;
        int cod_tes { set; get; }
        int id_Pesona { set; get; }
        int idUsuarios { set; get; }

        #endregion  
        
        #region Construcctores  De la apliacion 

        #region Contrucctor simple si carga de parametros 

        public Form_administra_pacientes()
        {
            InitializeComponent();
        }

         #endregion 

        #region Constructor Simple con tipo de persona a registrase 
        
        public Form_administra_pacientes(string tipo_Re,int idUsuario)
        {
            InitializeComponent();
            CbTipo.Text = tipo_Re;
            llenarComboBoxNaxcionalidad();
            estado = false;
            EstableceVisionDecontroles(tipo_Re);
    
            this.idUsuarios = idUsuario;


        }
        #endregion

        #region Contructor con elementos que permiten la modificacion 
        public Form_administra_pacientes(int par_IDPersona,int par_IdUsuario)
        {
            InitializeComponent();
            this.idPErsona = par_IDPersona;
            this.idUsuarios = par_IdUsuario; 
            estado = true;
            llenarTexwithinformation(par_IDPersona);
            lab_NumeroHistoria.Text = Historia_Clinica.NumberofHistory(par_IDPersona).ToString();
            DesactivaTexboxs(true);
            btn_Guardar.Visible = false;
            btn_ImportarDatos.Visible = false;
            btn_GuardarTest.Visible = false; 
     
            EvaluaSiesMujerOhombre();
           
        }
        #endregion 

        #endregion

        #region Load Form 
        private void Form_administra_pacientes_Load(object sender, EventArgs e)
        {
            ExisteONoRegistradoOdontograma();
           
        }
        
        #endregion

        #region Funcion de Objetividad De odontograma

        private void ExisteONoRegistradoOdontograma() {
            catalogoOdontograma obtOdonto = new catalogoOdontograma();

            if (obtOdonto.ExisteOdontograma(functionReturnNumberofID()) == true)
            {
                btn_Odontograma.Text = "Visualizar Odontograma";
            }
            else
            {
                btn_Odontograma.Text = "Crear Odontograma";
            }
        }

        private void FuncionvalidaExistenciaTEst() {


            if (Test.EvaluaSiLaPersonatieneuntest(functionReturnNumberofID())== true)
            {
                btn_GuardarTest.Visible = false; 
            }
            else
            {
                btn_GuardarTest.Visible = true ;
                cod_tes = Test.ingresar_cab_test(idPErsona);
                insertAll(); 
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOdontograma objtOdontograma = new frmOdontograma(functionReturnNumberofID(),idUsuarios);
            objtOdontograma.ShowDialog();
        }

        #endregion

        #region Funciones que evalua estado de controles segun la accion

        private void EstableceVisionDecontroles(string Tipo)
      {

          if (Tipo == "Estudiante" || Tipo == "Docente") { btn_ImportarDatos.Visible = true; btn_Guardar.Visible = false; btn_Modificar.Visible = false; }
          else
          {
              btn_ImportarDatos.Visible = false; btn_Guardar.Visible = true; btn_Modificar.Visible = false;
          }

      }


        private void EvaluaSiesMujerOhombre()
        {

            if ( ComboGenero.Text  == "Femenino")
            {
                ptbx_Imagen.Image = (Image)Recursos.GetObject("Woman");
            }
            else
            {
                ptbx_Imagen.Image = (Image)Recursos.GetObject("man");
            }

        }

      #endregion 
                            
        #region Metodos que cargan informacion a los DAtagribview 

        #region Este Metodo permite Carga las preguntas en el Datagridview De antecedentes

        private void llenar_DTGAntecedentes()
        {
            int indice = 0;
            dtg_Antecedentes.Rows.Clear();

            foreach (var item in Test.FRetornaPreguntas(1))
            {
                dtg_Antecedentes.Rows.Add();
                dtg_Antecedentes.Rows[indice].Cells[0].Value = item.cod_PRegunta;
                dtg_Antecedentes.Rows[indice].Cells[1].Value = item.Preguntas_;
                indice++;
            }
        }

        private void LoadAllanswerTestAntecedents()
        {

            int indice = 0;

            foreach (var item in Test.FRetornaPreguntas(1))
            {
                dtg_Antecedentes.Rows[indice].Cells[2].Value = Test.AnswerOfTest(Test.FunRetornaIdTestXIdH(functionReturnNumberofID()), Convert.ToInt32(dtg_Antecedentes.Rows[indice].Cells[0].Value));
                indice++;
            }


        }

        #endregion 
        
        #region Este Metodo permite Carga las preguntas en el Datagridview De Examen Bucal 

        private void llenar_DTExamenBucal()
        {
            int indice = 0;
            dtg_ExamenBucal.Rows.Clear();

            foreach (var item in Test.FRetornaPreguntas(2))
            {
                dtg_ExamenBucal.Rows.Add();
                dtg_ExamenBucal.Rows[indice].Cells[0].Value = item.cod_PRegunta;
                dtg_ExamenBucal.Rows[indice].Cells[1].Value = item.Preguntas_;
                indice++;
            }

        }



        private void LoadAllanswerExamenbucal()
        {

            int indice = 0;

            foreach (var item in Test.FRetornaPreguntas(2))
            {
                dtg_ExamenBucal.Rows[indice].Cells[2].Value = Test.AnswerOfTest(Test.FunRetornaIdTestXIdH(functionReturnNumberofID()), Convert.ToInt32(dtg_ExamenBucal.Rows[indice].Cells[0].Value));
                indice++;
            }


        }



        #endregion 

        #region Este Metodo permite Carga las preguntas en el Datagridview De Detalle Periodental 
        private void llenar_DTPeriodontal()
        {
            int indice = 0;
            dtg_EnfremedadPeriodental.Rows.Clear();

            foreach (var item in Test.FRetornaPreguntas(3))
            {
                dtg_EnfremedadPeriodental.Rows.Add();
                dtg_EnfremedadPeriodental.Rows[indice].Cells[0].Value = item.cod_PRegunta;
                dtg_EnfremedadPeriodental.Rows[indice].Cells[1].Value = item.Preguntas_;
                indice++;
            }

        }


        private void LoadAllanswerTestPridodoOdontal()
        {
            // GroupBoxAntecedentes.Visible = true;
            int indice = 0;

            foreach (var item in Test.FRetornaPreguntas(3))
            {
                dtg_EnfremedadPeriodental.Rows[indice].Cells[2].Value = Test.AnswerOfTest(Test.FunRetornaIdTestXIdH(functionReturnNumberofID()), Convert.ToInt32(dtg_EnfremedadPeriodental.Rows[indice].Cells[0].Value));
                indice++;
            }


        }
       


        #endregion 

        #region Eventos de los Datagridview 
        
        private void dtg_ExamenBucal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            evento_UpdateExamen();
        }


        private void dtg_Antecedentes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            evento_UpdateAntecedentes();
        }

        private void dtg_EnfremedadPeriodental_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            evento_UpdatePeriodontal();
        }

        #endregion

        #endregion

        #region Metodos de Gestion de Comboxs

        #region Provincia y nacionalidad

        private void llenarComboBoxNaxcionalidad()
        {

            Cbx_Nacionalidad.DataSource = CATA_PC.CONSULTAR_PAIS();
            Cbx_Nacionalidad.ValueMember = "id_pais";
            Cbx_Nacionalidad.DisplayMember = "pais";

            combo_PROVINCIA.DataSource = CATA_PC.CONSULTAR_PROVINCIAS(int.Parse(Cbx_Nacionalidad.SelectedValue.ToString()));
            combo_PROVINCIA.ValueMember = "id_prov";
            combo_PROVINCIA.DisplayMember = "provincia";

        }
        #endregion 

        #region Estado de Provicia

        private void combo_PROVINCIA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            combo_CANTON.DataSource = CATA_PC.CONSULTAR_CANTONES(int.Parse(combo_PROVINCIA.SelectedValue.ToString()));
            combo_CANTON.ValueMember = "id_canton";
            combo_CANTON.DisplayMember = "cantones";
        }

        #endregion 

        #endregion

        #region Metodo que Obtiene La persona desde la base de Datos de la Universidad 


        private void btn_ImportarDatos_Click(object sender, EventArgs e)
        {
            Administra_Odontologo Busqueda = new Administra_Odontologo();
            Busqueda.ShowDialog();
            llenar_textos();
            btn_Guardar.Visible = true;
        }

        #endregion 

        #region Metodos para llenar Texto en base a una varible de confuguracion 

        public void llenar_textos() {
 
            int aux = 0;
 
            try
            {
                aux = Convert.ToInt16(Properties.Settings.Default.User);
            }
            catch (Exception)
            {
              
            }

            llenarTexwithinformation(aux);
        
        }


        #endregion 

        #region Este metodo Permite Cargar Informacion a los texboxs exisetntes del group box Persona 

        private void llenarTexwithinformation(int aux) {
           
            llenarComboBoxNaxcionalidad();


            if (estado == true )
            {
                foreach (var item in Persona.Busca_PErsona_CI_Nombre_Base_Local(aux))
                {
                    TxtNombres.Text = item.var_Nombres;
                    txtApellidos.Text = item.var_Apellidos;
                    txtCi.Text = item.var_Cedula_identidad;
                    txtDireccion.Text = item.var_Direccion;
                    txtTelefono.Text = item.var_telefono;
                    Cbx_Nacionalidad.Text = CATA_PC.NombreDePais(Convert.ToInt32(item.var_nacionalidad));

                    combo_PROVINCIA.Text = CATA_PC.NombreDeProvincia(item.var_provincia);
                    combo_PROVINCIA_SelectionChangeCommitted(null,null);
                    combo_CANTON.Text = CATA_PC.NombreDeCanton(item.var_provincia,item.var_canton);
                    Dtimen.Text = item.var_Fecha_nacimiento.ToShortDateString();
                    ComboGenero.Text = item.var_Genero;
                    txtEmail.Text = item.var_correo;
                    CbTipo.Text = "Estudiante";
                    txt_edad.Text = (DateTime.Today.Year - Dtimen.Value.Year).ToString();

                }

                
            }
            
            else {

             //rescuet information About information of database REmota 

                foreach (var item in Persona.Busca_PErsona_X_ID(aux))
            {
                TxtNombres.Text = item.var_Nombres;
                txtApellidos.Text = item.var_Apellidos;
                txtCi.Text = item.var_Cedula_identidad;
                txtDireccion.Text = item.var_Direccion;
                txtTelefono.Text = item.var_telefono;
                Cbx_Nacionalidad.Text = item.var_nacionalidadRemota;
                Dtimen.Text = item.var_Fecha_nacimiento.ToShortDateString();
                ComboGenero.Text = item.var_Genero;
                txtEmail.Text = item.var_correo;
                CbTipo.Text = "Estudiante";
                txt_edad.Text = (DateTime.Today.Year - Dtimen.Value.Year).ToString();

            }
            }
        }

        #endregion

        #region MEtodo que desactiva todos los textbox contra escritura 

        private void DesactivaTexboxs(bool estado)
        {
            txt_edad.ReadOnly = estado;
            txtCi.ReadOnly = estado;
            TxtNombres.ReadOnly = estado;
            txtApellidos.ReadOnly = estado;
            txtDireccion.ReadOnly = estado;
            txtTelefono.ReadOnly = estado;
            txtEmail.ReadOnly = estado;
            
        }


       #endregion 
        
        #region Eventos click en el Tab Informacion del Paciente
 
        #region Metodo  que Se ejecuta al pulsar el boton Guardar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (estado == false)
                {
                    if (!string.IsNullOrWhiteSpace(txtCi.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
                    {


                        if (Persona.Funcion_existe_Paciente(txtCi.Text) == false)
                        {

                            id_Pesona = int.Parse(Persona.INGRESAR_PACIENTE(new Persona(0, txtCi.Text, TxtNombres.Text, txtApellidos.Text, Convert.ToInt16(Cbx_Nacionalidad.SelectedValue), Convert.ToInt16(combo_PROVINCIA.SelectedValue), Convert.ToInt16(combo_CANTON.SelectedValue), txtDireccion.Text, Convert.ToDateTime(Dtimen.Value.ToShortDateString()), CbTipo.Text, txtTelefono.Text, txtEmail.Text, ComboGenero.Text)));
                            MessageBox.Show("Paciente  Registrado", "Status : Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            btn_Guardar.Visible = false;
                            DesactivaTexboxs(true);
                            lab_NumeroHistoria.Text = Historia_Clinica.InsertarHistoriaClinica(new Historia_clinica(id_Pesona, "", "")).ToString();

                        }
                        else
                        {
                            MessageBox.Show("Atencion el Usuario Ya esta Registrado", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Atencion Debe escribir Informacion en Cedula ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    MessageBox.Show(Persona.ModifiquePatient(new Persona(functionReturnNumberofID(), txtCi.Text, TxtNombres.Text, txtApellidos.Text, Convert.ToInt16(Cbx_Nacionalidad.SelectedValue), Convert.ToInt16(combo_PROVINCIA.SelectedValue), Convert.ToInt16(combo_CANTON.SelectedValue), txtDireccion.Text, Convert.ToDateTime(Dtimen.Value.ToShortDateString()), CbTipo.Text, txtTelefono.Text, txtEmail.Text, ComboGenero.Text)));
                    btn_Guardar.Visible = false;
                    DesactivaTexboxs(true);
                }


            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);

            }

        }

        #endregion 
        
        #region Metodo que se ejecuta al pulsar Modificar 
       
        private void Modificar_Click(object sender, EventArgs e)
        {
            btn_Guardar.Visible = true;
            DesactivaTexboxs(false);

        } 

        #endregion

        #endregion 
        
        #region Metodo que calcula la edad en anios
        private void Dtimen_ValueChanged(object sender, EventArgs e)
        {
            txt_edad.Text = (DateTime.Today.Year - Dtimen.Value.Year).ToString();
           
        }
        #endregion 

        #region Evento Click De la Parte del Test 
        
        private void btn_ModificarTest_Click(object sender, EventArgs e)
        {
            btn_GuardarTest.Visible = true;
            btn_ModificarTest.Visible = false;
            estado = true;
        }


        
        #endregion 

        #region Proges Bar Metodo de calculo 

        private void ProgresRuleThree( int a) {

            progressBar1.Value = (100* (a - 1) / ((dtg_Antecedentes.RowCount + dtg_ExamenBucal.RowCount + dtg_EnfremedadPeriodental.RowCount)));
        }

        #endregion 

        #region Metodo q inserta todas las respuestas de todos los test 

        private void insertAll()
        {

            int acum = 0;

            try
            {
                for (int i = 0; i < dtg_Antecedentes.RowCount; i++)
                {
                    acum = acum + 1;
                    Test.ingresar_Çuerp_test(new Test_Cuerpo(cod_tes, acum, Convert.ToInt16(dtg_Antecedentes.Rows[i].Cells[0].Value), Convert.ToBoolean(dtg_Antecedentes.Rows[i].Cells[2].Value)));
                    ProgresRuleThree(acum);
                    

                }
             

                for (int i = 0; i < dtg_ExamenBucal.RowCount; i++)
                {
                    acum = acum + 1;
                    Test.ingresar_Çuerp_test(new Test_Cuerpo(cod_tes, acum, Convert.ToInt16(dtg_ExamenBucal.Rows[i].Cells[0].Value), Convert.ToBoolean(dtg_ExamenBucal.Rows[i].Cells[2].Value)));
                    ProgresRuleThree(acum);
                 
                }

       

                for (int i = 0; i < dtg_EnfremedadPeriodental.RowCount; i++)
                {
                    acum = acum + 1;
                    Test.ingresar_Çuerp_test(new Test_Cuerpo(cod_tes, acum, Convert.ToInt16(dtg_EnfremedadPeriodental.Rows[i].Cells[0].Value), Convert.ToBoolean(dtg_EnfremedadPeriodental.Rows[i].Cells[2].Value)));
                    ProgresRuleThree(acum);
                  
                }


                MessageBox.Show("Datos Guradados  Correctamente", "Status : Enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception)
            {


            }
        }

        #endregion 

        #region Metodo q Modifica  todas las respuestas de todos los test

        private void ModifyAll()
        {

            int acum = 1;

            try
            {
                for (int i = 0; i < dtg_Antecedentes.RowCount; i++)
                {
                    acum = acum + 1;
                    Test.QuestionModifyque(new Test_Cuerpo(Test.ValueIdTestWithPErson(functionReturnNumberofID()), acum, Convert.ToInt16(dtg_Antecedentes.Rows[i].Cells[0].Value), Convert.ToBoolean(dtg_Antecedentes.Rows[i].Cells[2].Value)));
                    Thread.Sleep(100);
                    ProgresRuleThree(acum);
                    
                    
                }


                for (int i = 0; i < dtg_ExamenBucal.RowCount ; i++)
                {
                    acum = acum + 1;
                    Test.QuestionModifyque(new Test_Cuerpo(Test.ValueIdTestWithPErson(functionReturnNumberofID()), acum, Convert.ToInt16(dtg_ExamenBucal.Rows[i].Cells[0].Value), Convert.ToBoolean(dtg_ExamenBucal.Rows[i].Cells[2].Value)));
                    Thread.Sleep(100);
                    ProgresRuleThree(acum);
                    
                }


                for (int i = 0; i < dtg_EnfremedadPeriodental.RowCount; i++)
                {

                    acum = acum + 1;
                    Test.QuestionModifyque(new Test_Cuerpo(Test.ValueIdTestWithPErson(functionReturnNumberofID()), acum, Convert.ToInt16(dtg_EnfremedadPeriodental.Rows[i].Cells[0].Value), Convert.ToBoolean(dtg_EnfremedadPeriodental.Rows[i].Cells[2].Value)));
                    Thread.Sleep(100);
                    ProgresRuleThree(acum);
                   
                }


                MessageBox.Show("Datos Se han Actualizado  Correctamente", "Status : Enviado", MessageBoxButtons.OK);

            }
            catch (Exception)
            {


            }
        }

        #endregion 

       #region Metodo que Obtiene el id PErsona en el estado Actualizar e insertar 
 
        private int functionReturnNumberofID() {
            int aux;

            if (estado == false)
            {
                aux = id_Pesona;
            }
            else
            {
                aux = idPErsona;
            }
            return aux;
        }

        #endregion 
        
       #region  Metodo que permite cargar las consultas existentes segun la historia Clinica 

       private void LlenarCalendarWihtItems(int par_HistoriaClinica) {

                       Catalogo_Historia objConsultas = new Catalogo_Historia();

               foreach (var item in objConsultas.ConsultarLasConsultas(par_HistoriaClinica))
               {
                   CalendarItem cal = new CalendarItem(calendar1, item.FechaHoraInicio, item.FechaHoraFin,item.Detalles_Consulta,item.id_consulta);

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

       #region Evento que se ejecuta al Cambiar el index de la Pestania

       private void Pesta_Informacion_Selecting(object sender, TabControlCancelEventArgs e)
         {

             if (e.TabPageIndex == 1) {
                 _items.Clear();
                 calendar1.SetViewRange(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10));
                 LlenarCalendarWihtItems(int.Parse(lab_NumeroHistoria.Text));
                 PlaceItems();
                                
             
             }
            
           
             if (e.TabPageIndex == 2) {

                 llenar_DTGAntecedentes(); LoadAllanswerTestAntecedents();
                 llenar_DTExamenBucal(); LoadAllanswerExamenbucal();
                 llenar_DTPeriodontal(); LoadAllanswerTestPridodoOdontal(); 
                 
             }


         }

       #endregion 


       #region Calendario Y agenda Sus metodos y funciones


       List<CalendarItem> _items = new List<CalendarItem>();


       private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
       {
           PlaceItems();
       }

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


        private void calendar1_LoadItems_1(object sender, CalendarLoadEventArgs e)
       {
           PlaceItems();
       }

       private void monthView1_SelectionChanged_1(object sender, EventArgs e)
       {
           calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
           _items.Clear();
           LlenarCalendarWihtItems(int.Parse(lab_NumeroHistoria.Text));


       }

       private void calendar1_ItemMouseHover_1(object sender, CalendarItemEventArgs e)
       {
           Text = e.Item.Text;
       }

       private void calendar1_ItemDoubleClick_1(object sender, CalendarItemEventArgs e)
       {
           Form_PlandeTrabajo PlanDeTRabajo = new Form_PlandeTrabajo(e.Item.StartDate, e.Item.EndDate, int.Parse(lab_NumeroHistoria.Text), idUsuarios);
           PlanDeTRabajo.ShowDialog();
           _items.Clear();
           calendar1.SetViewRange(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10));
           LlenarCalendarWihtItems(int.Parse(lab_NumeroHistoria.Text));
           PlaceItems();
        

       }

       private void calendar1_ItemDeleted_1(object sender, CalendarItemEventArgs e)
       {
           _items.Remove(e.Item);
       }

       private void calendar1_ItemCreated_1(object sender, CalendarItemCancelEventArgs e)
       {
           _items.Add(e.Item);
       }

       private void calendar1_DayHeaderClick_1(object sender, CalendarDayEventArgs e)
       {
           calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
       }

       private void hourToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
       }


       private void minutesToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
       }

       private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
       {
           calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
       }

       private void minutesToolStripMenuItem1_Click_1(object sender, EventArgs e)
       {
           calendar1.TimeScale = CalendarTimeScale.TenMinutes;
       }

       private void minutesToolStripMenuItem2_Click_1(object sender, EventArgs e)
       {
           calendar1.TimeScale = CalendarTimeScale.SixMinutes;
       }

       private void minutesToolStripMenuItem3_Click_1(object sender, EventArgs e)
       {
           calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
       }


       #endregion 

 
       #region Eventos de click de todos los botones  del test 


        #region Parte de los botones de creacion de preguntas 

       private void but_PreguntaNuevaEnfPer_Click(object sender, EventArgs e)
       {
           Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(3);
           NewPe.ShowDialog(this);
           llenar_DTPeriodontal();
       }


       private void but_PreguntaNuevaExBuc_Click(object sender, EventArgs e)
       {
           Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(2);
           NewPe.ShowDialog(this);
           llenar_DTExamenBucal();
       }


       private void but_PreguntaNuevaAnt_Click(object sender, EventArgs e)
       {

           Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(1);
           NewPe.ShowDialog(this);
           llenar_DTGAntecedentes();
       }

       #endregion 
        
        #region Parte de los botones de Modificar  de preguntas

       #region Eventos Clicks de modificar Preguntas 
       
       private void btn_PreguntaModifAnt_Click(object sender, EventArgs e)
       {
           evento_UpdateAntecedentes();
           LoadAllanswerTestAntecedents();
       }

       private void but_PreguntaModificarExB_Click(object sender, EventArgs e)
       {
           evento_UpdateExamen();
           LoadAllanswerExamenbucal();
       }

       private void but_PreguntaModificarEnfPer_Click(object sender, EventArgs e)
       {
           evento_UpdatePeriodontal();
           LoadAllanswerTestPridodoOdontal();

       }

       
       #endregion 

       #region Funciones Llamadas a los eventos de click modificar

       private void evento_UpdateAntecedentes()
       {

           int id = 0;
           string Pre = null;

           try
           {
               id = int.Parse(dtg_Antecedentes.CurrentRow.Cells[0].Value.ToString());
               Pre = dtg_Antecedentes.CurrentRow.Cells[1].Value.ToString();
               Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(id, Pre, 1);
               NewPe.ShowDialog(this);
               llenar_DTGAntecedentes();

           }
           catch (Exception xzx)
           {
               MessageBox.Show(xzx.Message);

           }

       }

       private void evento_UpdateExamen()
       {

           int id = 0;
           string Pre = null;

           try
           {
               id = int.Parse(dtg_ExamenBucal.CurrentRow.Cells[0].Value.ToString());
               Pre = dtg_ExamenBucal.CurrentRow.Cells[1].Value.ToString();
               Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(id, Pre, 2);
               NewPe.ShowDialog(this);
               llenar_DTExamenBucal();

           }
           catch (Exception xzx)
           {
               MessageBox.Show(xzx.Message);

           }

       }


       private void evento_UpdatePeriodontal()
       {

           int id = 0;
           string Pre = null;

           try
           {
               id = int.Parse(dtg_EnfremedadPeriodental.CurrentRow.Cells[0].Value.ToString());
               Pre = dtg_EnfremedadPeriodental.CurrentRow.Cells[1].Value.ToString();
               Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(id, Pre, 3);
               NewPe.ShowDialog(this);
               llenar_DTPeriodontal();

           }
           catch (Exception xzx)
           {
               MessageBox.Show(xzx.Message);

           }

       }
       #endregion



        #endregion

        #region Parte de los botones de Eliminar  de preguntas

       //Botones que borran

       private void PreguntaBorrarAnt_Click(object sender, EventArgs e)
       {
           try
           {
               Test.FunElimaPregunta(new Preguntas(int.Parse(dtg_Antecedentes.CurrentRow.Cells[0].Value.ToString())));
               llenar_DTGAntecedentes();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }

       }

       private void but_PreguntaEliminarExB_Click(object sender, EventArgs e)
       {
           try
           {
               Test.FunElimaPregunta(new Preguntas(int.Parse(dtg_ExamenBucal.CurrentRow.Cells[0].Value.ToString())));
               llenar_DTExamenBucal();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }
       }

       private void but_PreguntaEliminarEnfPer_Click(object sender, EventArgs e)
       {
           try
           {
               Test.FunElimaPregunta(new Preguntas(int.Parse(dtg_EnfremedadPeriodental.CurrentRow.Cells[0].Value.ToString())));
               llenar_DTPeriodontal();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }
       }

        #endregion

        #region Parte de los botones de Refresh  de preguntas

       private void btn_PreguntaRefreshAnt_Click(object sender, EventArgs e)
       {
           llenar_DTGAntecedentes();
           LoadAllanswerTestAntecedents();
       }

       private void but_PreguntaRefreshExB_Click(object sender, EventArgs e)
       {
           llenar_DTExamenBucal();
           LoadAllanswerExamenbucal();
       }

       private void but_PreguntaRefreshEnfPer_Click(object sender, EventArgs e)
       {
           llenar_DTPeriodontal();
           LoadAllanswerTestPridodoOdontal();
       }




       #endregion

        #region Parte del Crud de los Test 
        

       private void btn_ModificarTest_Click_1(object sender, EventArgs e)
       {
           btn_GuardarTest.Visible = true;
           btn_ModificarTest.Visible = false;
       }


       private void btn_GuardarTest_Click(object sender, EventArgs e)
       {
           eventos_insert_update();
           btn_GuardarTest.Visible = false;
           btn_ModificarTest.Visible = true;
           estado = true;
       }

       private void eventos_insert_update()
       {
           int id_local;


           if (estado == false)
           {
               id_local = id_Pesona;
           }
           else
           {
               id_local = idPErsona;
           }

           try
           {

               if (estado == false)
               {
                   this.cod_tes = Test.ingresar_cab_test(id_local);
                   insertAll();
               }
               else
               {
                   if (Test.EvaluaSiLaPersonatieneuntest(id_local) == false){ this.cod_tes = Test.ingresar_cab_test(this.idPErsona);
                   insertAll();}
                   ModifyAll();
               }

               LoadAllanswerExamenbucal();
               LoadAllanswerTestAntecedents();
               LoadAllanswerTestPridodoOdontal();
           }
           catch (Exception)
           {

           }


       }

        
        #endregion 
 
 
       #endregion

        #region Evento de text Change index del el combo box de genero 
        
       private void ComboGenero_SelectedIndexChanged(object sender, EventArgs e)
       {
           EvaluaSiesMujerOhombre();
       }


        #endregion 

       #region Eventos Click del Menus strip 

       private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
       {

           try
           {

                   foreach (CalendarItem item in calendar1.GetSelectedItems())
                   {
                       Form_PlandeTrabajo PlandeTrabajo = new Form_PlandeTrabajo(int.Parse(lab_NumeroHistoria.Text), item.IdConsultasGeneral, idUsuarios);
                       PlandeTrabajo.ShowDialog();
                       actualizaFondoCalendario();
                   }

             

           }
           catch (Exception)
           {
              
           }

                     

       }

       private void yellowTagToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           try
           {
    
               if (MessageBox.Show("♦♦♦   Esta Seguro Eliminar la Cita  ♦♦♦", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
               {
               foreach (CalendarItem item in calendar1.GetSelectedItems())
               {
                    MessageBox.Show(" ♦♦♦"+ Historia_Clinica.EliminarConsultas(int.Parse(lab_NumeroHistoria.Text),item.IdConsultasGeneral)+" ♦♦♦","Mensaje");
                    actualizaFondoCalendario();
               }


               }
           }
           catch (Exception)
           {
           }

       }

       private void actualizaFondoCalendario() {

           _items.Clear();
           calendar1.SetViewRange(DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15));
           LlenarCalendarWihtItems(int.Parse(lab_NumeroHistoria.Text));
           PlaceItems();

       }

       #endregion   

       private void btn_salir_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
       {

           try
           {

               foreach (CalendarItem item in calendar1.GetSelectedItems())
               {
                   frmDetallesConsulta PlandeTrabajo = new frmDetallesConsulta(int.Parse(lab_NumeroHistoria.Text), item.IdConsultasGeneral, Persona.NombreDelPAciente(functionReturnNumberofID()));
                   PlandeTrabajo.ShowDialog();
                   actualizaFondoCalendario();
               }



           }
           catch (Exception)
           {

           }
       }

       private void btn_Reporte_Click(object sender, EventArgs e)
       {
           frmRptHistoriaClinica obt = new frmRptHistoriaClinica(int.Parse(lab_NumeroHistoria.Text));
           obt.ShowDialog();
       }

  


    }
}
