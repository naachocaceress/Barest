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

namespace BAREST
{
    public partial class Usuarios: Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public static class Nusuario
        {
            public static string valorUsuario = "";
        }

        void capturaUsuario()
        {
              var SUsuario = tablaUsua.Rows[tablaUsua.CurrentCell.RowIndex].Cells["documento"].Value.ToString();
            Nusuario.valorUsuario = SUsuario;
            if(SUsuario == "")
            {

            }
            else
            {
                selectColUsuario();
            }
        }

        void selectColUsuario()
        {
            string sql = " select  documento,email,nombre,apellido,telefono,fechaNacimiento,s.descripcion,c.descripcion from Usuario inner join Sucursal as s on s.id= idSucursal inner join cargo as c on c.id=idCargo where documento= @documento";
            try
            {
                Conexion.ObtenerConexion();
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@documento",SqlDbType.VarChar).Value= Nusuario.valorUsuario;
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                {
                    //textid.Text = leido["id"].ToString();
                    textDocumento.Text = leido["documento"].ToString();
                    textEmail.Text = leido["email"].ToString();
                    textNombre.Text = leido["nombre"].ToString();
                    textApellido.Text = leido["apellido"].ToString();
                    textTelefono.Text = leido["telefono"].ToString();
                    dateTimePicker1.Value = DateTime.Today;
                    comboSucursal.SelectedItem = leido["s.descripcion"].ToString();
                    comboCargo.SelectedItem = leido["c.descripcion"].ToString();

                    string hola = leido["fechaDeNacimiento"].ToString();

                    string[] separarFecha = hola.Split('/');
                    string dia = separarFecha[0];
                    string mes = separarFecha[1];
                    string anio = separarFecha[2];

                    int dia2 = Int32.Parse(dia);
                    int mes2 = Int32.Parse(mes);

                    string[] separardeHora = anio.Split(' ');
                    string ani = separardeHora[0];

                    int anio2 = Int32.Parse(ani);

                    DateTime dt = new DateTime(anio2, mes2, dia2);
                    dateTimePicker1.Value = dt;
                }
                else
                {
                    

                }
                leido.Close();
                Conexion.ObtenerConexion().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void modificarUsuario()
        {
            /*string resultado = "";
            try
            {
                if (true)//(MessageBox.Show("Desea guardar la modificación?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    resultado = "exito";
                    Conexion.ObtenerConexion();
                    string sql = " update Usuario set documento=@documento,email=@email,nombre=@nombre,apellido=@apellido,telefono=@telefono,fechaNacimiento=@fechaNacimiento,idSucursal=@idSucursal,idCargo=@IdCargowhere id = @id";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    //SqlCommand comando = new SqlCommand();
                    //comando.CommandText = "modificarUsuario";
                    comando.Parameters.Add("@documento", SqlDbType.VarChar).Value = textDocumento.Text;
                    comando.Parameters.Add("@email", SqlDbType.VarChar).Value = textEmail.Text;
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApellido.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTelefono.Text;
                    comando.Parameters.Add("@fechaNacimeinto", SqlDbType.VarChar).Value = dateTimePicker1.Value;
                    comando.Parameters.Add("@idSucursal", SqlDbType.VarChar).Value = comboSucursal.SelectedValue;
                    comando.Parameters.Add("@idCargo", SqlDbType.VarChar).Value = comboCargo.SelectedValue;
                  //  comando.Parameters.Add("@id", SqlDbType.Int).Value = textid.Text;
                    comando.ExecuteNonQuery();
                   // comando.Parameters.Clear();
                    Conexion.ObtenerConexion().Close();
                }
                else
                {
                    MessageBox.Show("Hubo problema en guardar los datos");
                    resultado = "error";
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            */
        }
        public void limpiarcampo()
        {
            textDocumento.Text = "";
            textEmail.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textTelefono.Text = "";
            textDocumento.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboCargo.SelectedIndex= 0;
            comboSucursal.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        //-------------------- PARA VERIFICAR SI EXISTE -----------------------------------
         // yo no es necesario porque  llamamos con dobleclick  un usuario
       private bool Inscripto() 
       { 
        
            Conexion.ObtenerConexion();
            string sql = "select * from Usuario where documento=@documento";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@documento", SqlDbType.Char).Value = textDocumento.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Conexion.ObtenerConexion().Close();
            return existe;
       }

        //--------------------------------------------------------------------------------

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // A MODIFICAR EL UPDATE
        private void button3_Click(object sender, EventArgs e)
        {
            if (textDocumento.Text == "")
            {
                MessageBox.Show("Es necesario buscar el usuario para modificarlo");
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = "update Usuario set documento = @documento,email = @email,nombre = @nombre,apellido = @apellido,telefono = @telefono,fechaNacimiento = @fechaNacimiento, idSucursal = @idSucursal, idCargo = @IdCargo where documento = @documento";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@documento", SqlDbType.VarChar).Value = textDocumento.Text;
                comando.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = textEmail.Text;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = textApellido.Text;
                comando.Parameters.AddWithValue("@telefono", SqlDbType.VarChar).Value = textTelefono.Text;
                comando.Parameters.AddWithValue("@fechaNacimiento", SqlDbType.VarChar).Value = dateTimePicker1.Value;
                comando.Parameters.AddWithValue("@idSucursal", SqlDbType.Int).Value = comboSucursal.SelectedValue.ToString();
                comando.Parameters.AddWithValue("@IdCargo", SqlDbType.Int).Value = comboCargo.SelectedValue.ToString();
                
                int cant = comando.ExecuteNonQuery();
                if (cant != 0)
                {
                    MessageBox.Show("Los datos se modificaron correctamente");
                    limpiarcampo();
                }
                Conexion.ObtenerConexion().Close();
                CargarGrilla();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            capturaUsuario();
           /* string resultado = "";
            string BuscarUsu = tablaUsua.Rows[tablaUsua.CurrentRow.Index].Cells["documento"].Value.ToString();
            if (textDocumento.Text == " ")
            {

                //MessageBox.Show("Ingrese su documento");
                try
                {
                    Conexion.ObtenerConexion();
                    SqlCommand comando = new SqlCommand(Conexion.ObtenerString());
                    comando.CommandText = "listaUsuario";
                    comando.Parameters.AddWithValue("@documento", BuscarUsu);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        resultado = "Exito";
                        textDocumento.Text = leido["documento"].ToString();
                        textEmail.Text = leido["email"].ToString();
                        textNombre.Text = leido["nombre"].ToString();
                        textApellido.Text = leido["apellido"].ToString();
                        textTelefono.Text = leido["telefono"].ToString();
                        dateTimePicker1.Value = DateTime.Today;
                        comboSucursal.SelectedItem = leido["s.descripcion"].ToString();
                        comboCargo.SelectedItem = leido["c.descripcion"].ToString();

                        string hola = leido["fechaDeNacimiento"].ToString();

                        string[] separarFecha = hola.Split('/');
                        string dia = separarFecha[0];
                        string mes = separarFecha[1];
                        string anio = separarFecha[2];

                        int dia2 = Int32.Parse(dia);
                        int mes2 = Int32.Parse(mes);

                        string[] separardeHora = anio.Split(' ');
                        string ani = separardeHora[0];

                        int anio2 = Int32.Parse(ani);

                        DateTime dt = new DateTime(anio2, mes2, dia2);
                        dateTimePicker1.Value = dt;
                    }
                    else
                    {
                        resultado = "Fallo";

                    }
                    leido.Close();
                    Conexion.ObtenerConexion().Close();
                }
                catch (Exception ex)
                {
                    resultado = ex.Message;
                   
                }
            }
            else
            {
                MessageBox.Show("PROBLEMA EN LA BUSQUEDA DE USUARIO");

                /* string BuscarUsu = tablaUsua.Rows[tablaUsua.CurrentRow.Index].Cells["dni"].Value.ToString();

                 Conexion.ObtenerConexion();
                 string sql = "select dni, nombrePersona,apellidoPersona,telefonoPersona,fechaDeNacimiento from Persona where dni= @dni";
                 SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                 comando.Parameters.AddWithValue("@dni", BuscarUsu);
                 SqlDataReader leido = comando.ExecuteReader();
                 if (leido.Read())
                 {
                     textDocumento.Text = leido["dni"].ToString();
                     textNombre.Text = leido["nombrePersona"].ToString();
                     textApellido.Text = leido["apellidoPersona"].ToString();
                     textTelefono.Text = leido["telefonoPersona"].ToString();

                     //---PARA PODER PONER LA FECHA EN EL DATATIMEPICKER---

                     string hola = leido["fechaDeNacimiento"].ToString();

                     string[] separarFecha = hola.Split('/');
                     string dia = separarFecha[0];
                     string mes = separarFecha[1];
                     string anio = separarFecha[2];

                     int dia2 = Int32.Parse(dia);
                     int mes2 = Int32.Parse(mes);

                     string[] separardeHora = anio.Split(' ');
                     string ani = separardeHora[0];

                     int anio2 = Int32.Parse(ani);

                     DateTime dt = new DateTime(anio2, mes2, dia2);
                     dateTimePicker1.Value = dt;

                     //--------------------------------------------------
                 }
                 else
                 {
                     MessageBox.Show("No hay un usuario con ese 'documento'");
                 }
                 leido.Close();
                 Conexion.ObtenerConexion().Close();
            }*/
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textDocumento.Text == "")
            {
                MessageBox.Show("Es necesario buscar el usuario para eliminarlo"); 
            }
            else 
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Usuario", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Conexion.ObtenerConexion();
                    string sql = "delete from Persona where dni= @dni";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = textDocumento.Text;
                    int cant = comando.ExecuteNonQuery();
                    MessageBox.Show("Se eliminó el usuario: " + textNombre.Text);
                    Conexion.ObtenerConexion().Close();
                    CargarGrilla();
                    textNombre.Text = "";
                    textApellido.Text = "";
                    textTelefono.Text = "";
                    textDocumento.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            cargarCargo();
            cargarSucursal();
        }

        private void CargarGrilla()
        {
            Conexion.ObtenerConexion();
            string sql = "select  documento,email,nombre,apellido,telefono,fechaNacimiento,s.descripcion as sucursal,c.descripcion as cargo from Usuario inner join Sucursal as s on s.id= idSucursal inner join cargo as c on c.id=idCargo order by nombre asc";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaUsua.Rows.Clear();
            while (registros.Read())
            {
                tablaUsua.Rows.Add(
                    registros["documento"].ToString(),
                    registros["email"].ToString(),
                    registros["nombre"].ToString(),
                    registros["apellido"].ToString(),
                    registros["telefono"].ToString(),
                    registros["fechaNacimiento"].ToString(),
                    registros["sucursal"].ToString(),
                    registros["cargo"].ToString()
                    );
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
       

        public void cargarSucursal()
        {
            Conexion.ObtenerConexion();
            string sql = " SELECT TOP (10) [id],[descripcion] FROM[BARESTNEW].[dbo].[Sucursal]";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            comboSucursal.ValueMember = "id";
            comboSucursal.DisplayMember = "descripcion";
            DataRow dataRow = table.NewRow();
            dataRow[0] = 0;
            dataRow[1] = "Select";
            table.Rows.InsertAt(dataRow, 0);
            comboSucursal.DataSource = table;
            Conexion.ObtenerConexion().Close();
        }
        public void cargarCargo()
        {
            Conexion.ObtenerConexion();
            string sql = " SELECT TOP (10) [id],[descripcion] FROM[BARESTNEW].[dbo].[Cargo]";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            comboCargo.ValueMember = "id";
            comboCargo.DisplayMember = "descripcion";
            DataRow dataRow = table.NewRow();
            dataRow[0] = 0;
            dataRow[1] = "Select";
            table.Rows.InsertAt(dataRow, 0);
            comboCargo.DataSource = table;
            Conexion.ObtenerConexion().Close();
        }

        private void tablaUsua_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textDocumento.Text = tablaUsua.CurrentRow.Cells[0].Value.ToString();
            textEmail.Text= tablaUsua.CurrentRow.Cells[1].Value.ToString();
            textNombre.Text = tablaUsua.CurrentRow.Cells[2].Value.ToString();
            textApellido.Text= tablaUsua.CurrentRow.Cells[3].Value.ToString();
            textTelefono.Text= tablaUsua.CurrentRow.Cells[4].Value.ToString();
            object dtablaUsua = tablaUsua.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dtablaUsua); // tablaUsua.CurrentRow.Cells[4].Value.ToString()
            comboSucursal.SelectedItem= tablaUsua.CurrentRow.Cells[6].Value.ToString();
            comboCargo.SelectedItem= tablaUsua.CurrentRow.Cells[7].Value.ToString();

        }

        void buscarUsuarios()
        {
            string sql = " select documento,email,nombre,apellido,telefono,fechaNacimiento,s.descripcion,c.descripcion from Usuario inner join Sucursal as s on s.id= idSucursal inner join cargo as c on c.id=idCargo where ";

        }
        public DataTable Usuario()
        {
           var BuscarUsu = tablaUsua.Rows[tablaUsua.CurrentRow.Index].Cells["documento"].Value.ToString();
            Conexion.ObtenerConexion();
            string sql = "select  documento,email,nombre,apellido,telefono,fechaNacimiento,s.descripcion as sucursal,c.descripcion as cargo from Usuario inner join Sucursal as s on s.id= idSucursal inner join cargo as c on c.id=idCargo where documento = "+ BuscarUsu +" ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            DataTable table = new DataTable();
            Conexion.ObtenerConexion().Close();
            return table;
        }

        private void tablaUsua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
