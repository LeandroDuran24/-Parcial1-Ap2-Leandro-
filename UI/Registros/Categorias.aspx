<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="_Parcial1_Ap2_Leandro_.UI.Registros.Categorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

     <!--inclusion de BootsTrap y la hoja de estilos-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" href="../CSS/MyStyle.css" />




    <title>Registro Categorias</title>
</head>
<body>

    <form id="form1" runat="server">

        <header>
            <!--menu principal-->
            <nav class=" navbar navbar-default">

                <div class="container-fluid">

                    <ul class="nav navbar-nav">
                        <li><a href="Menu.aspx"><span class="glyphicon glyphicon-home">Inicio&nbsp</span></a></li>
                        <li ><a href="Registro Presupuesto.aspx"><span class="glyphicon glyphicon-usd">Registro de Prestamos&nbsp</span></a></li>
                        <li><a href="../Consultas/Consulta de Presupuesto.aspx"><span class="glyphicon glyphicon-search">Consulta de Prestamos</span></a></li>
                         <li class="active"><a href="Categorias.aspx"><span class="glyphicon glyphicon-usd">Registro de Categoria&nbsp</span></a></li>
                        <li><a href="../Consultas/ConsultaCategoria.aspx"<span class="glyphicon glyphicon-search">Consulta de Categorias</span></a></li>
                        &nbsp&nbsp&nbsp

                  

                        <ul />
                </div>

            </nav>
            <h1 class="text-center page-header">Registro de Categorias<span class="glyphicon glyphicon-usd"></span></h1>

        </header>

        <div class="container-fluid">

            <!--Id de categoria-->
            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label1" runat="server" Text="Id Categoria"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="IdTextBox" runat="server" Height="27px" Width="89px" MaxLength="10"></asp:TextBox>&nbsp
               
                <asp:Button ID="BuscarButton" CssClass="boton-buscar" runat="server" Text="Buscar" ValidationGroup="buscar" OnClick="BuscarButton_Click"  />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="IdTextBox" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="buscar"></asp:RequiredFieldValidator>
            </div>

           

            <!--descripcion del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label3" runat="server" Text="Categoria"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="CaracteristicaTextBox1" runat="server" Height="66px" Width="200px" TextMode="MultiLine" MaxLength="150"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="CaracteristicaTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>

          
            <!--Botones Guardar,Nuevo y ELiminar-->
            <div class="text-center">
                <asp:Button ID="NuevoButton2" CssClass="btn btn-primary btn-md boton" runat="server" Text="Nuevo" OnClick="NuevoButton2_Click"  />&nbsp&nbsp
                  
                <asp:Button ID="GuardarButton" CssClass="btn btn-primary btn-md boton" runat="server" Text="Guardar" ValidationGroup="guardar" OnClick="GuardarButton_Click"  />
                &nbsp&nbsp
                   
                <asp:Button ID="Eliminar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Eliminar" OnClick="Eliminar_Click"  />
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
