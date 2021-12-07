using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.Turno
{
    public partial class DetallesDeli : Form
    {
        public DetallesDeli()
        {
            InitializeComponent();
        }

        private void DetallesDeli_Load(object sender, EventArgs e)
        {
            if (DeliveryMesa.ClaseCompartida.pagado == true)
                textAbona.Enabled = false;
            DeliveryMesa.ClaseCompartida.pagado = false;
            if (DeliveryMesa.ClaseCompartida.py == true)
                textDireccion.Enabled = false;
            DeliveryMesa.ClaseCompartida.py = false;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
