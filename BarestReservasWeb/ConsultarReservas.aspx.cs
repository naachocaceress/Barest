using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BarestReservasWeb
{
    public partial class ConsultarReservas : System.Web.UI.Page
    {
        //public SqlConnection cn = new SqlConnection("Data Source=NACHO-PC/SQLEXPRESS;Initial Catalog=BARESTNEW;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void GridView_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            String codigo = row.Cells[0].Text;

            SqlReservas1.UpdateParameters["codigo"].DefaultValue = codigo;
            SqlReservas1.Update();

            Response.Redirect("ConsultarReservas.aspx");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;

            String codigo = row.Cells[0].Text;

            SqlReservas2.UpdateParameters["codigo"].DefaultValue = codigo;
            SqlReservas2.Update();

            Response.Redirect("ConsultarReservas.aspx");
        }
    }
}