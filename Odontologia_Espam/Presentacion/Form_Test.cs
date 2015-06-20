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
    public partial class Form_Test : Form
    {
        int codigo_historia { set; get; }
        bool estado  = false;
       

        public Form_Test()
        {
            InitializeComponent();
            estado = false;
        }

        public Form_Test(int Cod_historia)
        {
            InitializeComponent();
            this.codigo_historia = Cod_historia;
            estado = true ;
        }



        Catalogo_Test test = new Catalogo_Test();
        Catalogo_Persona persona = new Catalogo_Persona();
        int ind;
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_Nuevo_Click_1(object sender, EventArgs e)
        {
            Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas();
            NewPe.ShowDialog(this);
            llenar_DTG();

        }

        private void Form_Test_Load(object sender, EventArgs e)
        {
            llenar_DTG();
        }

        private void llenar_DTG() {
            int indice = 0 ;
            dataGridView1.Rows.Clear();

            foreach (var item in test.FRetornaPreguntas(1))
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = item.cod_PRegunta;
                dataGridView1.Rows[indice].Cells[1].Value = item.Preguntas_;
                indice++;               
            }


        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            evento_Update();

        }

     
    

        private void evento_Update() {
            
            int id = 0;
            string Pre= null;
            
            try
            {
                id = int.Parse(dataGridView1.Rows[ind].Cells[0].Value.ToString());
                Pre = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                Form_Crea_Preguntas NewPe = new Form_Crea_Preguntas(id, Pre,3);
                NewPe.ShowDialog(this);
                llenar_DTG();
                 id = 0;
                Pre = null;
            }
            catch (Exception)
            {
                
               
            }
            
        
        }


        private void but_Borrar_Click_1(object sender, EventArgs e)
        {
            
            test.FunElimaPregunta(new Preguntas(int.Parse(dataGridView1.Rows[ind].Cells[0].Value.ToString())));
            llenar_DTG();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = e.RowIndex;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ind = e.RowIndex;
            evento_Update();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            evento_guardar();           

        }

        private void evento_guardar() {
            

            if (estado == true)
            {
                evento_update();
            }
            else
            {
                eventos_insert();
            }

        }

        private void evento_update() {
           
            
            if (string.IsNullOrEmpty(ContHistoria.Text) == false)
            {
                int a;
                a = test.FunRetornaIdTestXIdH(Convert.ToInt32(ContHistoria.Text));

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    test.FunModificaRespuestas(new Test_Cuerpo(a, i + 1, Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value), Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value)));
                }
                MessageBox.Show("Datos Actualizados Correctamente", "Status : Enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Nesecita Escribir Algo de Informacion", "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        
        }

        private void eventos_insert() {
                   
         //if (string.IsNullOrEmpty(ContHistoria.Text) == false && test.FunValorExistente(new Test_Cab(int.Parse(ContHistoria.Text))) == false)
         //   {
         //       cod_tes = test.ingresar_cab_test(new Test_Cab(0, int.Parse(ContHistoria.Text), Convert.ToDateTime(Dat_Creacion.Value.ToShortDateString())));

         //       for (int i = 0; i < dataGridView1.RowCount ; i++)
         //       {
         //           test.ingresar_Çuerp_test(new Test_Cuerpo(cod_tes, i+1, Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value), Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value)));
         //       }
         //       estado = true;
         //       MessageBox.Show("Datos Guradados  Correctamente", "Status : Enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
         //   }
         //   else
         //   {
         //       string sms= ""; 

         //       if (string.IsNullOrEmpty(ContHistoria.Text) == true)
         //       {
         //           sms = "El cuadro de texto Esta Vacio";
         //       }
         //       else
         //       {
         //           sms = "El Paciente ya Tiene Creado un test";
         //       }

         //       MessageBox.Show(sms, "Status : Not Enviado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         //   }
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            estado = false;
            ContHistoria.Clear();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = false;
            }
        }

        private void ContHistoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_bucar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            dataGridView1.Rows.Clear();
            textBox1.Text = persona.obetener_NOmbre_Paciente(new Ordenes_Examen(Convert.ToInt32(ContHistoria.Text)));
            foreach (var item in test.FRetornaPreguntas(1))
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = item.cod_PRegunta;
                dataGridView1.Rows[indice].Cells[1].Value = item.Preguntas_;
                dataGridView1.Rows[indice].Cells[2].Value = test.FunValorRespuesta(new Test_Cuerpo(int.Parse(ContHistoria.Text),indice + 1,item.cod_PRegunta));
                indice++;
            }

            estado = true;

        }

      




   
    }
}
