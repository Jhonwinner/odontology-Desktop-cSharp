using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos.OdontologiaTableAdapters;

namespace Negocio
{
  
     
    public class Catalogo_Historia
    {
        QueriesTableAdapter procesos = new QueriesTableAdapter();


        public string NombreDoctorIdDoctor(int parIdDoctor) {

            string sms = "";

            try
            {
                sms = procesos.NombreDelDoctorSegunSuID(parIdDoctor);
            }
            catch 
            {
                
            }

            return sms;
        }
        public int InsertarHistoriaClinica(Historia_clinica History) {
            int a = 0;
            PA_Insert_Historia_ClinicaTableAdapter Inserccion = new PA_Insert_Historia_ClinicaTableAdapter();

            try
            {
                foreach (var item in Inserccion.GetData(History.id_persona,History.alergias,History.diagnostico))
                {
                    a = Convert.ToInt16(item.Column1.ToString());
                }     
            }
            catch (Exception)
            {
                
            }
            return a;

        }


        public int NumberofHistory(int IdPerson) { 
         
        int a =   0 ;
        
            try
          {
              a = Convert.ToInt32(procesos.IdHistoryClinicForPerson(IdPerson));
          }
          catch (Exception)
          {
             
          }
          return a;


        }



        public int NumerodeConsulta(int Consulta)
        {

            int a = 0;

            try
            {
                a = ConsultarLasConsultas(Consulta).Count() + 1;
            }
            catch (Exception)
            {

            }
            return a;


        }

        public int NumerodeConsultaTotales()
        {

            int a = 0;

            try
            {

                a =Convert.ToInt32(procesos.fc_TodasLasConsultas());
              
            }
            catch (Exception)
            {

            }
            return a;


        }


        public int IdDoctor_Usuario(int par_IdUsusario)
        {
           int a = 0;

            try
            {

                a = procesos.funcionIdDoctor_IdUser(par_IdUsusario).Value;

            }
            catch (Exception)
            {

            }
            return a;


        }


        public string InsertConsultas(Consulta Cons) {


            string sms = "Ingreso de La consulta  correcto";
            
             try
 
	        {

                procesos.spInsertarConsulta(Cons.id_historia,Cons.id_consulta,Cons.FechaHoraInicio,Cons.FechaHoraFin,Cons.Detalles_Consulta,Cons.status,Cons.idUsuario);
               	        
             }
	
             catch (Exception e)
             {
                 sms = e.Message;
             
             }
           
   
         return sms;
        
        }

        public string ModificarConsultas(Consulta Cons)
        {


            string sms = "Modificacion Realizada Correctamente";

            try
            {

               procesos.spModificarConsulta(Cons.id_historia, Cons.id_consulta, Cons.FechaHoraInicio, Cons.FechaHoraFin, Cons.Detalles_Consulta, Cons.status);

            }

            catch (Exception e)
            {
                sms = e.Message;

            }


            return sms;

        }


        public string EliminarConsultas(int par_idHistoria,int par_idDetalle)
        {


            string sms = "Eliminacion Realizada Correctamente";

            try
            {

                procesos.PA_Elimina_Consulta(par_idHistoria,par_idDetalle);

            }

            catch (Exception e)
            {
                sms = e.Message;

            }


            return sms;

        }

        public List<Consulta> ConsultarLasConsultas(int id_historia) {

            List<Consulta> list = new List<Consulta>();
            spConsultarConsultaTableAdapter Consultas = new spConsultarConsultaTableAdapter();

            try
            {
                foreach (var item in Consultas.GetData(id_historia).ToList())
                {
                    list.Add(new Consulta(item.Id_historia,item.Id_consulta,item.Detalles_Consulta,item.FechaHoraInicio,item.FechaHoraFin,item.Statuss));
                }
            }
            catch (Exception)
            {
                
            }
            return list;

        }



        public List<Consulta> ConsultarLasConsultasPorFecha(DateTime FechaInicio, DateTime FechaFin)
        {

            List<Consulta> list = new List<Consulta>();
            spConsultarEnetreFechasLasCitasTableAdapter Consultas = new spConsultarEnetreFechasLasCitasTableAdapter();

            try
            {
                foreach (var item in Consultas.GetData(FechaInicio, FechaFin).ToList())
                {
                    list.Add(new Consulta(item.Id_historia, item.Id_consulta, item.Detalles_Consulta, item.FechaHoraInicio, item.FechaHoraFin, item.Statuss));
                }
            }
            catch (Exception)
            {

            }
            return list;

        }


        public int ValorMaximoDeConsulta(int par_IdHistoria) {

            int loc_Valor = 0;
            spObtenerNumeroDeConsultaMAximoTableAdapter obt = new spObtenerNumeroDeConsultaMAximoTableAdapter();

            try
            {
                loc_Valor = obt.GetData(par_IdHistoria).First().Column1;
            }
            catch 
            {
            }

            return loc_Valor;
        }



        public int IdHistoriaClinicaPorOdontograma(int par_IdOdontograma)
        {

            int loc_Valor = 0;
            spObtenerNumeroDeHistoriaTableAdapter obt = new spObtenerNumeroDeHistoriaTableAdapter(); 

            try
            {
                loc_Valor = obt.GetData(par_IdOdontograma).First().Id_historia;
            }
            catch
            {
            }

            return loc_Valor;
        }


        public List<Consulta> ConsultarLasConsultaEspecifica(int id_historia,int par_IdConsulta)
        {

            List<Consulta> list = new List<Consulta>();
            spConsultarConsultaXidHandIdCTableAdapter consultass = new spConsultarConsultaXidHandIdCTableAdapter();

            try
            {
                foreach (var item in consultass.GetData(id_historia,par_IdConsulta).ToList())
                {
                    list.Add(new Consulta(item.Id_historia,item.Id_consulta,item.Detalles_Consulta,item.FechaHoraInicio,item.FechaHoraFin,item.Statuss,item.IdUsuario));
                }
            }
            catch (Exception)
            {

            }
            return list;

        }


    }
}
