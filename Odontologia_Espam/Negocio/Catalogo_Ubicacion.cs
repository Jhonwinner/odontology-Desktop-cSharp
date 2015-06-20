using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos.OdontologiaTableAdapters;

namespace Negocio
{
   public class Catalogo_Ubicacion
    {


      
      
       public List<PAIS> CONSULTAR_PAIS()
       {
           List<PAIS> LISTA = new List<PAIS>();
           CONSULTA_PAISTableAdapter CONS_PAIS = new CONSULTA_PAISTableAdapter();

           foreach (var item in CONS_PAIS.GetData().ToList())
           {
               LISTA.Add(new PAIS(item.id_nacion, item.nacionalidad));
           }
           return LISTA;
       }


       public List<PROVINCIA> CONSULTAR_PROVINCIAS(int IDD)
       {
           List<PROVINCIA> LISTA = new List<PROVINCIA>();
           CONSULTAR_PAIS_PROVTableAdapter PAIS_PROV = new CONSULTAR_PAIS_PROVTableAdapter();

           foreach (var item in PAIS_PROV.GetData(IDD).ToList())
           {
               LISTA.Add(new PROVINCIA(item.id_provincia, item.Provincia));
           }
           return LISTA;
       }

       public List<PROVINCIA> ConsultarProvincias()
       {
           List<PROVINCIA> LISTA = new List<PROVINCIA>();
           CONSULTA_PROVINCIATableAdapter Provincias = new CONSULTA_PROVINCIATableAdapter();

           foreach (var item in Provincias.GetData().ToList())
           {
               LISTA.Add(new PROVINCIA(item.id_provincia, item.Provincia,item.id_nacion));
           }
           return LISTA;
       }

       public List<Canton> CONSULTAR_CANTONES(int ID_P)
       {
           List<Canton> LISTA = new List<Canton>();
           PROVINCIA_CANTONTableAdapter PROV_CANT = new PROVINCIA_CANTONTableAdapter();

           foreach (var item in PROV_CANT.GetData(ID_P).ToList())
           {
               LISTA.Add(new Canton(item.id_canton,item.id_provincia,item.cantones));
           }
           return LISTA;
       }

       public List<Canton> ConsultarCaontones()
       {
           List<Canton> LISTA = new List<Canton>();
           CONSULTA_CANTONTableAdapter Cantones = new CONSULTA_CANTONTableAdapter();

           foreach (var item in Cantones.GetData().ToList())
           {
               LISTA.Add(new Canton(item.id_canton, item.id_provincia, item.cantones));
           }
           return LISTA;
       }



       public string NombreDeProvincia(int par_IdProvincia) {

           string sms="";
           try
           {
               sms = ConsultarProvincias().Where(x => x.id_prov == par_IdProvincia).First().provincia;
           }
           catch (Exception)
           {
           }

           return sms;
            
        }

       public string NombreDeCanton(int par_IdProvincia, int par_IdCanton)
       {

           string sms = "";
           try
           {
               sms = CONSULTAR_CANTONES(par_IdProvincia).Where(c => c.id_canton == par_IdCanton).First().cantones;
           }
           catch (Exception)
           {
           }

           return sms;

       }

       public string NombreDePais(int par_IdPais)
       {

           string sms = "";
           try
           {
               sms = CONSULTAR_PAIS().Where(x => x.id_pais == par_IdPais).First().pais;
           }
           catch (Exception)
           {
           }

           return sms;

       }

       public int  IdDeProvincia(string parProvincia)
       {

           int  sms = 0 ; 
           try
           {
               sms = ConsultarProvincias().Where(x => x.provincia == parProvincia).First().id_prov;
           }
           catch (Exception)
           {
           }

           return sms;

       }

       public int IdDeCanton(string par_Canton)
       {

           int sms = 0;
           try
           {
               sms = ConsultarCaontones().Where(x => x.cantones == par_Canton).First().id_canton;
           }
           catch (Exception)
           {
           }

           return sms;

       }

       public int IdDePais(string par_Pais)
       {

           int sms =0;
           try
           {
               sms = CONSULTAR_PAIS().Where(x => x.pais == par_Pais).First().id_pais;
           }
           catch (Exception)
           {
           }

           return sms;

       }




    }
}
