using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Cajas
{
    public partial class IngresarMonto : Form
    {
        public IngresarMonto()
        {
            InitializeComponent();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------------------------------------------------

        private CajaCh cajaChForm;
        private string signoMontoOriginal;
        public int idCajaChica;
        public string condicion { get; set; }
        public string balance { get; set; }
        public string btncaja { get; set; }

        //------------------------------------------------------------------------------------------

        public IngresarMonto(CajaCh cajaChForm, string condicion)
        {
            InitializeComponent();
            this.cajaChForm = cajaChForm;
            this.condicion = condicion;
        }

        private void confirmar_Click(Object sender, EventArgs e)
        {
            if (idCajaChica == 0)
            {
                InsertarRegistro();
            }
            else
            {
                ActualizarRegistro();
            }
        }

        private void InsertarRegistro()
        {
            //Obtén el valor del concepto y el monto ingresado
            string descripcion = txtConcepto.Text.Trim();
            string montoStr = txtMonto.Text.Trim();
            string negativo = "-" + montoStr;

            if (!decimal.TryParse(montoStr, out decimal monto))
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método sin continuar
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql1 = "insert into CajaChica (monto, condicion, descripcion, fecha, estado) values (@monto, @condicion, @descripcion, GETDATE(), 'A')";
                SqlCommand comando = new SqlCommand(sql1, Conexion.ObtenerConexion());

                if (balance == "Egreso")
                {
                    comando.Parameters.AddWithValue("@monto", float.Parse(negativo));
                }
                else
                {
                    comando.Parameters.AddWithValue("@monto", float.Parse(montoStr));
                }

                comando.Parameters.Add("@condicion", SqlDbType.VarChar).Value = condicion;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                comando.ExecuteNonQuery();
                Conexion.ObtenerConexion().Close();

                if (btncaja == "Grande")
                {
                    Conexion.ObtenerConexion();
                    string sql2 = "insert into CajaGrande (monto, condicion, descripcion, fecha, estado) values (@monto, @condicion, @descripcion, GETDATE(), 'A')";
                    SqlCommand comando2 = new SqlCommand(sql2, Conexion.ObtenerConexion());

                    if (balance == "Egreso")
                    {
                        comando2.Parameters.AddWithValue("@monto", float.Parse(montoStr));
                        comando2.Parameters.Add("@condicion", SqlDbType.VarChar).Value = "Aporte de caja chica";
                    }
                    else
                    {
                        comando2.Parameters.AddWithValue("@monto", float.Parse(negativo));
                        comando2.Parameters.Add("@condicion", SqlDbType.VarChar).Value = "Retiro a caja chica";
                    }

                    comando2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                    comando2.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();
                }
                else if (btncaja == "Socios")
                {
                    Conexion.ObtenerConexion();
                    string sql2 = "insert into CajaSocio (monto, condicion, descripcion, fecha, estado) values (@monto, @condicion, @descripcion, GETDATE(), 'A')";
                    SqlCommand comando2 = new SqlCommand(sql2, Conexion.ObtenerConexion());

                    if (balance == "Egreso")
                    {
                        comando2.Parameters.AddWithValue("@monto", float.Parse(montoStr));
                        comando2.Parameters.Add("@condicion", SqlDbType.VarChar).Value = "Aporte de caja chica";
                    }
                    else
                    {
                        comando2.Parameters.AddWithValue("@monto", float.Parse(negativo));
                        comando2.Parameters.Add("@condicion", SqlDbType.VarChar).Value = "Retiro a caja chica";
                    }

                    comando2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                    comando2.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();
                }

                MessageBox.Show("Se cargo correctamente");
                this.Close();
                cajaChForm.todoload();

            }
        }

        private void ActualizarRegistro()
        {
            Conexion.ObtenerConexion();

            // Obtener el nuevo monto ingresado en el campo de texto txtMonto
            string nuevoMontoStr = txtMonto.Text.Trim();

            // Mantener el signo (positivo o negativo) del monto original para el nuevo monto
            if (signoMontoOriginal == "-" && !nuevoMontoStr.StartsWith("-"))
            {
                nuevoMontoStr = "-" + nuevoMontoStr;
            }
            else if (signoMontoOriginal == "" && nuevoMontoStr.StartsWith("-"))
            {
                nuevoMontoStr = nuevoMontoStr.Substring(1);
            }

            // Actualizar el registro en la base de datos con el nuevo monto
            string sqlUpdate = "UPDATE CajaChica SET monto = @monto, descripcion = @descripcion WHERE idCajaChica = @idCajaChica;";
            SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, Conexion.ObtenerConexion());
            comandoUpdate.Parameters.AddWithValue("@monto", nuevoMontoStr);
            comandoUpdate.Parameters.AddWithValue("@descripcion", txtConcepto.Text);
            comandoUpdate.Parameters.AddWithValue("@idCajaChica", idCajaChica);

            int cant = comandoUpdate.ExecuteNonQuery();
            if (cant != 0)
            {
                MessageBox.Show("Los datos se modificaron correctamente");
                this.Close();
                cajaChForm.todoload();
            }

            Conexion.ObtenerConexion().Close();
        }

        private void IngresarMonto_Load(object sender, EventArgs e)
        {
            if (idCajaChica != 0)
            {
                eliminarbtn.Visible = true;
                Conexion.ObtenerConexion();
                string sql = "SELECT monto, descripcion FROM CajaChica WHERE idCajaChica = @idCajaChica";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@idCajaChica", SqlDbType.VarChar).Value = idCajaChica;
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                {
                    txtConcepto.Text = leido["descripcion"].ToString();

                    // Obtener el monto original sin el signo y almacenar el signo en la variable signoMontoOriginal
                    string montoActual = leido["monto"].ToString();
                    signoMontoOriginal = (montoActual.StartsWith("-")) ? "-" : "";
                    txtMonto.Text = montoActual.Replace("-", "");
                }
                Conexion.ObtenerConexion().Close();
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere eliminar?", "Eliminar", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Conexion.ObtenerConexion();
                string sql = "delete from CajaChica where idCajaChica = @idcajachica";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@idcajachica", idCajaChica);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó la correctamente");
                Conexion.ObtenerConexion().Close();
                this.Close();
                cajaChForm.todoload();
            }
        }
    }
}

