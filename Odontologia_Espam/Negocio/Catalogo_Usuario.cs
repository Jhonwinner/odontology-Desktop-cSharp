using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos.OdontologiaTableAdapters;


namespace Negocio
{
   public  class Catalogo_Usuario
    {
        QueriesTableAdapter Procesos_DAtabase = new QueriesTableAdapter();

        public bool ValidarLogin(string par_user, string par_Pass)
        {
            bool ESTADO = false;
            spLoginTableAdapter consultarLogin = new spLoginTableAdapter();

            try
            {
                foreach (var item in consultarLogin.GetData(par_user, par_Pass))
                {
                    ESTADO = true;
                }
            }
            catch (Exception)
            {
            }
            return ESTADO;
        }

        public void Numero_SEsiones(Usuario Usua)
        {
            Procesos_DAtabase.Numero_Sesiones(Usua.codigo_usuario);
        }

        public string ConsultarNombreDeUsuarioPorid(int  par_IdUsuario) {

            string sms = "";

            try
            {
                sms = ConsultarTodosLosUsuarios().Where(x => x.codigo_usuario == par_IdUsuario).First().usuario; 
            }
            catch (Exception e)
            {
                sms = e.Message; 
            }

            return sms;
        
        }


        public string InsertaLogSesion(int par_IdUsuario)
        {

            string sms = "";

            try
            {
               Procesos_DAtabase.spInsertarLogSesiones(par_IdUsuario);
            }
            catch (Exception e)
            {
                sms = e.Message;
            }

            return sms;

        }
        public string ModficarContraseania(int par_Idsesion,string ContraseniaActual,string ContraseniaNueva) {

            string sms = "Datos Actualizados Correctamente";

            try
            {
                if (ContraseniaActual == ConsultarTodosLosUsuarios().Where(x => x.codigo_usuario == par_Idsesion).First().password)
                {
                    Procesos_DAtabase.PA_Modify_Usuario(par_Idsesion,ConsultarNombreDeUsuarioPorid(par_Idsesion), ContraseniaNueva);
                }
                else
                {
                    sms = "  ♦♦  La contraseña ingresada No coincide con la de la sesion Actual ♦♦";
                }
                
            }
            catch (Exception x)
            {
                sms = x.Message;                 
            }

            return sms;
        
        }


        public bool Funt_Validacion_user(Usuario User) {

              bool estado = false;
              try
              {
                  if (Procesos_DAtabase.Valida_Login(User.usuario, User.password).Value == true)
                  {
                      estado = true;

                  }


              }
              catch (Exception)
              {
                  
                 
              }
            
            return estado;
        }

        public int Funt_retorna_ID(Usuario Users)
        {

            int id_Usuario = 0;

            id_Usuario = Convert.ToInt16( Procesos_DAtabase.Capta_ID_User_login(Users.usuario,Users.password));

            return id_Usuario;
        }

        public string Funt_Retorna_NOmbre_Inicia_Sesion(int par_IdUsuario) {

            return Procesos_DAtabase.Genera_Nombre_Sesion(par_IdUsuario);
        
        }

        public string Retorna_Cantidad_de_Sesiones(int par_IdUsuario)
        {
            int Num;
            Num = Convert.ToInt16(Procesos_DAtabase.Funt_cantidad_sesiones(par_IdUsuario));
            return Num.ToString();

        }

        public void Fun_Ingresar_Error(Reporta_Error Error_Report) {

            try
            {
                Procesos_DAtabase.PA_Insert_Error(Error_Report.Cod_User,Error_Report.Descripcion_Del_Error);

            }
            catch (Exception)
            {
            }
        
        }

        public List<Usuario> ConsultarTodosLosUsuarios() {

            PA_Consulta_UsuarioTableAdapter ConsultarUsuario = new PA_Consulta_UsuarioTableAdapter();
            List<Usuario> Lista = new List<Usuario>();

            try
            {
                foreach (var item in ConsultarUsuario.GetData().ToList())
                {
                    Lista.Add(new Usuario(item.Cod_Usuario,item.Usuario,item.Pass));
                }
            }
            catch (Exception)
            {
               
            }

            return Lista; 
        }


    }
}
