<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reporte Presupuesto.aspx.cs" Inherits="_Parcial1_Ap2_Leandro_.UI.Reportes.Reporte_Prestamos" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reporte de Presupuesto</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Remote" AsyncRendering="False" Height="524px" Width="1006px">
<ServerReport ReportPath="" ReportServerUrl="" />
</rsweb:ReportViewer>


    </form>
</body>
</html>
