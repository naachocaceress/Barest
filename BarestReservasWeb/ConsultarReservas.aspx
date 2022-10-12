<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarReservas.aspx.cs" Inherits="BarestReservasWeb.ConsultarReservas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consultar reservas</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Firma.css" rel="stylesheet" />
    <link href="estilo.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <!-- -------------------------------------------------------------------------------------------------- -->

        <div class="container">
            <header class="d-flex flex-wrap justify-content-center py-3 mb-4 border-bottom">
                <a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
                    <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Imagenes/Barest (NUEVO COLOR).png" Width="60px" />
                    <span class="fs-4">
                        <p style="text-align: top">&nbsp;BAREST Reservas</p>
                    </span>
                </a>

                <ul class="nav nav-pills">
                    <li class="nav-item"><a href="Default.aspx" class="nav-link" aria-current="page" style="color: #008069">Menu</a></li>
                    <li class="nav-item"><a href="Agregar.aspx" class="nav-link " style="color: #008069">Agregar</a></li>
                    <li class="nav-item"><a href="ConsultarReservas.aspx" class="nav-link active" style="background-color: #008069">Consultar</a></li>
                    <li class="nav-item"><a href="Info.aspx" class="nav-link" style="color: #008069">Info.</a></li>
                </ul>
            </header>
        </div>

        <!-- -------------------------------------------------------------------------------------------------- -->

        <div align="center" class="active">
            <h4>CONSULTA DE RESERVAS</h4>



            <div class="padre" align="center">
            <div class="hijo">
            <table class="table">
                <tr>
                    <td style="text-align:center">Buscar por fecha</td>
                    <td>&nbsp;</td>
                    <td style="text-align:center">Buscar por sucursal</td>
                </tr>
                <tr>
                    <td style="text-align:center"> 
                        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="120px" Width="214px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                    <td style="text-align:center">

                        <br />
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="descripcion" DataValueField="descripcion">
                        </asp:DropDownList>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>" SelectCommand="SELECT [descripcion] FROM [Sucursal]"></asp:SqlDataSource>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Buscar" />

                    </td>
                </tr>
            </table>

                </div>
         </div>
            <br />

            <asp:SqlDataSource ID="SqlReservas" runat="server"
                ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>"
                SelectCommand="SELECT codigo, nombre, apellido, telefono, fechaReserva, posicion, cantComensales, hora, comentarios, estado, sucursal FROM Reserva WHERE (estado = 'DISPONIBLE')" UpdateCommand="UPDATE Reserva SET nombre = @nombre, apellido = @apellido, telefono =@telefono, fechaReserva = @fechaReserva, posicion = @posicion, cantComensales = @cantComensales, hora = @hora, comentarios = @comentarios, sucursal = @sucursal WHERE (codigo = @codigo)">
                <UpdateParameters>
                    <asp:Parameter Name="nombre" />
                    <asp:Parameter Name="apellido" />
                    <asp:Parameter Name="telefono" />
                    <asp:Parameter Name="fechaReserva" />
                    <asp:Parameter Name="posicion" />
                    <asp:Parameter Name="cantComensales" />
                    <asp:Parameter Name="hora" />
                    <asp:Parameter Name="comentarios" />
                    <asp:Parameter Name="sucursal" />
                    <asp:Parameter Name="codigo" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlReservas0" runat="server"
                ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>"
                SelectCommand="SELECT codigo, nombre, apellido, telefono, fechaReserva, posicion, cantComensales, hora, comentarios, estado, sucursal FROM Reserva WHERE (estado = 'ANULADO')" UpdateCommand="UPDATE Reserva SET nombre = @nombre, apellido = @apellido, telefono =@telefono, fechaReserva = @fechaReserva, posicion = @posicion, cantComensales = @cantComensales, hora = @hora, comentarios = @comentarios, sucursal = @sucursal WHERE (codigo = @codigo)">
                <UpdateParameters>
                    <asp:Parameter Name="nombre" />
                    <asp:Parameter Name="apellido" />
                    <asp:Parameter Name="telefono" />
                    <asp:Parameter Name="fechaReserva" />
                    <asp:Parameter Name="posicion" />
                    <asp:Parameter Name="cantComensales" />
                    <asp:Parameter Name="hora" />
                    <asp:Parameter Name="comentarios" />
                    <asp:Parameter Name="sucursal" />
                    <asp:Parameter Name="codigo" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlReservas1" runat="server"
                ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>"
                SelectCommand="SELECT codigo, nombre, apellido, telefono, fechaReserva, posicion, cantComensales, hora, comentarios, estado, sucursal FROM Reserva WHERE (estado = 'DISPONIBLE')" UpdateCommand="UPDATE Reserva SET  estado = 'ANULADO' WHERE (codigo = @codigo)">
                <UpdateParameters>
                    <asp:Parameter Name="codigo" DefaultValue="" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlReservas2" runat="server"
                ConnectionString="<%$ ConnectionStrings:BARESTNEWConnectionString1 %>"
                SelectCommand="SELECT codigo, nombre, apellido, telefono, fechaReserva, posicion, cantComensales, hora, comentarios, estado, sucursal FROM Reserva WHERE (estado = 'DISPONIBLE')" UpdateCommand="UPDATE Reserva SET  estado = 'DISPONIBLE' WHERE (codigo = @codigo)">
                <UpdateParameters>
                    <asp:Parameter Name="codigo" DefaultValue="" />
                </UpdateParameters>
            </asp:SqlDataSource>

            DISPONIBLE<br />
            <br />

            <!-- -------------------------------------------------------------------------------------------------- -->

            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="False" DataKeyNames="codigo" DataSourceID="SqlReservas" CssClass="mGrid" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" OnSelectedIndexChanged="GridView_SelectedIndexChanged1">
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
                    <asp:BoundField DataField="sucursal" HeaderText="Sucursal" SortExpression="sucursal" />
                    <asp:CommandField ButtonType="Button" HeaderText="Actualizar" ShowEditButton="True" ShowHeader="True" ShowSelectButton="True" SelectText="Anular"/>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#008069" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
            <br />
&nbsp;ANULADO<br />
            <br />
            <asp:GridView ID="GridView2" runat="server"
                AutoGenerateColumns="False" DataKeyNames="codigo" DataSourceID="SqlReservas0" CssClass="mGrid" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
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
                    <asp:BoundField DataField="sucursal" HeaderText="Sucursal" SortExpression="sucursal" />
                    <asp:CommandField ButtonType="Button" HeaderText="Actualizar" ShowEditButton="True" ShowHeader="True" ShowSelectButton="True" SelectText="Disponible" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#D9604E" Font-Bold="True" ForeColor="White" />
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
            <br />
            <hr align="center" id="re" />
            <br />
            <a href="https://bares.atlassian.net/jira/software/projects/BAR/boards/1">
                <img src="Imagenes/Barest (NUEVO COLOR).png" />
            </a>
            <p>Desarollado por <b>Grupo Barest</b></p>
        </div>

    </form>
</body>
</html>
