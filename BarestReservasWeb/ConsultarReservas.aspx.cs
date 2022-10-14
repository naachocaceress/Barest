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


        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;

            String codigo = row.Cells[0].Text;

            SqlReservas2.UpdateParameters["codigo"].DefaultValue = codigo;
            SqlReservas2.Update();

            Response.Redirect("ConsultarReservas.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            GridView1.DataSourceID = "SqlSucursal";
            GridView2.DataSourceID = "SqlSucursal0";

            SqlSucursal.SelectParameters["sucursal"].DefaultValue = DropDownList1.Text;
            SqlSucursal0.SelectParameters["sucursal"].DefaultValue = DropDownList1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSourceID = "SqlxFecha";
            GridView2.DataSourceID = "SqlxFecha0";

            SqlxFecha.SelectParameters["fecha"].DefaultValue = Calendar2.SelectedDate.ToShortDateString();
            SqlxFecha.SelectParameters["sucursal"].DefaultValue = DropDownList1.Text;
            SqlxFecha0.SelectParameters["fecha"].DefaultValue = Calendar2.SelectedDate.ToShortDateString();
            SqlxFecha.SelectParameters["sucursal"].DefaultValue = DropDownList1.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarReservas.aspx");
        }
    }
}