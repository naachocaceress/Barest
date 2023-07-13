using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.Cajas
{
    public partial class Cajagr : Form
    {
        public Cajagr()
        {
            InitializeComponent();
        }

        private void btnAgregarRes_Click(object sender, EventArgs e)
        {
            Cajas.CajaCh m = new Cajas.CajaCh();
            m.Show();
        }

        private void btnEliminarRes_Click(object sender, EventArgs e)
        {
            Cajas.Cajasc m = new Cajas.Cajasc();
            m.Show();
        }

        private void gastosvarios_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Gastos varios";
            m.Show();
        }

        private void ajustedecajaegreso_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Ajustes de caja - Egreso";
            m.Show();
        }

        private void acajachica_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Retiros a caja chica";
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Retiros a caja socios";
            m.Show();
        }

        private void ajustedecajaingreso_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Ajustes de caja - Ingreso";
            m.Show();
        }

        private void decajachica_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Aporte de caja chica";
            m.Show();
        }

        private void decajasocios_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja Grande";
            m.label1.Text = "Aporte de caja socios";
            m.Show();
        }
    }
}
