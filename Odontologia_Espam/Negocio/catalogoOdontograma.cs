using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos.OdontologiaTableAdapters;

namespace Negocio
{

    
    public class catalogoOdontograma
    
    {
        QueriesTableAdapter ProcesosCrud = new QueriesTableAdapter();


        #region Odontograma Crud Y otros MEtodos


        public int InsertarOdontograma(Odontograma Odo)
        {

            SpInsertarOdontogramaTableAdapter objInsertarOdontograma = new SpInsertarOdontogramaTableAdapter();

            int id = 0;

            try
            {
                id = Convert.ToInt16(objInsertarOdontograma.GetData(Odo.idPersona, Odo.FechaCreacion).Select(x => x.Column1).First().ToString());
            }
            catch { }
            return id;
        }

        public string EliminarOdontograma(int par_IdPErsona)
        {

            string sms = "Eliminado Correctamente";

            try
            {
                ProcesosCrud.SpEliminarOdontograma(par_IdPErsona);
            }
            catch (Exception e) { sms = e.Message; }
            return sms;
        }



        public string ModificarOdontograma(Odontograma Odo)
        {

            string sms = "Actualizado Correctamente";

            try
            {
                ProcesosCrud.SpModificarOdontograma(Odo.idOdontograma,Odo.idPersona , Odo.FechaCreacion);
            }
            catch (Exception e) { sms = e.Message; }
            return sms;
        }

        public int idOdontogramaXPErsona(int parIdPersona) {
            int valor = 0;

            try
            {
                valor = ConsultarOdontgramas().Where(x => x.idPersona == parIdPersona).First().idOdontograma;
            }
            catch 
            {
                
             
            }

            return valor;
        
        }





        public List<Odontograma> ConsultarOdontgramas() {

            List<Odontograma> lista = new List<Odontograma>();
            SpConsultarOdontogramaTableAdapter obtOdon = new SpConsultarOdontogramaTableAdapter();
 
            try
            {

                foreach (var item in obtOdon.GetData().ToList())
                {
                    lista.Add(new Odontograma(item.IdOdontograma,item.IdPersona,item.FechaCreacion)); 
                }

            }
            catch  {   }
           
            return lista; 
        
        }


        #endregion 


        #region Odontograma Dientes  Crud Y otros MEtodos


        public string InsertarOdontogramaDiente(OdontogramaDiente Odo)
        {
            string sms = "Inserseccion de Datos Completados";

            try
            {
                ProcesosCrud.SpInsertarOdontogramaDiente(Odo.IdOdontograma,Odo.IdCodDiente, Odo.EstadoDiente , Odo.FechaDeCreacion);
            }
            catch (Exception e) { sms = e.Message; }


            return sms;
        }




        public string ModificarOdontogramaDiente(OdontogramaDiente Odo)
        {

            string sms = "Actualizado Correctamente";

            try
            {
                ProcesosCrud.SpModificarOdontogramaDiente(Odo.IdOdontograma,Odo.IdCodDiente, Odo.EstadoDiente , Odo.FechaDeCreacion);
            }
            catch { sms = "No Existe el registro que desa Modificar"; }
            return sms;
        }


        public List<OdontogramaDiente> ConsultarOdontgramaDiente(int par_IdOdontograma, int par_IdDiente)
        {

            List<OdontogramaDiente> lista = new List<OdontogramaDiente>();
            SpConultarOdontogramaDienteTableAdapter Dientes = new SpConultarOdontogramaDienteTableAdapter();

            try
            {

                foreach (var item in Dientes.GetData(par_IdOdontograma,par_IdDiente).ToList())
                {
                    lista.Add(new OdontogramaDiente(item.IdOdontograma,item.IdCodDiente,item.EstadoDiente,item.FechaDeCreacion) );
                }

            }
            catch { }

            return lista;

        }



        public List<OdontogramaDiente> ConsultarOdontgramaDiente(int par_IdOdontograma)
        {

            List<OdontogramaDiente> lista = new List<OdontogramaDiente>();
            SpConultarOdontogramaDientePorIdTableAdapter Dientes = new SpConultarOdontogramaDientePorIdTableAdapter();

            try
            {

                foreach (var item in Dientes.GetData(par_IdOdontograma).ToList())
                {
                    lista.Add(new OdontogramaDiente(item.IdOdontograma, item.IdCodDiente, item.EstadoDiente, item.FechaDeCreacion));
                }

            }
            catch { }

            return lista;

        }




        #endregion 

        
        #region Odontograma Dientes  Crud Y otros MEtodos


        public string InsertarOdontogramaDienteProcedimiento(OdonDienteProcedimiento Odo)
        {
            string sms = "Inserseccion de Procedimiento Completado";

            try
            {
                ProcesosCrud.SpInsertarOdontogramaDienteProcedimientos(Odo.IdOdontograma,Odo.IdDiente,Odo.EstadoLunaCentral,Odo.EstadoLunaSuperior,Odo.EstadoLunaInferior
                    ,Odo.EstadoLunaDerecha,Odo.EstadoLunaIzquierda,Odo.FechaDeCreacionParte,Odo.Observaciones);
            }
            catch (Exception e) { sms = e.Message; }


            return sms;
        }

        public string EliminarOdontogramaDienteProcedimientoXID(int par_parteDEntal)
        {

            string sms = "Eliminado Correctamente";

            try
            {
                ProcesosCrud.SpEliminarOdontogramaDienteProcedimientos(par_parteDEntal);
            }
            catch  { sms = "Existe un Registro Relacionado con el Que Desea Borrar"; }
            return sms;
        }


        public string EliminarOdontogramaDienteProcedimientoxForegkey(int par_IdOdontograma, int par_IdDiente)
        {

            string sms = "Eliminado Correctamente";

            try
            {
                ProcesosCrud.SpEliminarProcemientoOdontoXClavesForeaneas(par_IdOdontograma,par_IdDiente);
            }
            catch  { sms = "Existe un Registro Relacionado con el Que Desea Borrar"; }
            return sms;
        }


        public string ModificarOdontogramaDienteProcedimiento(OdonDienteProcedimiento Odo)
        {

            string sms = "Actualizado Correctamente";

            try
            {
                ProcesosCrud.SpModificarOdontogramaDienteProcedimientos(Odo.IdParteDental,Odo.IdOdontograma, Odo.IdDiente, Odo.EstadoLunaCentral, Odo.EstadoLunaSuperior, Odo.EstadoLunaInferior
                    , Odo.EstadoLunaDerecha, Odo.EstadoLunaIzquierda, Odo.FechaDeCreacionParte, Odo.Observaciones);

            }
            catch { sms = "No Existe el registro que desa Modificar"; }
            return sms;
        }


        public List<OdonDienteProcedimiento> ConsultarOdontgramaDienteProcedimientoUltimaFecha(int par_IdOdontograma, int par_IdDiente)
        {

            List<OdonDienteProcedimiento> lista = new List<OdonDienteProcedimiento>();
            SpConultarOdontogramaDienteProcedimientosTableAdapter obt = new SpConultarOdontogramaDienteProcedimientosTableAdapter();

            try
            {

                foreach (var Odo in obt.GetData(par_IdOdontograma, par_IdDiente).ToList())
                {
                    lista.Add(new OdonDienteProcedimiento(Odo.IdParteDental, Odo.IdOdontograma, Odo.IdDiente, Odo.EstadoLunaCentral, Odo.EstadoLunaSuperior, Odo.EstadoLunaInferior
                    , Odo.EstadoLunaDeracha, Odo.EstadoLunaIzquierda, Odo.FechaDeCreacionParte,Odo.Observaciones));
                }

            }
            catch { }

            return lista;

        }

        public List<OdonDienteProcedimiento> ConsultarOdontgramaDienteTodoslosDelaPersona(int par_IdOdontograma, int par_IdDiente)
        {

            List<OdonDienteProcedimiento> lista = new List<OdonDienteProcedimiento>();
            SpConultarOdontogramaDienteProcedimientosTotalesTableAdapter obt = new SpConultarOdontogramaDienteProcedimientosTotalesTableAdapter();

            try
            {

                foreach (var Odo in obt.GetData(par_IdOdontograma, par_IdDiente).ToList())
                {
                    lista.Add(new OdonDienteProcedimiento(Odo.IdParteDental, Odo.IdOdontograma, Odo.IdDiente, Odo.EstadoLunaCentral, Odo.EstadoLunaSuperior, Odo.EstadoLunaInferior
                    , Odo.EstadoLunaDeracha, Odo.EstadoLunaIzquierda, Odo.FechaDeCreacionParte, Odo.Observaciones));
                }

            }
            catch { }

            return lista;

        }


        public List<OdonDienteProcedimiento> ConsultarEstadoDientePRimeraVez(int par_IdOdontograma, int par_IdDiente)
        {

            List<OdonDienteProcedimiento> lista = new List<OdonDienteProcedimiento>();
            SpConOdontogramaProcediPrimeraVezTableAdapter obt = new SpConOdontogramaProcediPrimeraVezTableAdapter();

            try
            {

                foreach (var Odo in obt.GetData(par_IdOdontograma, par_IdDiente).ToList())
                {
                    lista.Add(new OdonDienteProcedimiento(Odo.IdParteDental, Odo.IdOdontograma, Odo.IdDiente, Odo.EstadoLunaCentral, Odo.EstadoLunaSuperior, Odo.EstadoLunaInferior
                    , Odo.EstadoLunaDeracha, Odo.EstadoLunaIzquierda, Odo.FechaDeCreacionParte, Odo.Observaciones));
                }

            }
            catch { }

            return lista;

        }

        public List<OdonDienteProcedimiento> ConsultarOdontgramaDienteProcesosPorSuId(int par_idPArteDental)
        {

            List<OdonDienteProcedimiento> lista = new List<OdonDienteProcedimiento>();
            SpConultarOdontogramaDienteProcedimientosXsuIDTableAdapter obt = new SpConultarOdontogramaDienteProcedimientosXsuIDTableAdapter();

            try
            {

                foreach (var Odo in obt.GetData(par_idPArteDental).ToList())
                {
                    lista.Add(new OdonDienteProcedimiento(Odo.IdParteDental, Odo.IdOdontograma, Odo.IdDiente, Odo.EstadoLunaCentral, Odo.EstadoLunaSuperior, Odo.EstadoLunaInferior
                    , Odo.EstadoLunaDeracha, Odo.EstadoLunaIzquierda, Odo.FechaDeCreacionParte, Odo.Observaciones));
                }

            }
            catch { }

            return lista;

        }


        #endregion 

        public bool ExisteOdontograma(int par_idPersona)
        {
            
            bool estado = false;

            try
            {
                estado = ProcesosCrud.Valida_QueElPAcienteTEngaOdontograma(par_idPersona).Value;
            }
            catch { }
            return estado;
        }

        public bool ExisteOdontogramaDiente(int par_IdOdontograma,int par_IdDiente)
        {

            bool estado = false;

            try
            {
                estado = ProcesosCrud.ExistenciaDienteOdontograma(par_IdOdontograma,par_IdDiente).Value;
            }
            catch { }
            return estado;
        }



    }



}
