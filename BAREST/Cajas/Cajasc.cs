using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        //----------------------------------------------------------------------------

        public void sumarsaldo()
        {
            double ingreso = Convert.ToDouble(textBox3.Text);
            double salida = Convert.ToDouble(txtTotal.Text);

            double total = ingreso - salida;

            textBox1.Text = total.ToString("N2");
        }

        public void RealizarSumaTreeView1()
        {
            decimal suma = CalcularSumaNumerosTreeView2(treeView1.Nodes);
            txtTotal.Text = suma.ToString("N2");
        }

        public void RealizarSumaTreeView2()
        {
            decimal suma = CalcularSumaNumerosTreeView2(treeView2.Nodes);
            textBox3.Text = suma.ToString("N2");
        }

        private decimal CalcularSumaNumerosTreeView2(TreeNodeCollection nodes)
        {
            decimal suma = 0;

            foreach (TreeNode node in nodes)
            {
                suma += ExtraerNumerosNodo(node.Text);

                suma += CalcularSumaNumerosTreeView2(node.Nodes);
            }

            return suma;
        }

        private decimal ExtraerNumerosNodo(string texto)
        {
            string numerosString = string.Empty;

            foreach (char c in texto)
            {
                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                    numerosString += c;
                }
            }

            decimal valor;
            decimal.TryParse(numerosString, out valor);

            return valor;
        }

        private void Cajasc_Load(object sender, EventArgs e)
        {
            todoload();
        }

        public void todoload()
        {
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
            LoadDataIntoTreeViews();

            RealizarSumaTreeView1();
            RealizarSumaTreeView2();
            sumarsaldo();
        }

        private void LoadDataIntoTreeViews()
        {
            DataTable negativeDataTable = GetDataFromDatabase("SELECT * FROM CajaSocio WHERE monto < 0;");
            DataTable positiveDataTable = GetDataFromDatabase("SELECT * FROM CajaSocio WHERE monto >= 0;");

            BuildTreeView(treeView1, negativeDataTable, false);
            BuildTreeView(treeView2, positiveDataTable, true);
        }

        private DataTable GetDataFromDatabase(string sqlQuery)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = Conexion.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void BuildTreeView(TreeView treeView, DataTable dataTable, bool isPositive)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int idCajaChica = Convert.ToInt32(row["idCajaSocio"]);
                float monto = Convert.ToSingle(row["monto"]);
                string condicion = (string)row["condicion"];
                string descripcion = (string)row["descripcion"];

                // Formatear el nodeText para alinear el monto con la descripción
                string nodeText = descripcion.PadRight(35) + monto.ToString();

                TreeNode parentNode = FindParentNode(treeView, condicion);

                if (parentNode == null)
                {
                    parentNode = new TreeNode(condicion);
                    treeView.Nodes.Add(parentNode);
                }

                // Agregar el nodo hijo con el nodeText formateado
                TreeNode newNode = new TreeNode(nodeText);
                newNode.Name = idCajaChica.ToString();
                parentNode.Nodes.Add(newNode);
            }
        }

        private TreeNode FindParentNode(TreeView treeView, string condicion)
        {
            foreach (TreeNode node in treeView.Nodes)
            {
                if (node.Text == condicion)
                {
                    return node;
                }
            }
            return null;
        }
    }
}
