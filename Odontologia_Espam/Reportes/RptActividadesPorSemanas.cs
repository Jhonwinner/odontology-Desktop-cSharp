using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class RptActividadesPorSemanas : Form
    {
        private int  IdSesion {set;get;}

        public RptActividadesPorSemanas()
        {
            InitializeComponent();
        }

        public RptActividadesPorSemanas(int par_IdSesion)
        {
            InitializeComponent();
            this.IdSesion = par_IdSesion; 
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RptActividadesPorSemanas_Load(object sender, EventArgs e)
        {
            dtpx_Inicio.Value = DateTime.Now.AddDays(-7);  
            this.reportViewer1.RefreshReport();
        }

        private void dtpx_Fin_ValueChanged(object sender, EventArgs e)
        {


            this.spRptActividadesEntreFechasTableAdapter.Fill(this.Odontologia_EspamDataSet.spRptActividadesEntreFechas, dtpx_Inicio.Value, dtpx_Fin.Value, IdSesion);
            this.reportViewer1.RefreshReport();
        }

    }
}
