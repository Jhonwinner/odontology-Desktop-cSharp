using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Usuario
    {
       public int codigo_usuario { set; get; }
       public string usuario { set; get; }
       public string password { set; get; }
       public int N_sesion { set; get; }

       public Usuario(int cod_user, string usuario_,string pass)
       {
           this.codigo_usuario = cod_user;
           this.usuario = usuario_;
           this.password = pass;
          
       }
       public Usuario( string usuario_, string pass)
       {
           this.usuario = usuario_;
           this.password = pass;
       }

       public Usuario(int id_PReset)
       {
           this.codigo_usuario = id_PReset;
       }
    }
}
