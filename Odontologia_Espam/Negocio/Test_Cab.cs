using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Test_Cab
    {
        public int id_test { set; get; }
        public  int id_historia { set; get; }
        public  DateTime fecha_test { set; get; }

        public Test_Cab(int ID_TEST, int ID_HISTORIA, DateTime FECHA_TEST)
        {
            this.id_test = ID_TEST;
            this.id_historia = ID_HISTORIA;
            this.fecha_test = FECHA_TEST;
        }

        public Test_Cab(int ID_HISTORIA)
        {
             this.id_historia = ID_HISTORIA;
           
        }
    }
}
