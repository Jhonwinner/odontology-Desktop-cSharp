using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Canton
    {
       public int id_canton { set; get; }
       public int id_prov { set; get; }
       public string cantones { set; get; }

       public Canton (int ID_CANTON, int ID_PROVINCIA, string CANTONES)
       {
           this.id_canton = ID_CANTON;
           this.id_prov = ID_PROVINCIA;
           this.cantones = CANTONES;
       }
       public Canton( string CANTONES)
       {
           this.cantones = CANTONES;
       }
    }
}
