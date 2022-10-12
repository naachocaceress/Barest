using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BarestReservasWeb
{
    public partial class AgregarSucursal1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.ForeColor = System.Drawing.Color.White;
            TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
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
                    SqlDataSource2.InsertParameters["nombre"].DefaultValue = TextBox1.Text;
                    SqlDataSource2.Insert();
                    Response.Redirect("AgregarSucursal.aspx");
                }
            }
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}