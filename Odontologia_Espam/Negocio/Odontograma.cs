using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Odontograma
    {
        public int idOdontograma { set; get; }
        public int idPersona     { set; get; }
        public DateTime FechaCreacion { set; get; }


        public Odontograma(int par_idOndontograma,int par_IdPErsona , DateTime par_fechaCreacion) {

            this.idOdontograma = par_idOndontograma;
            this.idPersona = par_IdPErsona;
            this.FechaCreacion = par_fechaCreacion; 
        
        }


    }
}
