<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarReservas.aspx.cs" Inherits="BarestReservasWeb.ConsultarReservas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar reservas</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Firma.css"rel="stylesheet" />
    <link href="estilo.css"rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

<!-- -------------------------------------------------------------------------------------------------- -->

        <div class="container">
    <header class="d-flex flex-wrap justify-content-center py-3 mb-4 border-bottom">
      <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
        <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Imagenes/Barest (NUEVO COLOR).png" Width="60px" />
        <span class="fs-4"><p style="text-align:top">&nbsp;BAREST Reservas</p></span>
      </a>

      <ul class="nav nav-pills">
        <li class="nav-item"><a href="Default.aspx" class="nav-link" aria-current="page" style="color:#008069">Menu</a></li>
        <li class="nav-item"><a href="AgregarReservas.aspx" class="nav-link " style="color:#008069">Agregar</a></li>
        <li class="nav-item"><a href="ConsultarReservas.aspx" class="nav-link active" style="background-color:#008069">Consultar</a></li>
        <li class="nav-item"><a href="Info.aspx" class="nav-link" style="color:#008069">Info.</a></li>
      </ul>
    </header>
  </div>

<!-- -------------------------------------------------------------------------------------------------- -->

        <div align="center" class="active">
            <h4>CONSULTA DE RESERVAS</h4>
            <br />

<!-- -------------------------------------------------------------------------------------------------- -->

            <asp:SqlDataSource ID="SqlReservas" runat="server"
                ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>"
                SelectCommand="SELECT [codigo], [nombre], [apellido], [telefono], [fechaReserva], [posicion], [cantComensales], [hora], [comentarios], [estado] FROM [Reserva]">
            </asp:SqlDataSource>
            <br />

<!-- -------------------------------------------------------------------------------------------------- -->

            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="False" DataKeyNames="codigo" DataSourceID="SqlReservas" CssClass="mGrid" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="codigo" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" SortExpression="apellido" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" SortExpression="telefono" />
                    <asp:BoundField DataField="fechaReserva" HeaderText="Fecha" SortExpression="fechaReserva" />
                    <asp:BoundField DataField="posicion" HeaderText="Posicion" SortExpression="posicion" />
                    <asp:BoundField DataField="cantComensales" HeaderText="PAX" SortExpression="cantComensales" />
                    <asp:BoundField DataField="hora" HeaderText="Hora" SortExpression="hora" />
                    <asp:BoundField DataField="comentarios" HeaderText="Comentarios" SortExpression="comentarios" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle  BackColor="#008069" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>

            <br />
        </div> 

        <div id="Final">
    <br /><hr align="center" id="re" /><br />
    <a href="https://www.instagram.com/naachocaceres/"> <img src="Imagenes/Neptune.png" /> </a>
	<p>Desarollado por <b>NachoCaceres</b></p>
	</div> 

    </form>
</body>
</html>
