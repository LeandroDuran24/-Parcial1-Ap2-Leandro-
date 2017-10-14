﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaCategoria.aspx.cs" Inherits="_Parcial1_Ap2_Leandro_.UI.Consultas.ConsultaCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Inclusion de bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../Css/MyStyle.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title>Consulta de Categorias</title>
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
                        <li><a href="Consulta de Presupuesto.aspx"><span class="glyphicon glyphicon-search">Consulta de Prestamos</span></a></li>
                        <li><a href="../Registros/Categorias.aspx"><span class="glyphicon glyphicon-usd">Registro de Categorias&nbsp</span></a></li>
                        <li class="active"><a href="ConsultaCategoria.aspx"><span class="glyphicon glyphicon-search">Consulta de Categorias</span></a></li>

                        &nbsp&nbsp&nbsp

                   <ul />
                </div>

            </nav>
            <h1 class="text-center page-header">Consulta de Categorias<span class="glyphicon glyphicon-usd"></span></h1>



        </header>


        <div class="container-fluid">
            <div class="col-lg-12 col-md-6  col-sm-8 col-xs-12">

                <!--comboBox con diferentes opciones a seleccionar-->
                <div class="text-center">
                    <label for="Busqueda:">Busqueda</label>

                    <asp:DropDownList ID="DropDownListCategoria" runat="server" AutoPostBack="True" Width="110px" Height="22px">
                        <asp:ListItem>Id</asp:ListItem>
                        <asp:ListItem>Todos</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp

                    <!--boton buscar-->
                    <asp:TextBox ID="TextBox1" runat="server" Width="150px" MaxLength="50" ValidationGroup="buscar"></asp:TextBox>
                    <asp:Button ID="ButtonBuscar" CssClass="boton-buscar" runat="server" Text="Filtrar" OnClick="ButtonBuscar_Click" />

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" Font-Bold="True" Font-Size="15pt" ForeColor="Red" ValidationGroup="buscar" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>

                </div>



            </div>
        </div>



        <br />
        <br />
        <br />
        <!--tabla donde se va mostrar el contenido filtrado-->
        <div class=" align-content-center text-center">
            <div style="overflow: auto; width: 800px; height: 315px;">
                <asp:GridView ID="GridView1" CssClass="text-center" runat="server" CaptionAlign="Bottom" HorizontalAlign="Center" Height="1px" Width="758px" CellPadding="0" ForeColor="#333333" GridLines="None" PageIndex="2" PageSize="2">
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
        </div>


        <br />
        <br />
        <br />
        <br />

        <!--footer-->
        <footer>

            <p class="page-footer text-center ">[Parcial 1 Aplicada 2 Leandro Rafael]</p>

        </footer>



    </form>
</body>
</html>
