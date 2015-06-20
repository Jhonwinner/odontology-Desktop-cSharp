using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos.OdontologiaTableAdapters;

namespace Negocio
{
    public class Catalogo_Persona
    {
        QueriesTableAdapter procesos_database = new QueriesTableAdapter();
               

        public List<Persona> Busca_PErsona_CI_Historia(Persona Pr)
        {
            List<Persona> lista = new List<Persona>();
            PA_Consulta_PersonaTableAdapter Search_person = new PA_Consulta_PersonaTableAdapter();

            try
            {
                foreach (var item in Search_person.GetData(Pr.var_Cedula_identidad,Pr.var_Nombres).ToList())
                {
                    lista.Add(new Persona(item.Id_persona, item.CI, item.Nombres, item.Apellidos, item.Cod_Nacionalidad, item.Cod_Provincia, item.Cod_Canton, item.Direccion, item.Fecha_Naci, item.Tipo, item.Telefono, item.Correo_electronico, item.Genero));
                }

            }
            catch (Exception)
            {
            
            }


            return lista;
        }

        public List<Persona> Busca_PErsona_X_ID(int variable)
        {
            SpBuscarAlumnosxIDTableAdapter PersonasxId = new SpBuscarAlumnosxIDTableAdapter();

            List<Persona> lista = new List<Persona>();
            try
            {
                foreach (var item in PersonasxId.GetData(variable).ToList())
                {
                    lista.Add(new Persona(item.Id_Persona, item.Cedula, item.Nombres, item.Apellidos, item.Nacionalidad, item.Direccion, item.Fecha_Nac, item.Genero, item.Telefono_C, item.Email));
                }

            }
            catch (Exception)
            {

            }


            return lista;
        }


        public string NombreDelPAciente(int par_idPersona) {

            string sms = "";

            try
            {
                sms = Busca_PErsona_CI_Nombre_Base_Local(par_idPersona).Where(x => x.var_Id_persona == par_idPersona).First().var_Nombres;
                sms = sms + " " + Busca_PErsona_CI_Nombre_Base_Local(par_idPersona).Where(x => x.var_Id_persona == par_idPersona).First().var_Apellidos;
 
            }
            catch (Exception)
            {
                
            }

            return sms; 
        
        }

        public List<Persona> Busca_PErsona_CI_Nombre_Base_Remota(Persona Pr)
        {
            List<Persona> lista = new List<Persona>();
            SpBuscarAlumnosTableAdapter BuscarAlumnoUniver = new SpBuscarAlumnosTableAdapter();

            try
            {
                foreach (var item in BuscarAlumnoUniver.GetData(Pr.var_Cedula_identidad, Pr.var_Nombres).ToList())
                {
                    lista.Add(new Persona(item.Id_Persona,item.Cedula,item.Nombres,item.Apellidos,item.Nacionalidad,item.Direccion,item.Fecha_Nac,item.Genero,item.Telefono_C,item.Email));
                }

            }
            catch (Exception)
            {

            }


            return lista;
        }

        public List<Persona> Busca_PErsona_CI_Nombre_Base_Local(int ids)
        {
            List<Persona> lista = new List<Persona>();
            SpConsultaPersonaIDTableAdapter BuscarAlumnoUniver = new SpConsultaPersonaIDTableAdapter();

            try
            {
                foreach (var item in BuscarAlumnoUniver.GetData(ids).ToList())
                {
                    lista.Add(new Persona(item.Id_persona, item.CI, item.Nombres, item.Apellidos, item.Cod_Nacionalidad, item.Cod_Provincia, item.Cod_Canton, item.Direccion, item.Fecha_Naci, item.Tipo, item.Telefono, item.Correo_electronico, item.Genero));
                }

            }
            catch (Exception)
            {

            }


            return lista;
        }


        public List<Persona> Consulta_Top_PErsona() {

            List<Persona> Lista = new List<Persona>();
            PA_Consulta_Persona_TOp_15TableAdapter Top_Persona = new PA_Consulta_Persona_TOp_15TableAdapter();
            try
            {

                foreach (var item in Top_Persona.GetData().ToList())
                {
                    Lista.Add(new Persona(item.Id_persona, item.CI, item.Nombres, item.Apellidos, item.Cod_Nacionalidad, item.Cod_Provincia, item.Cod_Canton, item.Direccion, item.Fecha_Naci, item.Tipo, item.Telefono, item.Correo_electronico, item.Genero));
                }

            }
            catch (Exception)
            {
                
                
            }
            
            return Lista;
          
        }


        public void Eliminar_Examen(Ordenes_Examen Exa) {

            try
            {
                procesos_database.PA_Elimina_Ordenes_Examen(Exa.Id_historia, Exa.Id_Consulta);
            }
            catch (Exception)
            {
                
            }
        }


        public string  obetener_NOmbre_Paciente(Ordenes_Examen Exa)
        {
            string nombres="";

            try
            {
                nombres = procesos_database.Genera_Nombre_del_paciente(Exa.Id_historia);
            }
            catch (Exception)
            {

            }
            return nombres;

        }

        public string INGRESAR_PACIENTE(Persona PR)
        {
            string sms = " ";

            PA_Insert_PersonaTableAdapter insertpersonas = new PA_Insert_PersonaTableAdapter();

            try
            {
                foreach (var item in insertpersonas.GetData(PR.var_Cedula_identidad, PR.var_Nombres, PR.var_Apellidos, PR.var_nacionalidad, Convert.ToInt16(PR.var_provincia), Convert.ToInt16(PR.var_canton), PR.var_Direccion,
                    PR.var_Fecha_nacimiento, PR.var_Tipo_User, PR.var_telefono, PR.var_correo, PR.var_Genero))
	                {
                        sms = item.Column1.ToString();
                	}
                    
                    
                    
       
            }
            catch (Exception e)
            { 
                sms = e.Message;
            }

            return sms;
        }



        public string ModifiquePatient(Persona PR)
        {
            string sms = " Datos Actualizados Correctamente ";

              

            try
            {
               
                procesos_database.PA_Modify_Persona(PR.var_Id_persona,PR.var_Cedula_identidad, PR.var_Nombres, PR.var_Apellidos, PR.var_nacionalidad, Convert.ToInt16(PR.var_provincia), Convert.ToInt16(PR.var_canton), PR.var_Direccion,
                PR.var_Fecha_nacimiento, PR.var_Tipo_User, PR.var_telefono, PR.var_correo, PR.var_Genero);
                



            }
            catch (Exception e)
            {
                sms = e.Message;
            }

            return sms;
        }



        public string DeletePatient(int parIdPErsona)
        {
            string sms = " Datos eliminados Correctamente ";



            try
            {
                procesos_database.PA_Elimina_Persona(parIdPErsona,"");
              
            }
            catch (Exception)
            {
                sms = " El paciente No puede Ser Eliminado\n Existen Registros de Historia Clinica \n y consultas Creadas";
            }

            return sms;
        }


        public void Modificar_orden(Ordenes_Examen or)
        {
            try
            {
                procesos_database.PA_Modi_Ordenes_Examen(or.Fecha_de_Envio, or.Fecha_recepcion, or.status, or.Descp_Exam, or.Resultad,Convert.ToInt16(or.Id_historia),Convert.ToInt16( or.Id_Consulta));
            }
            catch (Exception)
            {
            }
        }


        public void INGRESAR_ORdEN_CLinica(Ordenes_Examen Orden)
        {
            try
            {
                procesos_database.PA_Insert_Ordenes_Examen(Orden.Fecha_de_Envio,Orden.Fecha_recepcion,Convert.ToInt16(Orden.Id_historia),Convert.ToInt16(Orden.Id_Consulta),Orden.status,Orden.Descp_Exam,Orden.Resultad);

            }
            catch (Exception)
            {
            }
        }

        public List<Ordenes_Examen>  Consultar_30_de_todos_los_examenes() {

            List<Ordenes_Examen> lista = new List<Ordenes_Examen>();
            PA_Consulta_30_Top_Ordenes_ExamenTableAdapter Top_Examenes = new PA_Consulta_30_Top_Ordenes_ExamenTableAdapter();

            try
            {

            foreach (var item in Top_Examenes.GetData().ToList())
            {
                lista.Add(new Ordenes_Examen(item.Fecha_de_Envio,item.Fecha_recepcion,item.Status_,item.Descripcion_Envio,item.Resultados,item.Id_historia,item.Id_consulta));
            }
              }
            catch (Exception)
            {
            }
            
            return lista;
        
        }

        public bool Funcion_existe_Paciente(string Ci) {
            bool estad = false;
            estad = Convert.ToBoolean(procesos_database.Valida_Paciente_Registrado(Ci));
            return estad;
        }


        public List<Ordenes_Examen> Consultar_CI_Historia_Clinica(Ordenes_Examen O_Ex,Persona Pers)
        {

            List<Ordenes_Examen> lista = new List<Ordenes_Examen>();
            PA_Consulta_Ordenes_Examen_CI_o_HiTableAdapter Consulta_Examenes = new PA_Consulta_Ordenes_Examen_CI_o_HiTableAdapter();

            try
            {

                foreach (var item in Consulta_Examenes.GetData(Pers.var_Cedula_identidad,O_Ex.Id_historia).ToList())
                {
                    lista.Add(new Ordenes_Examen(item.Fecha_de_Envio, item.Fecha_recepcion, item.Status_, item.Descripcion_Envio, item.Resultados, item.Id_historia, item.Id_consulta));
                }
            }
            catch (Exception)
            {
            }

            return lista;

        }

        public List<Ordenes_Examen> Consultar_Para_Saber_Que_ACtualizar(Ordenes_Examen O_Ex)
        {

            List<Ordenes_Examen> lista = new List<Ordenes_Examen>();
            PA_Consulta_H_C_Ordenes_ExamenTableAdapter Consulta_Update = new PA_Consulta_H_C_Ordenes_ExamenTableAdapter();
            try
            {

                foreach (var item in Consulta_Update.GetData(O_Ex.Id_Consulta,O_Ex.Id_historia).ToList())
                {
                    lista.Add(new Ordenes_Examen(item.Fecha_de_Envio, item.Fecha_recepcion, item.Status_, item.Descripcion_Envio, item.Resultados, item.Id_historia, item.Id_consulta));
                }
            }
            catch (Exception)
            {
            }

            return lista;

        }


        private static bool VerificaCedula(string parCedula)
        {

            int loc_IsNumeric;
            var total = 0;
            const int tamanolongitud = 10;
            int[] coficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int TercerDigito = 6;



            if (int.TryParse(parCedula, out loc_IsNumeric) && parCedula.Length == tamanolongitud)
            {

                var provincia = Convert.ToInt32(string.Concat(parCedula[0], parCedula[1], string.Empty));
                var Digito3 = Convert.ToInt32(parCedula[2] + string.Empty);
                var digitoVersionRecibido = Convert.ToInt32(parCedula[9] + string.Empty);


                for (int i = 0; i < coficientes.Length; i++)
                {
                    var valor = Convert.ToInt32(coficientes[i] + string.Empty) * Convert.ToInt32(parCedula[i] + string.Empty);
                    total = valor >= 10 ? total + (valor - 9) : total + valor;
                }

                var DigitoObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                return DigitoObtenido == digitoVersionRecibido;
            }


            return false;
        }



    }
}
