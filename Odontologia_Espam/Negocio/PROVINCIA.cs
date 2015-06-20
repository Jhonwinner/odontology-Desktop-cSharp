using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class PROVINCIA
    {
       public int id_prov { set; get; }
       public string provincia { set; get; }
       public int id_nacion { set; get; }

       public PROVINCIA(int ID_PROVINCIA, string PROVINCIA,int id_nacion_)
       {
           this.id_prov = ID_PROVINCIA;
           this.provincia = PROVINCIA;
           this.id_nacion = id_nacion; 
       }
       
       public PROVINCIA(int ID_PROVINCIA, string PROVINCIA)
       {
           this.id_prov = ID_PROVINCIA;
           this.provincia = PROVINCIA;
        
       }
    

    }
}
