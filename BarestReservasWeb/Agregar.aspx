<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="BarestReservasWeb.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Firma.css"rel="stylesheet" />

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
        <li class="nav-item"><a href="Default.aspx" class="nav-link " aria-current="page" style="Color:#008069">Menu</a></li>
        <li class="nav-item"><a href="Agregar.aspx" class="nav-link active" style="background-color:#008069">Agregar</a></li>
        <li class="nav-item"><a href="ConsultarReservas.aspx" class="nav-link" style="color:#008069">Consultar</a></li>
        <li class="nav-item"><a href="Info.aspx" class="nav-link" style="color:#008069">Info.</a></li>
      </ul>
    </header>
  </div>

        <div align="center">
            <h4>AGREGAR</h4><br />
            <dl>
                <dd><a href="AgregarReservas.aspx" style="text-decoration:none; color:#008069; font-size:18px">Agregar Reservas</a></dd>
                <dd><a href="AgregarSucursal.aspx" style="text-decoration:none; color:#008069; font-size:18px">Agregar Sucursales</a></dd>
            </dl>
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
