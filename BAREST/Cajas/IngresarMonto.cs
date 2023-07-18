using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.Cajas
{
    public partial class IngresarMonto : Form
    {
        public IngresarMonto()
        {
            InitializeComponent();
        }

        public string Origen { get; set; }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TreeView TreeViewDestino { get; set; }
        public int NodoIndex { get; set; }

        private CajaCh formularioCajaCh; // Variable para almacenar la referencia a CajaCh
        private string nodoPrincipal; // Variable para almacenar el nombre del nodo principal

        public IngresarMonto(CajaCh cajaCh, string nodoPrincipal)
        {
            InitializeComponent();
            formularioCajaCh = cajaCh;
            this.nodoPrincipal = nodoPrincipal;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (pepe == false)
            {
                // Obtén el nodo correspondiente al índice
                TreeNode nodo = TreeViewDestino.Nodes[NodoIndex];


                    // Obtén el valor del concepto y el monto ingresado
                    string concepto = txtConcepto.Text.Trim();
                    string montoStr = txtMonto.Text.Trim();

                    // Valida el formato del monto
                    if (!decimal.TryParse(montoStr, out decimal monto))
                    {
                        MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Sale del método sin continuar
                    }

                    // Define el límite máximo de caracteres para el monto en el tope a la derecha
                    int limiteMaximoCaracteres = 10; // Ajusta el valor según tus necesidades

                    // Formatea el monto con el límite máximo de caracteres
                    string textoMonto = monto.ToString("C").PadLeft(limiteMaximoCaracteres);

                    // Trunca el concepto si su longitud supera los 30 caracteres
                    concepto = concepto.Length > 30 ? concepto.Substring(0, 30) : concepto;

                    // Crea el texto del nodo con el concepto y el monto
                    string textoNodo = $"{concepto,-30}{textoMonto}";

                    // Actualiza el texto del nodo
                    nodo.Text = textoNodo.Trim();

                    // Refresca el TreeView en el formulario CajaCh
                    TreeViewDestino.Refresh();

                    formularioCajaCh.RealizarSumaTreeView1();
                    formularioCajaCh.RealizarSumaTreeView2();
                    formularioCajaCh.sumarsaldo();

                    // Cierra el formulario "IngresarMonto"
                    this.Close();
                }
                else
                {// Obtén el valor del concepto y el monto ingresado
                    string concepto = txtConcepto.Text.Trim();
                    string montoStr = txtMonto.Text.Trim();

                    // Verifica si los campos están vacíos
                    if (string.IsNullOrEmpty(concepto) || string.IsNullOrEmpty(montoStr))
                    {
                        MessageBox.Show("Debe completar ambos campos (concepto y monto).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Sale del método sin continuar
                    }

                    // Valida el formato del monto
                    if (!decimal.TryParse(montoStr, out decimal monto))
                    {
                        MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Sale del método sin continuar
                    }

                    // Busca el nodo principal en el TreeView2
                    TreeNode raiz = BuscarNodoPrincipal(TreeViewDestino);

                    // Si no se encontró el nodo principal, se crea uno nuevo
                    if (raiz == null)
                    {
                        raiz = CrearNodoPrincipal(TreeViewDestino);
                        TreeViewDestino.Nodes.Add(raiz);
                    }

                    // Define el límite máximo de caracteres para el monto en el tope a la derecha
                    int limiteMaximoCaracteres = 10; // Ajusta el valor según tus necesidades

                    // Formatea el monto con el límite máximo de caracteres
                    string textoMonto = monto.ToString("C").PadLeft(limiteMaximoCaracteres);

                    // Trunca el concepto si su longitud supera los 30 caracteres
                    concepto = concepto.Length > 30 ? concepto.Substring(0, 30) : concepto;

                    // Crea el texto del nodo con el concepto y el monto
                    string textoNodo = $"{concepto,-30}{textoMonto}";

                    // Agrega un nuevo nodo al nodo principal
                    TreeNode nuevoNodo = new TreeNode(textoNodo);
                    raiz.Nodes.Add(nuevoNodo);

                    // Refresca el TreeView en el formulario CajaCh
                    TreeViewDestino.Refresh();

                    formularioCajaCh.RealizarSumaTreeView1();
                    formularioCajaCh.RealizarSumaTreeView2();
                    formularioCajaCh.sumarsaldo();

                    // Cierra el formulario "IngresarMonto"
                    this.Close();
                }
            
        }

        private TreeNode BuscarNodoPrincipal(TreeView treeView)
        {
            // Busca el nodo principal en el TreeView
            foreach (TreeNode node in treeView.Nodes)
            {
                if (node.Text == nodoPrincipal)
                {
                    return node;
                }
            }
            return null;
        }

        private TreeNode CrearNodoPrincipal(TreeView treeView)
        {
            // Crea un nuevo nodo principal con el nombre correspondiente
            TreeNode nodo = new TreeNode(nodoPrincipal);
            return nodo;
        }


        bool pepe;



        public string Concepto { get; private set; }
        public decimal Monto { get; private set; }
        public bool Confirmado { get; private set; }

        public IngresarMonto(CajaCh cajaCh, string concepto, string montoStr)
        {
            InitializeComponent();

            // Establece los valores iniciales en los campos de concepto y monto
            txtConcepto.Text = concepto;
            txtMonto.Text = montoStr;

            // Habilita la edición del campo de concepto
            txtConcepto.ReadOnly = false;

            // Convierte el valor de monto a decimal y lo asigna a la propiedad Monto
            decimal.TryParse(montoStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal monto);
            Monto = monto;

            // Habilita la edición del campo de monto si es un valor válido
            if (Monto != 0)
            {
                txtMonto.ReadOnly = false;
            }
        }

        private void IngresarMonto_Load(object sender, EventArgs e)
        {
            if(txtConcepto.Text == "")
            {
                pepe = true;
            }
        }
    }
}
