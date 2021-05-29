using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void consultarInsumos_Click(object sender, EventArgs e)
        {
            consultaInsumos m = new consultaInsumos();
            m.ShowDialog();
        }
    }
}
