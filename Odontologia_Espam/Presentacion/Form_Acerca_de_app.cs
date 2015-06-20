using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Presentacion
{
    public partial class Form_Acerca_de_app : Form
    {
        public Form_Acerca_de_app()
        {
            InitializeComponent();
        }

        private void Acerca_de_app_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lab_relog.Text = DateTime.Now.ToLongTimeString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);           
        }

        

        private void Form_Acerca_de_app_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.espam.edu.ec";
            linkLabel1.Links.Add(link);
             
        }
    }
}
