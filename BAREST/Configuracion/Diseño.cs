using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.Configuracion
{
    public partial class Diseño : Form
    {
        //private int y = 50, conteo =0;
        
        public Diseño()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button temp = new Button();

            temp.Height = 50;
            temp.Width = 50;
            temp.Location = new Point(50, 50);
            temp.BackColor = Color.Black;
            //y += 25;
            //temp.Name = "btnBoton" + conteo.ToString();
            //temp.Name = "Boton #" + conteo.ToString();
            //conteo++;

            Controls.Add(temp);
        }
    }
}
