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
    public partial class IngresarMonto : Form
    {
        public IngresarMonto()
        {
            InitializeComponent();
        }

        public string Origen { get; set; }

        private void IngresarMonto_Load(object sender, EventArgs e)
        {

        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private CajaCh formularioCajaCh; // Variable para almacenar la referencia a CajaCh

        public IngresarMonto(CajaCh cajaCh)
        {
            InitializeComponent();
            formularioCajaCh = cajaCh;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            // Obtén el valor del concepto y el monto ingresado
            string concepto = txtConcepto.Text;
            decimal monto = decimal.Parse(txtMonto.Text); // Asegúrate de validar y manejar errores de conversión

            // Obtén el índice de la raíz a la que deseas agregar el nodo
            int indiceRaiz = 0; // Reemplaza con el índice de la raíz deseada

            // Accede a la raíz específica utilizando el índice
            TreeNode raiz = formularioCajaCh.treeView1.Nodes[indiceRaiz];

            // Crea el texto del nodo con el concepto y el monto alineados
            string textoConcepto = concepto;
            string textoMonto = monto.ToString("C");

            // Agrega espacios en blanco adicionales para la separación fija
            int cantidadEspacios = 30; // Ajusta el valor según tus necesidades
            int cantidadEspaciosConcepto = cantidadEspacios - textoConcepto.Length;
            if (cantidadEspaciosConcepto > 0)
            {
                textoConcepto += new string(' ', cantidadEspaciosConcepto);
            }

            // Crea el texto del nodo con el concepto y el monto alineados
            string textoNodo = textoConcepto + textoMonto;

            // Agrega un nuevo nodo a la raíz
            TreeNode nuevoNodo = new TreeNode(textoNodo);
            raiz.Nodes.Add(nuevoNodo);

            // Refresca el TreeView en el formulario CajaCh
            formularioCajaCh.treeView1.Refresh(); // O formularioCajaCh.treeView1.Update();

            // Cierra el formulario "IngresarMonto"
            this.Close();
        }




    }
}
