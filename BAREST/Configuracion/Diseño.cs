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
            //Creo el panel
            Panel nuevoPanel = new Panel();
            nuevoPanel.BackColor = Color.FromArgb(135, 150, 254);
            //Creo una variable Y. La cual inicializo en 0 y cada que inserto un panel incrementa 60
            int Y = 0, contador =0;
            nuevoPanel.Location = new Point(0, Y);
            nuevoPanel.Name = "panelTel" + contador;
            nuevoPanel.Size = new Size(206, 56);
            Y += 60;

            //Por ultimo el panel creado en tiempo de ejecucion lo agrego al panel en el cual aparecera
            panel1.Controls.Add(nuevoPanel);
        }
    }
}
