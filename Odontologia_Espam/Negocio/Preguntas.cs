using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Preguntas
    {
        public int cod_PRegunta { set; get; }
        public string Preguntas_ { set; get; }
        public int tipo_ { set; get; }

        public  Preguntas(int cood_pregunta, string Pregunta,int tipo) {

            this.cod_PRegunta = cood_pregunta;
            this.Preguntas_ = Pregunta;
            this.tipo_ = tipo;
        }

        public Preguntas(int cood_pregunta)
        {

            this.cod_PRegunta = cood_pregunta;
           
        }
        
    }
}
