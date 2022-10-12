<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="BarestReservasWeb.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Informacion</title>
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
        <li class="nav-item"><a href="Default.aspx" class="nav-link" aria-current="page" style="color:#008069">Menu</a></li>
        <li class="nav-item"><a href="Agregar.aspx" class="nav-link" style="color:#008069">Agregar</a></li>
        <li class="nav-item"><a href="ConsultarReservas.aspx" class="nav-link" style="color:#008069">Consultar</a></li>
        <li class="nav-item"><a href="Info.aspx" class="nav-link active" style="background-color:#008069">Info.</a></li>
      </ul>
    </header>
  </div>

        <div align="center">
            <p>Barest 2022
            Version Web 1.2
            © 2022 Grupo Barest.
            Todos los derechos reservados.</p>
            <br />
             <p>Este sistema forma parte de de la Tesis 
            de Analista en Sistemas de Computacion 
            relizado en el Instituto Superior Santo Domingo
            del año 2022.</p>
            <br />
             <p>Advertencia: este programa esta protegido por leyes de derechos de autor y otros tratados internacionales. 
            La reproduccion o distribucion ilicita de este programa o de cualquier parte del mismo esta penada por
            la ley con severas sanciones civiles y penales y sera objeto de todas las acciones judiciales que 
            correspondan.</p>
        </div>

        <div id="Final">
    <br /><hr align="center" id="re" /><br />
    <a href="https://bares.atlassian.net/jira/software/projects/BAR/boards/1"> <img src="Imagenes/Barest (NUEVO COLOR).png" /> </a>
	<p>Desarollado por <b>Grupo Barest</b></p>
	</div>

    </form>
</body>
</html>
