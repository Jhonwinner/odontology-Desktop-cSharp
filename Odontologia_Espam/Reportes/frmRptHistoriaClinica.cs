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
    public partial class frmRptHistoriaClinica : Form
    {
        int loc_idHostoria; 
        public frmRptHistoriaClinica(int idHistoriaClinica)
        {
            InitializeComponent();
            this.loc_idHostoria = idHistoriaClinica; 
            
        }

        private void frmRptHistoriaClinica_Load(object sender, EventArgs e)
        {
            this.RptVisualizaSesion.RefreshReport();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            this.spRptConsultarConsultaTableAdapter.Fill(this.Odontologia_EspamDataSet.spRptConsultarConsulta, loc_idHostoria, cbox_Consulta.Checked);
            this.RptVisualizaSesion.RefreshReport();

        }

    }
}
