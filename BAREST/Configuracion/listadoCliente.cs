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

namespace BAREST.Configuracion
{
    public partial class listadoCliente : Form
    {
        public listadoCliente()
        {
            InitializeComponent();
        }

        private void listadoCliente_Load(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            String sql = " select NombreCliente, Apellido,telefono,dni,domicilio,altura,depto,piso from Clientes";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                llenar();
                dataGridView1.Rows.Add(registros["NombreCliente"].ToString(),
                                       registros["Apellido"].ToString(), 
                                       registros["telefono"].ToString(), 
                                       registros["dni"].ToString(),
                                       registros["domicilio"].ToString(),
                                       registros["altura"].ToString(),
                                       registros["depto"].ToString(),
                                       registros["piso"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
        void llenar()
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "nombre";
            dataGridView1.Columns[1].Name = "ape";
            dataGridView1.Columns[2].Name = "tel";
            dataGridView1.Columns[3].Name = "dni";
            dataGridView1.Columns[4].Name = "dom";
            dataGridView1.Columns[5].Name = "altura";
            dataGridView1.Columns[6].Name = "depto";
            dataGridView1.Columns[7].Name = "piso";
            dataGridView1.Columns["nombre"].HeaderText = "NOMBRE";
            dataGridView1.Columns["ape"].HeaderText = "APELLIDO";
            dataGridView1.Columns["tel"].HeaderText = "TELEFONO";
            dataGridView1.Columns["dni"].HeaderText = "DNI";
            dataGridView1.Columns["dom"].HeaderText = "DOMICILIO";
            dataGridView1.Columns["altura"].HeaderText = "ALTURA";
            dataGridView1.Columns["depto"].HeaderText = "DEPTO";
            dataGridView1.Columns["piso"].HeaderText = "PISO";
            

        }
    }
}
