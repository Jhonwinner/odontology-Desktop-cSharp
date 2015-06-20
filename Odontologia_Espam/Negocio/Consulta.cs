using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public class Consulta
    {
      public int id_historia { set; get; }
      public int id_consulta { set; get; }
      public string Detalles_Consulta { set; get; }
      public DateTime FechaHoraInicio  { set; get; }
      public DateTime FechaHoraFin { set; get; }
      public bool status { set; get; }
      public int idUsuario { set; get; }


      public Consulta(int par_IdHistoria, int par_IdConsulta, string par_DetalleConsulta, DateTime par_FechaHoraInicio, DateTime par_FechaHoraFin, bool par_status)
      {
          this.id_historia = par_IdHistoria;
          this.id_consulta = par_IdConsulta;
          this.Detalles_Consulta = par_DetalleConsulta;
          this.FechaHoraInicio = par_FechaHoraInicio;
          this.FechaHoraFin = par_FechaHoraFin;
          this.status = par_status; 

      }

      public Consulta(int par_IdHistoria, int par_IdConsulta, string par_DetalleConsulta, DateTime par_FechaHoraInicio, DateTime par_FechaHoraFin, bool par_status,int par_idUsuario)
      {
          this.id_historia = par_IdHistoria;
          this.id_consulta = par_IdConsulta;
          this.Detalles_Consulta = par_DetalleConsulta;
          this.FechaHoraInicio = par_FechaHoraInicio;
          this.FechaHoraFin = par_FechaHoraFin;
          this.status = par_status;
          this.idUsuario = par_idUsuario; 

      }

    }
}
