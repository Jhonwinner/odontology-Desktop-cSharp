using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Persona_other
    {
       private int var_id_otherpersona { set; get; }       
       private string var_Cedula_identidad { set; get; }
       private string var_Nombres { set; get; }
       private string var_Apellidos { set; get; }
       private string var_provincia { set; get; }
       private string var_canton { set; get; }
       private string var_Direccion { set; get; }
       private DateTime var_Fecha_nacimiento { set; get; }
       private string var_Tipo_User { set; get; }
       private string var_telefono { set; get; }
       private string var_correo { set; get; }
       private string var_Genero { set; get; }

       public Persona_other(int id_other_Persona, string var_Cedula, string var_Nombres_Database, string var_Apellidos_data, string var_Direccion_Data, DateTime var_Fecha_nacimiento_Data, string var_Tipo_Data, string var_correo_data, string var_genero_Data)
       {
           this.var_id_otherpersona = id_other_Persona;
           this.var_Cedula_identidad = var_Cedula;
           this.var_Nombres = var_Nombres_Database;
           this.var_Apellidos = var_Apellidos_data;
           this.var_Direccion = var_Direccion_Data;
           this.var_Fecha_nacimiento = var_Fecha_nacimiento_Data;
           this.var_Tipo_User = var_Tipo_Data;
           this.var_correo = var_correo_data;
           this.var_Genero = var_genero_Data;

       }

    }
}
