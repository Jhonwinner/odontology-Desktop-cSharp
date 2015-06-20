using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Historia_clinica
    {
      public int id_historia { set; get; }
       public  int id_persona { set; get; }
       public  int cantidad_consultas { set; get; }
       public  DateTime fecha_creacionhistoria { set; get; }
       public  string alergias { set; get; }
       public string diagnostico { set; get; }

       public Historia_clinica(int ID_HISTORIA, int ID_PERSONA, int CANTIDAD_CONS, DateTime FECHA_CREACION, string ALERGIAS, string DIAGNOSTICO)
       {
           this.id_historia = ID_HISTORIA;
           this.id_persona = ID_PERSONA;
           this.cantidad_consultas = CANTIDAD_CONS;
           this.fecha_creacionhistoria = FECHA_CREACION;
           this.alergias = ALERGIAS;
           this.diagnostico = DIAGNOSTICO;
       }


       public Historia_clinica(int ID_PERSONA, string ALERGIAS, string DIAGNOSTICO)
       {
           
           this.id_persona = ID_PERSONA;
           this.alergias = ALERGIAS;
           this.diagnostico = DIAGNOSTICO;
       }


    }
}
