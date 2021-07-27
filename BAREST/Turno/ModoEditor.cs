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
    public partial class ModoEditor : Form
    {
        public ModoEditor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar la mesa?", "Borrar Mesa", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ClaseCompartida2.check = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseCompartida2.cancel = true;
            this.Close();
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
                ClaseCompartida2.nombreM2 = textBox1.Text;
                this.Close();
            }
        }

        private void ModoEditor_Load(object sender, EventArgs e)
        {
            textBox1.Text = ClaseCompartida2.nombreM;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                aceptarB();
            }
        }

        private void aceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                ClaseCompartida2.cancel = true;
                this.Close();
            }
        }
    }
}
