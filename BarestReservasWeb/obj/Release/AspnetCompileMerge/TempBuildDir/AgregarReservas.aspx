<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarReservas.aspx.cs" Inherits="BarestReservasWeb.AgregarReservas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar reservas</title>

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
        <li class="nav-item"><a href="AgregarReservas.aspx" class="nav-link active" style="background-color:#008069">Agregar</a></li>
        <li class="nav-item"><a href="ConsultarReservas.aspx" class="nav-link" style="color:#008069">Consultar</a></li>
        <li class="nav-item"><a href="Info.aspx" class="nav-link" style="color:#008069">Info.</a></li>
      </ul>
    </header>
  </div>

        <h4 style="text-align:center">AGREGAR RESERVAS</h4><br />
        
        <div class="padre" align="center">
            <div class"hijo">
            <table class="table">
                <tr>
                    <td>Nombre:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                
                    <td>Apellido:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Telefono:</td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    
                    <td>Mesa:</td>
                    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>PAX:</td>
                    <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>

                    <td>Hora:</td>
                    <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Fecha:</td>
                    <td><asp:Calendar ID="Calendar1" runat="server" Height="180px" Width="200px" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar></td>

                    <td>Comentarios:</td>
                    <td><asp:TextBox ID="TextBox4" runat="server" Height="180px" Width="200px"></asp:TextBox></td>
                </tr>
            </table>
            </div>
         </div>
        <div style="text-align:center">
            <asp:Button ID="AgregarBtn" runat="server" Text="Agregar" OnClick="AgregarBtn_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="CancelarBtn" runat="server" Text="Cancelar" />
        </div>
        <br />


    <div id="Final">
    <br /><hr align="center" id="re" /><br />
    <a href="https://www.instagram.com/naachocaceres/"> <img src="Imagenes/Neptune.png" /> </a>
	<p>Desarollado por <b>NachoCaceres</b></p>
	</div>

    </form>
</body>
</html>
