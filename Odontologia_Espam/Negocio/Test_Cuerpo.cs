using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Test_Cuerpo
    {
       public int id_test_cab { set; get; }
       public int id_test_cuerpo { set; get; }
       public int  pregunta { set; get; }
       public bool respuesta { set; get; }


       public Test_Cuerpo(int id_cab, int id_detalle, int pregunt, bool respuest)
       {
           this.id_test_cab = id_cab;
           this.id_test_cuerpo = id_detalle;
           this.pregunta = pregunt;
           this.respuesta = respuest;
       }

       public Test_Cuerpo(int id_cab, int id_detalle, int pregunt)
       {
           this.id_test_cab = id_cab;
           this.id_test_cuerpo = id_detalle;
           this.pregunta = pregunt;
          
       }


       public Test_Cuerpo(int id_cab)
       {
           this.id_test_cab = id_cab;
         
       }
      
    }
}
