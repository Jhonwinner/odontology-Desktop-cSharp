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
    public partial class frm_Reportes : Form
    {
        public frm_Reportes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Odontologia_EspamDataSet.spRptUsoDelaAplicacion' Puede moverla o quitarla según sea necesario.
            this.spRptUsoDelaAplicacionTableAdapter.Fill(this.Odontologia_EspamDataSet.spRptUsoDelaAplicacion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
