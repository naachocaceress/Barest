using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.turno
{
    public partial class Mozo : Form
    {
        public Mozo()
        {
            InitializeComponent();
        }

        private void IngresarMozo_Click(object sender, EventArgs e)
        {
            //m.label2.Text = tboxUsuario.Text;
            this.Close();          
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.label5.Text = "Pedro";
            m.label4.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
            //Mesa1.Close();
        }

        private void juanfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.label5.Text = "Juan";
            m.label4.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void calebfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.label5.Text = "Caleb";
            m.label4.Text = label7.Text;
            this.Close();
            m.ShowDialog();

        }

        private void nachofoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.label5.Text = "Nacho";
            m.label4.Text = label7.Text;
            this.Close();
            m.ShowDialog();

        }

        private void ianfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.label5.Text = "Ian";
            m.label4.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void pepefoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.label5.Text = "Pepe";
            m.label4.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void Mozo_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
