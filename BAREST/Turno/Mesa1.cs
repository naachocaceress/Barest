﻿using System;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAREST
{
    public partial class Mesa1 : Form
    {
        private int idComandaActual; // Variable para almacenar el ID de la comanda actual
        public Mesa1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comandas();
            this.Close();
        }
            
       
        /// <summary>
        /// 
        /// </summary>


        private void btnComanda_Click(object sender, EventArgs e)
        {
            crearComanda();
        }
        private void crearComanda()
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Crear una nueva Comanda?", "Nueva Comanda", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (SqlCommand comando = new SqlCommand("INSERT INTO [dbo].[Comanda]([mesa],[mozo],[comensal],[fecha]) VALUES (@mesa, @mozo, @comensal, GETDATE())", conexion))
                    {
                        comando.Parameters.AddWithValue("mesa", labelmesa.Text);
                        comando.Parameters.AddWithValue("@mozo", labelmozo.Text);
                        comando.Parameters.AddWithValue("@comensal", textComensal.Text);
                        comando.ExecuteNonQuery();

                        // Obtener el ID de la comanda recién creada
                        string sqlObtenerIdComanda = "SELECT @@IDENTITY";
                        comando.CommandText = sqlObtenerIdComanda;
                        idComandaActual = Convert.ToInt32(comando.ExecuteScalar());
                    }

                    btnComanda.Visible = false;
                    agregarMenulista.Visible = true;
                    textBuscar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear comanda:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Comandas()
        {
            Conexion.ObtenerConexion();
            try
            {
                using (var comanda = new SqlCommand())
                {
                    comanda.Connection = Conexion.ObtenerConexion();
                    comanda.CommandText = "INSERT INTO [dbo].[Mesa]([mesa],[cantidad],[detalles],[precioUnitario],[fecha],[idComanda],[mozo]) VALUES (@mesa,@cantidad,@detalles,@precioUnitario,GETDATE(),@idComanda,@mozo)";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        comanda.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = labelmesa.Text;
                        comanda.Parameters.AddWithValue("@cantidad", SqlDbType.Int).Value = row.Cells[0].Value;
                        comanda.Parameters.AddWithValue("@detalles", SqlDbType.VarChar).Value = row.Cells[1].Value;
                        comanda.Parameters.AddWithValue("@precioUnitario", SqlDbType.Float).Value = row.Cells[2].Value;
                        comanda.Parameters.AddWithValue("@idComanda", idComandaActual); 
                        comanda.Parameters.AddWithValue("@mozo", SqlDbType.VarChar).Value = labelmozo.Text;
                        comanda.ExecuteNonQuery();
                        comanda.Parameters.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void SumarSiExisteFila()
        {
            Conexion.ObtenerConexion();
            try
            {
                using (var comanda = new SqlCommand())
                {
                    comanda.Connection = Conexion.ObtenerConexion();
                    comanda.CommandText = "UPDATE [dbo].[Mesa] SET [cantidad] = @cantidad, [detalles] = @detalles, [precioUnitario] = @precioUnitario, [fecha] = GETDATE() WHERE [idMesa] = @idMesa AND [idComanda] = @idComanda";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        comanda.Parameters.AddWithValue("@idComanda", idComandaActual); // Usar el ID de la comanda actual
                        comanda.Parameters.AddWithValue("@idMesa", row.Cells["idMesa"].Value);
                        comanda.Parameters.AddWithValue("@cantidad", SqlDbType.Int).Value = row.Cells[0].Value;
                        comanda.Parameters.AddWithValue("@detalles", SqlDbType.VarChar).Value = row.Cells[1].Value;
                        comanda.Parameters.AddWithValue("@precioUnitario", SqlDbType.Float).Value = row.Cells[2].Value;
                        comanda.ExecuteNonQuery();
                        comanda.Parameters.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               throw;
            }
        }
        private void eliminarFiladb()
        {
            Conexion.ObtenerConexion();
            try
            {
                using (var comanda = new SqlCommand())
                {
                    comanda.Connection = Conexion.ObtenerConexion();
                    comanda.CommandText = "DELETE FROM [dbo].[Mesa] WHERE [idMesa] = @idMesa AND [idComanda] = @idComanda";

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        comanda.Parameters.AddWithValue("@idComanda", idComandaActual); // Usar el ID de la comanda actual
                        comanda.Parameters.AddWithValue("@idMesa", row.Cells["idMesa"].Value);
                        comanda.ExecuteNonQuery();
                        comanda.Parameters.Clear();
                    }
                }

                sumaT(); // Actualizar el total después de eliminar la(s) fila(s)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
       /* private void Cobro()
        {
            Conexion.ObtenerConexion();
            try

            {
                using (var comanda = new SqlCommand())
                {
                    comanda.Connection = Conexion.ObtenerConexion();
                    comanda.CommandText = " INSERT INTO Cobro(idMozo,idMesa,comensal,total,fecha) VALUES (@mozoc,@mesac,@comensal,@total,@fecha)";
                    comanda.Parameters.AddWithValue("@mesac", SqlDbType.VarChar).Value = labelmesa.Text;
                    comanda.Parameters.AddWithValue("@mozoc", SqlDbType.VarChar).Value = labelmozo.Text;
                    comanda.Parameters.AddWithValue("@comensal", SqlDbType.VarChar).Value = textComensal.Text;
                    comanda.Parameters.AddWithValue("@total", SqlDbType.Float).Value = textTotal.Text;
                    comanda.Parameters.AddWithValue("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                    comanda.ExecuteNonQuery();
                    comanda.Parameters.Clear();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }*/

       

        public static class ClaseCompartida
        {
            public static int valor = 0;
            public static int usu = 0;
            public static int mmm = 0;
            public static string Mesa = "";
            public static int comanda = 0;
            // otras variables estáticas
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            agregarMenulista2();
        }

        public int cantidad = 0;
        
       /* private void crearComanda()
        {

            if (string.IsNullOrWhiteSpace(textComensal.Text))
            {
                MessageBox.Show("Falta agregar cantidad de comensal");
                return;
            }

            

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (SqlCommand comando = new SqlCommand("INSERT INTO [dbo].[Comanda]([mesa],[mozo],[comensal],[fecha]) VALUES (@mesa, @mozo, @comensal, GETDATE())", conexion))
                    {

                        comando.Parameters.AddWithValue("mesa", labelmesa.Text);
                        comando.Parameters.AddWithValue("@mozo", labelmozo.Text);
                        comando.Parameters.AddWithValue("@comensal", textComensal.Text);
                        comando.ExecuteNonQuery();

                    }
                    btnComanda.Visible = false;
                    agregarMenulista.Visible = true;
                    textBuscar.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al eliminar el crear comanda:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }*/
        /// <summary>
        /// el id para agregar a cada fila de la mesa.
        /// </summary>
        private void buscarIdComanda()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT [idComanda]FROM [dbo].[Comanda] WHERE [mesa] =@mesa AND [mozo]=@mozo AND [estado] ='A'", conexion))
                {
                    comando.Parameters.AddWithValue("mesa", labelmesa.Text);
                    comando.Parameters.AddWithValue("@mozo", labelmozo.Text);
                    SqlDataAdapter adaptador1 = new SqlDataAdapter();
                    adaptador1.SelectCommand = comando;
                    DataTable tabla1 = new DataTable();
                    adaptador1.Fill(tabla1);
                    textIdComanda.Text = "idComada";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error en el idComanda", MessageBoxButtons.OK);
            }
        }
        

        private void agregarMenulista2()
        {

             buscarIdComanda();

            dataGridView1.ClearSelection();
            try
            {
                if (cantidad == 0)
                {
                    if (textBuscar.Text.All(char.IsDigit) && textBuscar.Text.Length != 0)
                    {
                        int cantN = Int32.Parse(textBuscar.Text);
                        cantidad = cantN;
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            row.Cells["cant"].Value = cantidad;
                        }
                        dataGridView1.Rows.Add(new String[] { cantidad.ToString() });
                        textBuscar.Text = "";
                    }
                    else
                    {
                        IngresarMenu();
                    }
                }
                else
                {
                    IngresarMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN LA AGREGAR MENU", MessageBoxButtons.OK);
            }
        }
        // insertar menu ------------------------------------------ 
        private void IngresarMenu()
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
            Conexion.ObtenerConexion();
            string sql = "SELECT nombre,precio FROM Menu WHERE idMenu = @idMenu";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Clear();
            //comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
            comando.Parameters.Add("@idMenu", SqlDbType.Int).Value = textBuscar.Text;
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                float tt2 = float.Parse(registros["precio"].ToString());
                float tt3 = cantidad * tt2;
                string tt4 = tt3.ToString();
                dataGridView1.Rows.Add(new String[] { cantidad.ToString(), registros["nombre"].ToString(), registros["precio"].ToString(), tt4 });
            }
            else
            registros.Close();
            sumaT();
            Conexion.ObtenerConexion().Close();
            textBuscar.Text = "";

            ClaseCompartida.valor = 1;// color rojo
            cantidad = 0;
        }
        //  suma los precio total--------------- perfecto

        private void sumaT()
        {
            int sumatorio = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sumatorio += Convert.ToInt32(row.Cells["PTotal"].Value);
            }

            string hola = sumatorio.ToString();

            textTotal.Text = hola;
        }
        //------------------------------------------------------------------

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            eliminar();
           // eliminarFiladb();
        }

        private void eliminar()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            sumaT();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textTotal.Text.Length; i++)
            {
                if (textTotal.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        // suma --------------------- perfecto----
        private void iconButton1_Click(object sender, EventArgs e)
        {
            double suma = 1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                suma += Convert.ToDouble(row.Cells["cant"].Value);
                row.Cells["cant"].Value = suma;

                int cant = Convert.ToInt32(row.Cells["cant"].Value);
                int puni = Convert.ToInt32(row.Cells["precio"].Value);

                double sum = cant * puni;

                row.Cells["PTotal"].Value = sum;

                sumaT();
            }
        }
        //  resta -----------------------perfecto----------------------
        private void iconButton2_Click(object sender, EventArgs e)
        {
            double resta = 1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                resta = Convert.ToDouble(row.Cells["cant"].Value) - resta;
                row.Cells["cant"].Value = resta;
                int cant = Convert.ToInt32(row.Cells["cant"].Value);
                int puni = Convert.ToInt32(row.Cells["precio"].Value);
                double sum = cant * puni;
                row.Cells["PTotal"].Value = sum;
            }
            if (resta == 0)
                eliminar();
            sumaT();
        }
        //---------------------------------------------------
        private void Mesa1_Load(object sender, EventArgs e)
        {
            if (ClaseCompartida.mmm == 1)
            {
                try
                {
                    Conexion.ObtenerConexion();
                    string sql = "SELECT [idMesa], [cantidad], [detalles], [precioUnitario], [precioTotal] FROM [dbo].[Mesa] WHERE [mesa] = @mesa AND [mozo] = @mozo AND [estado] = 'A' AND [idComanda] = @idComanda";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.AddWithValue("@mesa", ClaseCompartida.Mesa);
                    comando.Parameters.AddWithValue("@mozo", labelmozo.Text);
                    comando.Parameters.AddWithValue("@idComanda", idComandaActual); // Usar el ID de la comanda actual
                    SqlDataReader leido = comando.ExecuteReader();
                    while (leido.Read())
                    {
                        dataGridView1.Rows.Add(new string[] { leido["idMesa"].ToString(), leido["cantidad"].ToString(), leido["detalles"].ToString(), leido["precioUnitario"].ToString(), leido["precioTotal"].ToString() });
                    }
                    ClaseCompartida.mmm = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }


        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // IMPRIMIR CONTROL -----------------------------------

            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir2;
            printDocument1.Print();

            ClaseCompartida.valor = 5;// color celeste.
            this.Close();
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);


            e.Graphics.DrawString("COMANDA", font, Brushes.Black, new RectangleF(50, 10, 120, 20));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy") + "  Hora: " + DateTime.Now.ToString("HH:mm"), font2, Brushes.Black, new RectangleF(5, 40, 300, 20));


            e.Graphics.DrawString("Mozo: " + labelmozo.Text, font3, Brushes.Black, new RectangleF(5, 70, 300, 20));
            e.Graphics.DrawString("Mesa: " + labelmesa.Text, font3, Brushes.Black, new RectangleF(5, 90, 300, 20));
            e.Graphics.DrawString("N°: " + ClaseCompartida.comanda, font3, Brushes.Black, new RectangleF(150, 80, 300, 20));
            e.Graphics.DrawString("-------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 110, 300, 20));

            int counta = dataGridView1.Rows.Count;

            if (counta == 1)
            {
                e.Graphics.DrawString(" " + dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + dataGridView1.Rows[0].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 130, 300, 20));
                e.Graphics.DrawString("-------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 155, 300, 20));
            }
            else
            {
                e.Graphics.DrawString(" " + dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + dataGridView1.Rows[0].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 130, 300, 20));
                e.Graphics.DrawString(" " + dataGridView1.Rows[1].Cells[0].Value.ToString() + " " + dataGridView1.Rows[1].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 155, 300, 20));
                e.Graphics.DrawString("-------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 175, 300, 20));
            }

            //e.Graphics.DrawString(" " + dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + dataGridView1.Rows[0].Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(15, 130, 300, 20));
        }
        private void Imprimir2(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font21 = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);


            e.Graphics.DrawString(" VIDON BAR", font, Brushes.Black, new RectangleF(90, 10, 120, 20));
            e.Graphics.DrawString("Fragueiro 2185", font21, Brushes.Black, new RectangleF(98, 35, 300, 20));
            e.Graphics.DrawString("3514742328", font21, Brushes.Black, new RectangleF(110, 50, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 60, 300, 20));

            e.Graphics.DrawString("Control del Pedido", font2, Brushes.Black, new RectangleF(90, 76, 300, 20));
            e.Graphics.DrawString("Mesa: " + labelmesa.Text, font3, Brushes.Black, new RectangleF(100, 90, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 100, 300, 20));

            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy") + "                         Hora: " + DateTime.Now.ToString("HH:mm"), font2, Brushes.Black, new RectangleF(5, 120, 300, 20));
            e.Graphics.DrawString("Mozo: " + labelmozo.Text, font2, Brushes.Black, new RectangleF(5, 135, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 150, 300, 20));

            e.Graphics.DrawString("Cant.  Descripcion                       SubTot.  Total", font2, Brushes.Black, new RectangleF(5, 165, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 170, 300, 20));

            e.Graphics.DrawString(dataGridView1.CurrentRow.Cells[0].Value.ToString() + "     " + dataGridView1.CurrentRow.Cells[1].Value.ToString(), font3, Brushes.Black, new RectangleF(10, 190, 300, 20));
            e.Graphics.DrawString(dataGridView1.CurrentRow.Cells[2].Value.ToString() + "   " + dataGridView1.CurrentRow.Cells[3].Value.ToString(), font3, Brushes.Black, new RectangleF(205, 190, 300, 20));

            e.Graphics.DrawString("--------------------------------------------------------", font3, Brushes.Black, new RectangleF(5, 210, 300, 20));

            e.Graphics.DrawString("                                          Subtotal: $" + textTotal.Text, font21, Brushes.Black, new RectangleF(5, 230, 300, 20));
            e.Graphics.DrawString("                                      Descuento: ", font21, Brushes.Black, new RectangleF(5, 245, 300, 20));
            e.Graphics.DrawString("                                                Total: $" + textTotal.Text, font21, Brushes.Black, new RectangleF(5, 260, 300, 20));

            e.Graphics.DrawString("GRACIAS POR ELEGIR VIDON BAR", font21, Brushes.Black, new RectangleF(25, 290, 300, 20));
            e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(130, 320, 50, 50));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
