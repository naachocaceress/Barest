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
    public partial class Cajasc : Form
    {
        public Cajasc()
        {
            InitializeComponent();
        }

        private void btnAgregarRes_Click(object sender, EventArgs e)
        {
            Cajas.Cajagr m = new Cajas.Cajagr();
            m.Show();
        }

        private void btnEliminarRes_Click(object sender, EventArgs e)
        {
            Cajas.CajaCh m = new Cajas.CajaCh();
            m.Show();
        }

        private void gastosvarios_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Gastos varios";
            m.Show();
        }

        private void ajustedecajaengreso_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Ajustes de caja - Egreso";
            m.Show();
        }

        private void acajagrande_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Retiros a caja grande";
            m.Show();
        }

        private void acajachica_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Retiros a caja chica";
            m.Show();
        }

        private void ajustedecajaingreso_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Ajustes de caja - Ingreso";
            m.Show();
        }

        private void decajagrande_Click(object sender, EventArgs e)
        {
            Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Aporte de caja grande";
            m.Show();
        }

        private void decajachica_Click(object sender, EventArgs e)
        {Cajas.IngresarMonto m = new Cajas.IngresarMonto();
            m.groupBox1.Text = "Caja socios";
            m.label1.Text = "Aporte de caja chica";
            m.Show();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
