using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class OdontogramaDiente
    {
        public int IdOdontograma { set; get;}
        public int IdCodDiente { set; get; }
        public int EstadoDiente { set; get; }
        public DateTime FechaDeCreacion { set; get; }


        public OdontogramaDiente(int par_IdOdontograma, int par_IdCodDiente, int par_EstadoDiente, DateTime par_FechaDeCreacion)
        {
            this.IdOdontograma = par_IdOdontograma;
            this.IdCodDiente = par_IdCodDiente;
            this.EstadoDiente = par_EstadoDiente;
            this.FechaDeCreacion = par_FechaDeCreacion; 
        
        }
    }
}
