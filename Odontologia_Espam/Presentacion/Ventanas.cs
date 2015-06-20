using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class Ventana
    {
        //miembros protegidos
        private Form frmPrincipal = null;
        private int indice=0;
        public Ventana(Form _principal)
        {
            frmPrincipal = _principal;
            frmPrincipal.IsMdiContainer = true;
           
        }
        //
        // Activa Formulario "hijo"
        public void ActivarFormulario(Form frmHijo)
        {
            try
            {
                  
                frmHijo.MdiParent = frmPrincipal;
                frmHijo.Show();
                indice++;
                //Visualizando nombre del formulario hijo en el formulario padre
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, frmPrincipal.Text); }
        }
        // Cerramos el Formulario Hijo actico
        public void CerrarFormulario()
        {
            try
            {
                for (int i = 0; i < indice; i++)
                {
                    Form activo = new Form();
                    activo = frmPrincipal.ActiveMdiChild;
                    activo.Close();
                }
                
                indice = 0; 
                               
            }
            catch (Exception) { }
        }

    }
}
