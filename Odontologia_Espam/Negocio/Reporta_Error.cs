using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Reporta_Error
    {
        public int  Id_Error;
        public DateTime Hora_registro_Error;
        public DateTime Fecha_registro_Error;
        public int Cod_User;
        public string Descripcion_Del_Error;

        public Reporta_Error(int Id_error_Nego, DateTime Hora_registro_Error_Nego, DateTime Fecha_registro_Error_Nego,int  Cod_User_Nego,string Descripcion_NEgo)
        {
            this.Id_Error = Id_error_Nego;
            this.Hora_registro_Error = Hora_registro_Error_Nego;
            this.Fecha_registro_Error = Fecha_registro_Error_Nego;
            this.Cod_User = Cod_User_Nego;
            this.Descripcion_Del_Error = Descripcion_NEgo;
        
        }

        public Reporta_Error( int Cod_User_Nego, string Descripcion_NEgo)
        {
            this.Cod_User = Cod_User_Nego;
            this.Descripcion_Del_Error = Descripcion_NEgo;

        }


    }
}
