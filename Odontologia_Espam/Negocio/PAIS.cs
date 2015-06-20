using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PAIS
    {
        public int id_pais { set; get; }
        public string pais { set; get; }

        public PAIS(int ID_PAIS, string PAIS)
        {
            this.id_pais = ID_PAIS;
            this.pais = PAIS;
        }
    }
}
