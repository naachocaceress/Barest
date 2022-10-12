<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="BarestReservasWeb.AgregarSucursal1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar sucursal</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Firma.css"rel="stylesheet" />
    <link href="estilo.css"rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
    <header class="d-flex flex-wrap justify-content-center py-3 mb-4 border-bottom">
      <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
        <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Imagenes/Barest (NUEVO COLOR).png" Width="60px" />
        <span class="fs-4"><p style="text-align:top">&nbsp;BAREST Reservas</p></span>
      </a>

      <ul class="nav nav-pills">
        <li class="nav-item"><a href="Default.aspx" class="nav-link" aria-current="page" style="color:#008069">Menu</a></li>
        <li class="nav-item"><a href="Agregar.aspx" class="nav-link active" style="background-color:#008069">Agregar</a></li>
        <li class="nav-item"><a href="ConsultarReservas.aspx" class="nav-link" style="color:#008069">Consultar</a></li>
        <li class="nav-item"><a href="Info.aspx" class="nav-link" style="color:#008069">Info.</a></li>
      </ul>
    </header>
  </div>

        <div align="center">
            <h4 style="text-align:center">AGREGAR SUCURSAL<br />
            <h6 style="text-align:center"><asp:Label ID="Label2" runat="server" ForeColor="White" Text="."></asp:Label></h6></h4>
        
        <div class="padre" align="center">
            <div class="hijo">
                <table class="table">
                <tr>
                    <td align="center">Sucursal nueva: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />

                        &nbsp;&nbsp;

                        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
                    </td>             
                </tr>
                    <tr>
                        <td align="center">
                            <br />
                            Sucursales disponibles<br />
                            <asp:ListBox ID="ListBox1" runat="server" Height="107px" Width="138px" DataSourceID="SqlDataSource1" DataTextField="descripcion" DataValueField="id">
                                <asp:ListItem>Alta Cordoba</asp:ListItem>
                                <asp:ListItem>Nueva Cordoba</asp:ListItem>
                                <asp:ListItem>Cerro</asp:ListItem>
                                <asp:ListItem>Barrio Jardin</asp:ListItem>
                                <asp:ListItem>Rondeou</asp:ListItem>
                            </asp:ListBox>

                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>" SelectCommand="SELECT * FROM [Sucursal]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>" InsertCommand="insert into Sucursal (descripcion) values (@nombre)" SelectCommand="SELECT * FROM [Sucursales]">
                                <InsertParameters>
                                    <asp:Parameter Name="nombre" />
                                </InsertParameters>
                            </asp:SqlDataSource>

                        </td>
                    </tr>
                
            </table>

        </div>
        </div>

        </div>

        <div id="Final">
    <br /><hr align="center" id="re" /><br />
    <a href="https://bares.atlassian.net/jira/software/projects/BAR/boards/1"> <img src="Imagenes/Barest (NUEVO COLOR).png" /> </a>
	<p>Desarollado por <b>Grupo Barest</b></p>
	</div>

    </form>
</body>
</html>
