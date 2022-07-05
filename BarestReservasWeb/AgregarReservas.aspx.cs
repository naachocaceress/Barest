using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BarestReservasWeb
{
    public partial class AgregarReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "")
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "Falta agregar una sucursal";
            }
            else
            {

                if (TextBox1.Text == "")
                {
                    Label2.ForeColor = System.Drawing.Color.Red;
                    Label2.Text = "Falta agregar un nombre";
                }
                else
                {
                    if (IsValid)
                    {
                        SqlDataSource1.InsertParameters["nombre"].DefaultValue = TextBox1.Text;
                        SqlDataSource1.InsertParameters["apellido"].DefaultValue = TextBox2.Text;
                        SqlDataSource1.InsertParameters["telefono"].DefaultValue = TextBox3.Text;
                        SqlDataSource1.InsertParameters["posicion"].DefaultValue = TextBox5.Text;
                        SqlDataSource1.InsertParameters["cant"].DefaultValue = TextBox6.Text;
                        SqlDataSource1.InsertParameters["hora"].DefaultValue = TextBox7.Text;
                        SqlDataSource1.InsertParameters["fecha"].DefaultValue = Calendar1.SelectedDate.ToShortDateString();
                        SqlDataSource1.InsertParameters["com"].DefaultValue = TextBox4.Text;
                        SqlDataSource1.InsertParameters["estado"].DefaultValue = "DISPONIBLE";
                        SqlDataSource1.InsertParameters["sucursal"].DefaultValue = DropDownList1.Text;
                        SqlDataSource1.Insert();
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        Label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#008069");
                        Label2.Text = "Los datos fueron cargados correctamente";
                    }
                }
            }
        }

        protected void CancelarBtn_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Text = ".";
            DropDownList1.SelectedValue = "";
        }
    }
}