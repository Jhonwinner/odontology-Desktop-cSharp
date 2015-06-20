using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OdonDienteProcedimiento
    {
        public int IdParteDental { set; get; }
        public int IdOdontograma { set; get; }
        public int IdDiente { set; get; }
        public int EstadoLunaCentral { set; get; }
        public int EstadoLunaSuperior { set; get; }
        public int EstadoLunaInferior { set; get; }
        public int EstadoLunaDerecha { set; get; }
        public int EstadoLunaIzquierda { set; get; }
        public DateTime FechaDeCreacionParte { set; get; }
        public string Observaciones { set; get; }

        public OdonDienteProcedimiento(int par_IdParteDental, int par_IdOdontograma, int par_IdDiente, int par_EstadoLunaCentral, int par_EstadoLunaSuperior, int par_EstadoLunaInferior, int par_EstadoLunaDerecha, int par_EstadoLunaIzquierda, DateTime par_FechaDeCreacionParte,string par_Observaciones)
        {

            this.IdParteDental = par_IdParteDental;
            this.IdOdontograma = par_IdOdontograma;
            this.IdDiente = par_IdDiente;
            this.EstadoLunaCentral = par_EstadoLunaCentral;
            this.EstadoLunaSuperior = par_EstadoLunaSuperior;
            this.EstadoLunaInferior = par_EstadoLunaInferior;
            this.EstadoLunaDerecha = par_EstadoLunaDerecha;
            this.EstadoLunaIzquierda = par_EstadoLunaIzquierda;
            this.FechaDeCreacionParte = par_FechaDeCreacionParte;
            this.Observaciones = par_Observaciones;      
        
        
        }


    }
}
