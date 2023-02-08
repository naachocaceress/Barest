﻿using System;
using System.Data.SqlClient;
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
            String sql = " SELECT [nombre],[apellido] ,[telefono] ,[domicilio] ,[altura] ,[deptopiso] ,[dni]FROM[dbo].[Cliente] ORDER BY  [nombre] ASC";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                llenar();
                dataGridView1.Rows.Add(registros["nombre"].ToString(),
                                       registros["Apellido"].ToString(),
                                       registros["telefono"].ToString(),
                                       registros["domicilio"].ToString(),
                                       registros["altura"].ToString(),
                                       registros["deptopiso"].ToString(),
                                       registros["dni"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
        void llenar()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "nombre";
            dataGridView1.Columns[1].Name = "apellido";
            dataGridView1.Columns[2].Name = "telefono";
            dataGridView1.Columns[3].Name = "domicilio";
            dataGridView1.Columns[4].Name = "altura";
            dataGridView1.Columns[5].Name = "deptopiso";
            dataGridView1.Columns[6].Name = "dni";

            dataGridView1.Columns["nombre"].HeaderText = "NOMBRE";
            dataGridView1.Columns["apellido"].HeaderText = "APELLIDO";
            dataGridView1.Columns["telefono"].HeaderText = "TELEFONO";
            dataGridView1.Columns["domicilio"].HeaderText = "DNI";
            dataGridView1.Columns["altura"].HeaderText = "DOMICILIO";
            dataGridView1.Columns["deptopiso"].HeaderText = "NUMERO";
            dataGridView1.Columns["dni"].HeaderText = "DOCUMENTO";




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}