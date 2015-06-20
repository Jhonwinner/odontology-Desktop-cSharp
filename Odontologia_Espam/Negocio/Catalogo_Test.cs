using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos.OdontologiaTableAdapters;


namespace Negocio
{
    public  class Catalogo_Test
    {
        

        QueriesTableAdapter ProcesosCRUD = new QueriesTableAdapter();
        

        public List<Test_Cuerpo> FunRetornaRespuestasTest(Test_Cuerpo TestC) {

            List<Test_Cuerpo> Lista = new List<Test_Cuerpo>();
            PA_Consulta_Test_Detalle_TotalTableAdapter TestPorCod = new PA_Consulta_Test_Detalle_TotalTableAdapter();

            foreach (var item in  TestPorCod.GetData(TestC.id_test_cab).ToList())
            {
                Lista.Add(new Test_Cuerpo(item.Id_test,item.Deta_test,item.Cod_Pregunta,item.Respuesta));
            }

            return Lista;
        
        
        }


        public void FunElimaPregunta(Preguntas P) {

            try
            {
                ProcesosCRUD.PaEliminaPregunta(P.cod_PRegunta);
            }
            catch (Exception)
            {
                
            }
        }

        public int FunRetornaIdTestXIdH( int par_IdHistoria)
        {
            int a=0; 

            try
            {
                a = Convert.ToInt32(ProcesosCRUD.FunRecogeIdTest(par_IdHistoria));
            }
            catch (Exception)
            {
            }

            return a;
        }




        public void FunModificaRespuestas(Test_Cuerpo T)
        {

            try
            {
                ProcesosCRUD.PA_Modify_Test_Detalle(T.id_test_cab, T.pregunta, T.respuesta);
            }
            catch (Exception)
            {

            }
        }

        public bool FunValorExistente(Test_Cab test)
        {
            bool estado = false;

            try
            {
                estado = Convert.ToBoolean(ProcesosCRUD.FuncValorExistente(test.id_historia));
            }
            catch (Exception)
            {

            }

            return estado;
        }

        public bool FunValorRespuesta(Test_Cuerpo Test)
        {
            bool sms = false; 

            try
            {
                sms = Convert.ToBoolean(ProcesosCRUD.FunDevuelveEstado(Test.id_test_cab, Test.id_test_cuerpo, Test.pregunta));
            }
            catch (Exception)
            {

            }

            return sms;
        }
        

        public int ingresar_cab_test(int idPersoona) {
            int id_de_insercion=0;
            PA_Insert_Test_cabTableAdapter Insert_Test_Cab = new PA_Insert_Test_cabTableAdapter();

            try
            {
                foreach (var item in Insert_Test_Cab.GetData(idPersoona))
                {
                    id_de_insercion = int.Parse(item.Column1.ToString());
                }
            }
            catch (Exception)
            {
                             
            }

            return id_de_insercion;

        }


        public List<Test_Cab> ConsultarTodosLosTesCreados()
        {
            List<Test_Cab> lista = new List<Test_Cab>();
            PA_Consulta_Test_cabeceraTableAdapter DtaConsul = new PA_Consulta_Test_cabeceraTableAdapter();

            try
            {
                foreach (var item in DtaConsul.GetData())
                {
                    lista.Add(new Test_Cab (item.Id_test,item.Id_historia,item.Fecha_creacion));
                }
            }
            catch  {   }

            return lista;

        }

        public void  ingresar_Çuerp_test(Test_Cuerpo Tc)
        {
            

            try
            {
                ProcesosCRUD.PA_Insert_Test_Detalle(Tc.id_test_cab, Tc.id_test_cuerpo, Tc.pregunta, Tc.respuesta);
            }
            catch (Exception)
            {

            }
                   

        }




        public void modifica_pregunta(Preguntas P)
        {
            try
            {
                ProcesosCRUD.PaModificaPregunta(P.cod_PRegunta, P.Preguntas_,P.tipo_);
            }
            catch (Exception)
            {
                
          
            }

        }

        public int Insertar_Preguntas(Preguntas Pre)
        {
            int id_de_insercion = 0;
            PaInsertaPreguntaTableAdapter Preguntas_new = new PaInsertaPreguntaTableAdapter();

            try
            {
                foreach (var item in Preguntas_new.GetData(Pre.Preguntas_,Pre.tipo_))
                {
                    id_de_insercion = int.Parse(item.Column1.ToString());
                }
            }
            catch (Exception)
            {

            }

            return id_de_insercion;

        }


        public string  QuestionModifyque(Test_Cuerpo Pre)
        {
           string sms = "Datos Actualizados Correctamente";
          

            try
            {
                ProcesosCRUD.PA_Modify_Test_Detalle(Pre.id_test_cab,Pre.pregunta,Pre.respuesta);               

            }
            catch (Exception e )
            {
                sms = e.Message ;
            }

            return sms;

        }



        public List<Test_Cuerpo> Fun_Consultar_Preguntas(Test_Cuerpo T_Cuerpo) {

            List<Test_Cuerpo> lista = new List<Test_Cuerpo>();
            PA_Consulta_Test_Detalle_TotalTableAdapter TestPreguntas = new PA_Consulta_Test_Detalle_TotalTableAdapter();

            foreach (var item in TestPreguntas.GetData(T_Cuerpo.id_test_cab).ToList())
            {
                lista.Add(new Test_Cuerpo(item.Id_test, item.Deta_test,item.Cod_Pregunta, item.Respuesta));
            }

            return lista;
        }

        public List<Preguntas> FRetornaPreguntas(int tipo_Pregunta)
        {

            List<Preguntas> Lista = new List<Preguntas>();
            PaConsultaPreguntasTableAdapter Preguntas_todas = new PaConsultaPreguntasTableAdapter();

            try
            {
                foreach (var item in Preguntas_todas.GetData(tipo_Pregunta).ToList())
                {
                    Lista.Add(new Preguntas(item.Cod_Pregunta, item.Preguntas,item.Tipo_preguntas));
                }

            }
            catch (Exception)
            {
                
            }
           

            return Lista;

        }


        public bool AnswerOfTest(int IdHeaderTes, int IdQuestion)
        {
            bool sms = false;

            try
            {
                sms = Convert.ToBoolean(ProcesosCRUD.AnswerTest(IdHeaderTes,IdQuestion));
            }
            catch (Exception)
            {

            }

            return sms;
        }

        public int ValueIdTestWithPErson(int Person) {
            int a;

            a = Convert.ToInt32(ProcesosCRUD.GetIdOfTestWithPerson(Person));

            return a;
        }

        public bool EvaluaSiLaPersonatieneuntest(int Person)
        {
            bool  a = false;

            try
            {
                a = ProcesosCRUD.ValidaPacientequetengaTest(Person).Value;
            }
            catch {      }

            return a;
        }


    
    }
}
