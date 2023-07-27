using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BAREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            panelInicio.Visible = true;
            panelNuevo.Visible = false;
            labelOpciones.Text = "Nuevo Usuario";

        }

        // ESQUINAS REDONDEADAS ---------------------------------------------------------------------

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        // ------------------------------------------------------------------------------------------

        private void button1_Click_1(object sender, EventArgs e)
        {
            logiarse();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logiarse();
            }
        }

        // METODO PARA INCIAR SESION
        private void logiarse()
        {
            Conexion.ObtenerConexion();
            string sql = "select documento,contraseña from Usuario WHERE documento = @documento AND contraseña = @contra";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@documento", tboxUsuario.Text);
            comando.Parameters.AddWithValue("@contra", tboxContraseña.Text);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                inicio m = new inicio();
                m.label2.Text = tboxUsuario.Text;
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos, intenta de nuevo");
                tboxUsuario.Clear();
                tboxContraseña.Clear();
                tboxUsuario.Focus();
            }
            dr.Close();
            Conexion.ObtenerConexion().Close();
        }

        int posY = 0, posX = 0;

        private void labelOpciones_Click(object sender, EventArgs e)
        {
            if (labelOpciones.Text == "Nuevo Usuario")
            {
                panelInicio.Visible = false;
                panelNuevo.Visible = true;
                labelOpciones.Text = " Iniciar Sesion";
            }
            else
            {
                panelInicio.Visible = true;
                panelNuevo.Visible = false;
                labelOpciones.Text = "Nuevo Usuario";
            }
        }
        bool existeUsuario()
        {
            bool existe = false;
            try
            {
                Conexion.ObtenerConexion();
                String sql = " select documento from Usuario where documento like @doc";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@doc", textUsuario.Text);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                    existe = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Conexion.ObtenerConexion().Close();
            return existe;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (existeUsuario())
            {
                MessageBox.Show("Existe un Usuario el documento  inen el sistema! comunique con el Administrador para recuperar su cuenta");
                return;
            }
            if (textUsuario.Text == "Documento" || textContra.Text == "Contraseña" || textCorreo.Text == "Mail")
            {
                MessageBox.Show("Faltan ingresar datos, algun campo contiene datos por defecto");
                return;
            }
            else
            {
                Conexion.ObtenerConexion();
                String sql = " insert into Usuario (documento,contraseña,email,idSucursal,idCargo,fechaNacimiento) values(@documento,@contra,@correo,'6','5',@fecha)";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@documento", textUsuario.Text);
                comando.Parameters.AddWithValue("@contra", textContra.Text);
                comando.Parameters.AddWithValue("@correo", textCorreo.Text);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                comando.ExecuteNonQuery();
                textUsuario.Text = " ";
                textContra.Text = "";
                textCorreo.Text = "";
                Conexion.ObtenerConexion().Close();
                MessageBox.Show("Nuevo Usuario se registro correctamente");
            }
        }

        //-------------------------------------------------------------------

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Documento")
            {
                textUsuario.Text = "";
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "Documento";
                textUsuario.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textUsuario.Text = "Documento";
            textContra.Text = "Contraseña";
            textCorreo.Text = "Mail";
        }

        private void textContra_Enter(object sender, EventArgs e)
        {
            if (textContra.Text == "Contraseña")
            {
                textContra.Text = "";
            }
        }

        private void textContra_Leave(object sender, EventArgs e)
        {
            if (textContra.Text == "")
            {
                textContra.Text = "Contraseña";
                textContra.ForeColor = Color.Gray;
            }
        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Text == "Mail")
            {
                textCorreo.Text = "";
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            {
                textCorreo.Text = "Mail";
                textCorreo.ForeColor = Color.Gray;
            }
        }



        private void panelNuevo_Paint(object sender, PaintEventArgs e)
        {

        }






        //-------------------------------------------------------------------

        private void panelMovimiento_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        //--------------------------------------------------------
    }
}
