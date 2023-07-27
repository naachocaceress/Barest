using System;
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
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Pedro";
            m.labelmesa.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void juanfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Juan";
            m.labelmesa.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void calebfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Caleb";
            m.labelmesa.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void nachofoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Nacho";
            m.labelmesa.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void ianfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Ian";
            m.labelmesa.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void pepefoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Pepe";
            m.labelmesa.Text = label7.Text;
            this.Close();
            m.ShowDialog();
        }

        private void Mozo_Load(object sender, EventArgs e)
        {

        }
    }
}
