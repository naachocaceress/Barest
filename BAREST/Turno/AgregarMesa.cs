using System;
using System.Windows.Forms;
using static BAREST.inicio;

namespace BAREST.Turno
{
    public partial class AgregarMesa : Form
    {
        public AgregarMesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aceptarB();
        }

        private void aceptarB()
        {
            if (textBox1.Text == "")
                MessageBox.Show("Tiene que colocar un nombre");
            else
            {
                if (checkDeli.Checked == false)
                {
                    ClaseCompartida2.nombre = textBox1.Text;
                    this.Close();
                }
                else
                {
                    ClaseCompartida2.deli = true;
                    ClaseCompartida2.nombre = textBox1.Text;
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseCompartida2.cancel = true;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                aceptarB();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                ClaseCompartida2.cancel = true;
                this.Close();
            }
        }
    }
}
