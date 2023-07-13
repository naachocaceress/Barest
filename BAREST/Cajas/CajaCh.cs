using System.Windows.Forms;

namespace BAREST.Cajas
{
    public partial class CajaCh : Form
    {
        public CajaCh()
        {
            InitializeComponent();
        }

        private void btnAgregarRes_Click(object sender, System.EventArgs e)
        {
            Cajas.Cajagr m = new Cajas.Cajagr();
            m.Show();
        }

        private void btnEliminarRes_Click(object sender, System.EventArgs e)
        {
            Cajas.Cajasc m = new Cajas.Cajasc();
            m.Show();
        }

        private void gastosvarios_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this);
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Gastos varios";
            m.Show();
        }

        private void ajustesdecaja_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto(this);
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Ajustes de caja - Egreso";
            m.Show();
        }

        private void acajagrande_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Retiros a caja grande";
            m.Show();
        }

        private void acajasocios_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Retiros a caja socios";
            m.Show();
        }

        private void ajustesdecajaingreso_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Ajustes de caja - Ingreso";
            m.Show();
        }

        private void decajagrande_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Aporte de caja grande";
            m.Show();
        }

        private void decajasocios_Click(object sender, System.EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja chica";
            m.label1.Text = "Aporte de caja socios";
            m.Show();
        }
    }
}
