using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Partes_de_Dientes
    {
        private int id_partes  { set; get; }
        private int id_odontograma { set; get; }
        private string nombre_parte { set; get; }

        public Partes_de_Dientes(int ID_PARTES, int ID_ODONTOGRAMA, string NOMBRE_PARTE)
        {
            this.id_partes = ID_PARTES;
            this.id_odontograma = ID_ODONTOGRAMA;
            this.nombre_parte = NOMBRE_PARTE;
        }
    }
}
