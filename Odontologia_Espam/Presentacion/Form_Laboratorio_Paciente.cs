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
    public partial class Form_Laboratorio_Paciente : Form
    {
        Catalogo_Persona persona = new Catalogo_Persona();
        Form_News_Ordenes_Examenes Ventan_Crea_Orden = new Form_News_Ordenes_Examenes();
        private int Index1 { set; get; }
        

        public Form_Laboratorio_Paciente()
        {
            InitializeComponent();
        }

        private void but_Nuevo_Click(object sender, EventArgs e)
        {
           
            Ventan_Crea_Orden.ShowDialog(this);
        }

        private void Form_Laboratorio_Paciente_Load(object sender, EventArgs e)
        {
            
            Cont_Buscar.ReadOnly = true;
            but_bucar.Visible = false;
            llenar_DAtaGrid();
            
           
            
           
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            envetos_de_update();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rb_CI_CheckedChanged(object sender, EventArgs e)
        {
            Cont_Buscar.ReadOnly = false;
            but_bucar.Visible = true;
        }

        private void RB_N_History_CheckedChanged(object sender, EventArgs e)
        {
            Cont_Buscar.ReadOnly = false;
            but_bucar.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = but_bucar;
        } 
        

        private void but_bucar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cont_Buscar.Text))
            {
                MessageBox.Show("Nesecita Escribir Algo de Informacion\npara poder buscar", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                if (rb_CI.Checked == true)
                {
                    llenar_DAtaGrid_CI(Cont_Buscar.Text, "0");
                }
                else
                {
                    llenar_DAtaGrid_CI(null, Cont_Buscar.Text);
                }
               

            }


                       
                         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Bt_ACtualiza_DAT_Click(object sender, EventArgs e)
        {
            llenar_DAtaGrid();
        }

        private void llenar_DAtaGrid() {


            int indice = 0;
            DG_Ordenes.Rows.Clear();

            foreach (var item in persona.Consultar_30_de_todos_los_examenes())
            {
                DG_Ordenes.Rows.Add();
                    DG_Ordenes.Rows[indice].Cells[0].Value = item.Fecha_de_Envio.ToShortDateString();
                    DG_Ordenes.Rows[indice].Cells[1].Value = item.Fecha_recepcion.ToShortDateString();
                    DG_Ordenes.Rows[indice].Cells[2].Value = item.status;
                    DG_Ordenes.Rows[indice].Cells[3].Value = item.Descp_Exam;
                    DG_Ordenes.Rows[indice].Cells[4].Value = item.Resultad;
                    DG_Ordenes.Rows[indice].Cells[5].Value = item.Id_historia;
                    DG_Ordenes.Rows[indice].Cells[6].Value = item.Id_Consulta;
                   
                   
                indice++;
            }

        }



        private void llenar_DAtaGrid_CI(string Var_CI, string Historia)
        {
            int indice = 0;
            DG_Ordenes.Rows.Clear();

            foreach (var item in persona.Consultar_CI_Historia_Clinica(new Ordenes_Examen(int.Parse(Historia)), new Persona(Var_CI)))
            {
                DG_Ordenes.Rows.Add();
                DG_Ordenes.Rows[indice].Cells[0].Value = item.Fecha_de_Envio.ToShortDateString();
                DG_Ordenes.Rows[indice].Cells[1].Value = item.Fecha_recepcion.ToShortDateString();
                DG_Ordenes.Rows[indice].Cells[2].Value = item.status;
                DG_Ordenes.Rows[indice].Cells[3].Value = item.Descp_Exam;
                DG_Ordenes.Rows[indice].Cells[4].Value = item.Resultad;
                DG_Ordenes.Rows[indice].Cells[5].Value = item.Id_historia;
                DG_Ordenes.Rows[indice].Cells[6].Value = item.Id_Consulta;
            
                
                indice++;
            }
           

            

        }

        private void DG_Ordenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           Index1 = e.RowIndex;
           try
           {
               lab_Historia.Text = DG_Ordenes.Rows[Index1].Cells[5].Value.ToString();
               Lab_Pac.Text = persona.obetener_NOmbre_Paciente(new Ordenes_Examen(int.Parse(lab_Historia.Text)));
           }
           catch (Exception)
           {
             
           }
          
        }


        private void but_Borrar_Click(object sender, EventArgs e)
        {
            persona.Eliminar_Examen(new Ordenes_Examen(Convert.ToInt32(DG_Ordenes.Rows[Index1].Cells[5].Value),Convert.ToInt32(DG_Ordenes.Rows[Index1].Cells[6].Value)));
            llenar_DAtaGrid();
        }

        private void DG_Ordenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           Index1 = e.RowIndex;
           envetos_de_update();      
               

        }


        private void envetos_de_update() {


            try
            {
                int Index2, Index3;
                Index2 = Convert.ToInt32(DG_Ordenes.Rows[Index1].Cells[6].Value);
                Index3 = Convert.ToInt32(DG_Ordenes.Rows[Index1].Cells[5].Value);
                Form_News_Ordenes_Examenes new_pacientes = new Form_News_Ordenes_Examenes(Index2, Index3);
                new_pacientes.ShowDialog(this); 

            }
            catch (Exception)
            {
                
              
            }
        
        }

        private void DG_Ordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lab_Nhistory_Click(object sender, EventArgs e)
        {

        }




    }
}
