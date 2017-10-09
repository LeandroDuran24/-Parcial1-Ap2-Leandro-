<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta de Presupuesto.aspx.cs" Inherits="_Parcial1_Ap2_Leandro_.UI.Consultas.Consulta_de_Prestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Inclusion de bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../Css/MyStyle.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consulta de Prestamos</title>
</head>
<body>
    <form id="form1" runat="server">



        <header>
            <!--menu principal-->
            <nav class=" navbar navbar-default">

                <div class="container-fluid">

                    <ul class="nav navbar-nav">
                        <li><a href="../Registros/Menu.aspx"><span class="glyphicon glyphicon-home">Inicio&nbsp</span></a></li>
                        <li><a href="../Registros/Registro Presupuesto.aspx"><span class="glyphicon glyphicon-usd">Registro de Prestamos&nbsp</span></a></li>
                        <li class="active"><a href="Consulta de Presupuesto.aspx"><span class="glyphicon glyphicon-search">Consulta de Prestamos</span></a></li>
                        <li><a href="../Registros/Categorias.aspx"><span class="glyphicon glyphicon-usd">Registro de Categorias&nbsp</span></a></li>
                        <li ><a href="ConsultaCategoria.aspx"><span class="glyphicon glyphicon-search">Consulta de Categorias</span></a></li>

                        &nbsp&nbsp&nbsp

                   <ul />
                </div>

            </nav>
            <h1 class="text-center page-header">Consulta de Presupuestos<span class="glyphicon glyphicon-usd"></span></h1>



        </header>

        <div class="container-fluid">
            <div class="col-lg-12 col-md-6  col-sm-8 col-xs-12">

                <!--comboBox con diferentes opciones a seleccionar-->
                <div class="text-center">
                    <label for="Busqueda:">Busqueda</label>

                    <asp:DropDownList ID="DropDownListPresupuesto" runat="server" AutoPostBack="True" Width="110px" Height="22px">
                        <asp:ListItem>Id</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        <asp:ListItem>Todos</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp

                    <!--boton buscar-->
                    <asp:TextBox ID="TextBox1" runat="server" Width="150px" MaxLength="50"></asp:TextBox>
                    <asp:Button ID="ButtonBuscar" CssClass="boton-buscar" runat="server" Text="Filtrar" OnClick="ButtonBuscar_Click" />

                </div>

                <!--fecha-->
                <div class="text-center">
                    <p>
                        <label for="Desde:">Desde </label>
                        &nbsp;<asp:TextBox ID="desdeFecha" runat="server" Width="120px" MaxLength="15"></asp:TextBox>
                        <label for="hasta">Hasta</label>
                        <asp:TextBox ID="hastaFecha" runat="server" Width="120px" MaxLength="15"></asp:TextBox>
                        <!--boton Imprimir Reporte-->
                        <a id="Reporte" href="../Reportes/Reporte Presupuesto.aspx" class="boton-buscar">Imprimir</a>

                    </p>

                </div>

            </div>
        </div>



        <br />
        <br />
        <br />
        <!--tabla donde se va mostrar el contenido filtrado-->
        <div class="text-center">
            <asp:GridView ID="GridView1" CssClass="text-center" runat="server" CaptionAlign="Bottom" HorizontalAlign="Center" Height="18px" Width="510px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" BorderColor="Black" BorderStyle="Double" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" BorderColor="White" BorderStyle="Double" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderStyle="Double" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>


        <br />
        <br />
        <br />
        <br />

        <!--footer-->
        <footer>

            <p class="page-footer text-center " >[Parcial 1 Aplicada 2 Leandro Rafael]</p>

        </footer>

    </form>
</body>
</html>
