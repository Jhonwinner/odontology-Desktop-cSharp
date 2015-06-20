using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Administra_Odontologo : Form
    {
        public Administra_Odontologo()
        {
            InitializeComponent();
        }

        Catalogo_Persona Persona = new Catalogo_Persona();


        private void Administra_Odontologo_Load(object sender, EventArgs e)
        {
            rb_CI.Checked=true;
        }

        private void GRoup_Enter(object sender, EventArgs e)
        {

        }

        private void Cont_Buscar_TextChanged(object sender, EventArgs e)
        {
            estado_checks();     
        }

        private void estado_checks()
        {

            if (rb_CI.Checked == true)
            {
                llenar_dataGrid_con_busq(Cont_Buscar.Text, null);
            }
            else
            {
                llenar_dataGrid_con_busq(null, Cont_Buscar.Text);
            }
        }



        private void llenar_dataGrid_con_busq(string Cedula, string Nombres)
        {
            int indice = 0;

            DG_persona.Rows.Clear();

            foreach (var item in Persona.Busca_PErsona_CI_Nombre_Base_Remota(new Persona(Cedula, Nombres)))
            {
                DG_persona.Rows.Add();
                DG_persona.Rows[indice].Cells[0].Value = item.var_Id_persona;
                DG_persona.Rows[indice].Cells[1].Value = item.var_Cedula_identidad;
                DG_persona.Rows[indice].Cells[2].Value = item.var_Nombres;
                DG_persona.Rows[indice].Cells[3].Value = item.var_Apellidos;
                DG_persona.Rows[indice].Cells[4].Value = item.var_Direccion;
                DG_persona.Rows[indice].Cells[5].Value = item.var_telefono;
                DG_persona.Rows[indice].Cells[6].Value = item.var_correo;
               

                indice++;
            }

        }

        private void DG_persona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            get_id();
           
        }

        private void DG_persona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            get_id();
           
        }

        private void get_id() {
            try
            {
                Properties.Settings.Default.User = DG_persona.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }


    }
}
