using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class Ordenes_Examen
    {


        public int cod_ordenes { set; get; }
         public  DateTime Fecha_de_Envio {set;get;}
         public  DateTime Fecha_recepcion  {set;get;}
         public  string status {set;get;}
         public string Descp_Exam { set; get; }
         public string Resultad {set;get;}
         public int Id_historia {set;get;}
         public int Id_Consulta { set; get;}

         public Ordenes_Examen(DateTime Fecha_de_Envio_, DateTime Fecha_recepcion_, string status_,string Descp, string Resultad_, int Id_historia_, int Id_Consulta_)
         {

             this.Fecha_de_Envio = Fecha_de_Envio_;
             this.Fecha_recepcion = Fecha_recepcion_;
             this.status = status_;
             this.Descp_Exam = Descp;
             this.Resultad = Resultad_;
             this.Id_historia = Id_historia_;
             this.Id_Consulta = Id_Consulta_;
         
         }

         public Ordenes_Examen( int Id_historia_)
         {

             this.Id_historia = Id_historia_;
           
         }
         public Ordenes_Examen(int Id_historia_,int id_Consulta)
         {

             this.Id_historia = Id_historia_;
             this.Id_Consulta = id_Consulta;

         }


    }
}
