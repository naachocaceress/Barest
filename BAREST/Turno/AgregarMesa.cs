using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                ClaseCompartida2.nombre = textBox1.Text;
                this.Close();
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
