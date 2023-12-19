using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                string sql1 = "insert into CajaChica (monto, condicion, descripcion, fecha, estado) values (@monto, @condicion, @descripcion, GETDATE(), 'A'); SELECT SCOPE_IDENTITY()";
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

                // Ejecuta el comando y obtén el ID de inserción
                object result = comando.ExecuteScalar();
                int idCajaChica = Convert.ToInt32(result);
                Conexion.ObtenerConexion().Close();

                if (btncaja == "Grande")
                {
                    Conexion.ObtenerConexion();
                    string sql2 = "insert into CajaGrande (monto, condicion, descripcion, fecha, estado, idCajaChica) values (@monto, @condicion, @descripcion, GETDATE(), 'A', @idCajaChica); SELECT SCOPE_IDENTITY()";
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
                    comando2.Parameters.Add("@idCajaChica", SqlDbType.Int).Value = idCajaChica;

                    // Ejecuta el comando y obtén el ID de inserción
                    object result2 = comando2.ExecuteScalar();
                    int idcajaGrande = Convert.ToInt32(result2);
                    Conexion.ObtenerConexion().Close();

                    // Ahora inserta el idCajaGrande en CajaChica
                    Conexion.ObtenerConexion();
                    string sql3 = "update CajaChica set idcajaGrande = @idcajaGrande where idCajaChica = @idCajaChica";
                    SqlCommand comando3 = new SqlCommand(sql3, Conexion.ObtenerConexion());
                    comando3.Parameters.Add("@idcajaGrande", SqlDbType.Int).Value = idcajaGrande;
                    comando3.Parameters.Add("@idCajaChica", SqlDbType.Int).Value = idCajaChica;
                    comando3.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();
                }

                else if (btncaja == "Socios")
                {
                    Conexion.ObtenerConexion();
                    string sql2 = "insert into CajaSocio (monto, condicion, descripcion, fecha, estado, idCajaChica) values (@monto, @condicion, @descripcion, GETDATE(), 'A', @idCajaChica); SELECT SCOPE_IDENTITY()";
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
                    comando2.Parameters.Add("@idCajaChica", SqlDbType.Int).Value = idCajaChica;

                    // Ejecuta el comando y obtén el ID de inserción
                    object result2 = comando2.ExecuteScalar();
                    int idcajaSocio = Convert.ToInt32(result2);
                    Conexion.ObtenerConexion().Close();

                    // Ahora inserta el idCajaGrande en CajaChica
                    Conexion.ObtenerConexion();
                    string sql3 = "update CajaChica set idCajaSocio = @idcajaSocio where idCajaChica = @idCajaChica";
                    SqlCommand comando3 = new SqlCommand(sql3, Conexion.ObtenerConexion());
                    comando3.Parameters.Add("@idcajaSocio", SqlDbType.Int).Value = idcajaSocio;
                    comando3.Parameters.Add("@idCajaChica", SqlDbType.Int).Value = idCajaChica;
                    comando3.ExecuteNonQuery();
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

            // Primero, verifica si idCajaGrande es distinto de null
            string sqlCheck = "select idCajaGrande from CajaChica where idCajaChica = @idCajaChica";
            SqlCommand comandoCheck = new SqlCommand(sqlCheck, Conexion.ObtenerConexion());
            comandoCheck.Parameters.AddWithValue("@idCajaChica", idCajaChica);
            object result = comandoCheck.ExecuteScalar();

            // Primero, verifica si idCajaSocio es distinto de null
            string sqlCheckS = "select idCajaSocio from CajaChica where idCajaChica = @idCajaChica";
            SqlCommand comandoCheckS = new SqlCommand(sqlCheckS, Conexion.ObtenerConexion());
            comandoCheckS.Parameters.AddWithValue("@idCajaChica", idCajaChica);
            object resultS = comandoCheckS.ExecuteScalar();

            // Actualizar el registro en la base de datos con el nuevo monto
            string sqlUpdate = "UPDATE CajaChica SET monto = @monto, descripcion = @descripcion WHERE idCajaChica = @idCajaChica;";
            SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, Conexion.ObtenerConexion());
            comandoUpdate.Parameters.AddWithValue("@monto", nuevoMontoStr);
            comandoUpdate.Parameters.AddWithValue("@descripcion", txtConcepto.Text);
            comandoUpdate.Parameters.AddWithValue("@idCajaChica", idCajaChica);

            int cant = comandoUpdate.ExecuteNonQuery();

            if (result != null && result != DBNull.Value)
            {             
                int idCajaGrande = Convert.ToInt32(result);
                string montoStr = nuevoMontoStr;
                string negativo = "-" + montoStr;

                // Actualizar el registro en la base de datos con el nuevo monto
                string sqlUpdateG = "UPDATE CajaGrande SET monto = @monto, descripcion = @descripcion WHERE idCajaGrande = @idCajaGrande;";
                SqlCommand comandoUpdateG = new SqlCommand(sqlUpdateG, Conexion.ObtenerConexion());

                if (balance == "Egreso")
                {
                    comandoUpdateG.Parameters.AddWithValue("@monto", float.Parse(montoStr));
                }
                else
                {
                    comandoUpdateG.Parameters.AddWithValue("@monto", float.Parse(negativo));
                }

                comandoUpdateG.Parameters.AddWithValue("@descripcion", txtConcepto.Text);
                comandoUpdateG.Parameters.AddWithValue("@idCajaGrande", idCajaGrande);

                comandoUpdateG.ExecuteNonQuery();
            }

            if (resultS != null && resultS != DBNull.Value)
            {
                int idCajaSocio = Convert.ToInt32(resultS);
                string montoStr = nuevoMontoStr;
                string negativo = "-" + montoStr;

                // Actualizar el registro en la base de datos con el nuevo monto
                string sqlUpdateS = "UPDATE CajaSocio SET monto = @monto, descripcion = @descripcion WHERE idCajaSocio = @idCajaSocio;";
                SqlCommand comandoUpdateS = new SqlCommand(sqlUpdateS, Conexion.ObtenerConexion());

                if (balance == "Egreso")
                {
                    comandoUpdateS.Parameters.AddWithValue("@monto", float.Parse(montoStr));
                }
                else
                {
                    comandoUpdateS.Parameters.AddWithValue("@monto", float.Parse(negativo));
                }

                comandoUpdateS.Parameters.AddWithValue("@descripcion", txtConcepto.Text);
                comandoUpdateS.Parameters.AddWithValue("@idCajaSocio", idCajaSocio);

                comandoUpdateS.ExecuteNonQuery();
            }

            if (cant != 0)
            {
                MessageBox.Show("Los datos se modificaron correctamente");
                this.Close();
                cajaChForm.todoload();
            }

            Conexion.ObtenerConexion().Close();
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere eliminar?", "Eliminar", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Conexion.ObtenerConexion();

                // Primero, verifica si idCajaGrande es distinto de null
                string sqlCheck = "select idCajaGrande from CajaChica where idCajaChica = @idCajaChica";
                SqlCommand comandoCheck = new SqlCommand(sqlCheck, Conexion.ObtenerConexion());
                comandoCheck.Parameters.AddWithValue("@idCajaChica", idCajaChica);
                object result = comandoCheck.ExecuteScalar();

                // Primero, verifica si idCajaSocio es distinto de null
                string sqlCheckS = "select idCajaSocio from CajaChica where idCajaChica = @idCajaChica";
                SqlCommand comandoCheckS = new SqlCommand(sqlCheckS, Conexion.ObtenerConexion());
                comandoCheckS.Parameters.AddWithValue("@idCajaChica", idCajaChica);
                object resultS = comandoCheckS.ExecuteScalar();

                string sql2 = "delete from CajaChica where idCajaChica = @idCajaChica";
                SqlCommand comando2 = new SqlCommand(sql2, Conexion.ObtenerConexion());
                comando2.Parameters.AddWithValue("@idCajaChica", idCajaChica);
                comando2.ExecuteNonQuery();

                if (result != null && result != DBNull.Value)
                {
                    int idCajaGrande = Convert.ToInt32(result);

                    // Si idCajaGrande es distinto de null, elimina la fila en CajaGrande
                    string sql1 = "delete from CajaGrande where idCajaGrande = @idCajaGrande";
                    SqlCommand comando1 = new SqlCommand(sql1, Conexion.ObtenerConexion());
                    comando1.Parameters.AddWithValue("@idCajaGrande", idCajaGrande);
                    comando1.ExecuteNonQuery();
                }

                if (resultS != null && resultS != DBNull.Value)
                {
                    int idCajaSocio = Convert.ToInt32(resultS);

                    // Si idCajaGrande es distinto de null, elimina la fila en CajaGrande
                    string sql1 = "delete from CajaSocio where idCajaSocio = @idCajaSocio";
                    SqlCommand comando3 = new SqlCommand(sql1, Conexion.ObtenerConexion());
                    comando3.Parameters.AddWithValue("@idCajaSocio", idCajaSocio);
                    comando3.ExecuteNonQuery();
                }

                MessageBox.Show("Se eliminó correctamente");
                Conexion.ObtenerConexion().Close();
                this.Close();
                cajaChForm.todoload();
            }
        }

    }
}

