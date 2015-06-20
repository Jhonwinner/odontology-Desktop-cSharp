using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Persona
    {
        public int var_Id_persona { set; get;}
        public string var_Cedula_identidad { set; get; }
        public string var_Nombres { set; get; }
        public string var_Apellidos { set; get; }
        public int? var_nacionalidad { set; get; }
        public int var_provincia { set; get; }
        public int var_canton { set; get; }
        public string var_Direccion { set; get; }
        public DateTime var_Fecha_nacimiento { set; get; }
        public string var_Tipo_User { set; get; }
        public string var_telefono { set; get; }
        public string var_correo { set; get; }
        public string var_Genero { set; get; }
        public int var_codigo_usuario { set; get; }
        public byte[] Photho {set; get;}
        public string var_nacionalidadRemota { set; get; }


       public Persona(int id_Persona, string Cedula, string var_Nombre, string var_Apellido, string nacion, string Direccion, DateTime Fecha_nacimiento, string genero, string telefon, string correo)
       {
           this.var_Id_persona = id_Persona;
           this.var_Cedula_identidad = Cedula;
           this.var_Nombres = var_Nombre;
           this.var_Apellidos = var_Apellido;
           this.var_nacionalidadRemota = nacion;
           this.var_Direccion = Direccion;
           this.var_Fecha_nacimiento = Fecha_nacimiento;
           this.var_Genero = genero;
           this.var_telefono = telefon;
           this.var_correo = correo;



       }


       public Persona(int id_Persona, string Cedula, string var_Nombre, string var_Apellido, int? nacion, int prov, int CantoN, string Direccion, DateTime Fecha_nacimiento, string Tipo, string telefon, string correo, string genero)
        {
            this.var_Id_persona = id_Persona;
            this.var_Cedula_identidad = Cedula;
            this.var_Nombres = var_Nombre;
            this.var_Apellidos = var_Apellido;
            this.var_nacionalidad = nacion;
            this.var_provincia = prov;
            this.var_canton = CantoN;
            this.var_Direccion = Direccion;
            this.var_Fecha_nacimiento = Fecha_nacimiento;
            this.var_Tipo_User = Tipo;
            this.var_telefono = telefon;
            this.var_correo = correo;
            this.var_Genero = genero;
          
        
        }
        public Persona(string Cedula)
        {
           this.var_Cedula_identidad = Cedula;
        
        }

        public Persona(string Cedula,string Nombre)
        {
            this.var_Cedula_identidad = Cedula;
            this.var_Nombres = Nombre;
            

        }
 
 

    }
}
