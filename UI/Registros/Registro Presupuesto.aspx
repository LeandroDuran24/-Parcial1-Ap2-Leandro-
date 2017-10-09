<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro Presupuesto.aspx.cs" Inherits="_Parcial1_Ap2_Leandro_.UI.Registros.Registro_Prestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!--inclusion de BootsTrap y la hoja de estilos-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" href="../CSS/MyStyle.css" />


    <title>Registro de Prestamos</title>


</head>
<body>
    <form id="form1" runat="server">

        <header>
            <!--menu principal-->
            <nav class=" navbar navbar-default">

                <div class="container-fluid">

                    <ul class="nav navbar-nav">
                        <li><a href="Menu.aspx"><span class="glyphicon glyphicon-home">Inicio&nbsp</span></a></li>
                        <li class="active"><a href="Registro Presupuesto.aspx"><span class="glyphicon glyphicon-usd">Registro de Prestamos&nbsp</span></a></li>
                        <li><a href="../Consultas/Consulta de Presupuesto.aspx"><span class="glyphicon glyphicon-search">Consulta de Prestamos</span></a></li>
                         <li><a href="Categorias.aspx"><span class="glyphicon glyphicon-usd">Registro de Categoria&nbsp</span></a></li>
                        <li><a href="../Consultas/ConsultaCategoria.aspx"<span class="glyphicon glyphicon-search">Consulta de Categorias</span></a></li>
                        &nbsp&nbsp&nbsp

                   <ul />
                </div>

            </nav>
            <h1 class="text-center page-header">Registro de Prestamos<span class="glyphicon glyphicon-usd"></span></h1>

        </header>

        <div class="container-fluid">

            <!--Id del prestamo-->
            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label1" runat="server" Text="Id Prestamo"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="IdTextBox" runat="server" Height="27px" Width="89px" MaxLength="10"></asp:TextBox>&nbsp
                <asp:Button ID="BuscarButton" CssClass="boton-buscar" runat="server" Text="Buscar" ValidationGroup="buscar" OnClick="BuscarButton_Click" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="IdTextBox" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="buscar"></asp:RequiredFieldValidator>
            </div>

            <!--Fecha del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label2" runat="server" Text="Fecha" ValidationGroup="guardar"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="FechaTextBox1" runat="server" Height="27px" Width="200px" MaxLength="20"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FechaTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>


            <!--descripcion del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="DescripcionTextBox1" runat="server" Height="66px" Width="200px" TextMode="MultiLine" MaxLength="150"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DescripcionTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>

            <!-----------------Categoria----------------------->
            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label5" runat="server" Text="Categoria"></asp:Label>

                </div>

            </div>

            <div class="text-center">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="200px"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>

            <!--Monto del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label4" runat="server" Text="Monto"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="MontoTextBox1" runat="server" Height="27px" Width="200px" MaxLength="15"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="MontoTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>
            <!--validar solo numero en el textbox del monto-->
            <p class=" text-center">

                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="\d+" ValidationGroup="guardar" runat="server" ErrorMessage="Solo Numeros #" ControlToValidate="MontoTextBox1" Font-Bold="True" ForeColor="Red"></asp:RegularExpressionValidator>
                <br />
            </p>

            <!--Botones Guardar,Nuevo y ELiminar-->
            <div class="text-center">
                <asp:Button ID="NuevoButton2" CssClass="btn btn-primary btn-md boton" runat="server" Text="Nuevo" OnClick="NuevoButton2_Click" />&nbsp&nbsp
                   <asp:Button ID="GuardarButton" CssClass="btn btn-primary btn-md boton" runat="server" Text="Guardar" ValidationGroup="guardar" OnClick="GuardarButton_Click" />
                &nbsp&nbsp
                    <asp:Button ID="Eliminar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Eliminar" OnClick="Eliminar_Click" />
            </div>
            <br />
            <br />
            <br />
            <br />
            <!--footer-->
            <footer>
                <p class="page-footer text-center">[Parcial 1 Aplicada 2 Leandro Rafael]</p>
            </footer>

        </div>


    </form>
</body>
</html>
