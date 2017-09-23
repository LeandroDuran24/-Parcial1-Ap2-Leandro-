using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Leandro_.UI.Reportes
{
    public partial class Reporte_Prestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            ReportViewer1.Reset();
            ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Presupuesto.rdlc");
            ReportViewer1.LocalReport.DataSources.Clear();

            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetPresupuesto",
               Consultas.Consulta_de_Prestamos.lista));

            ReportViewer1.LocalReport.Refresh();
        }
    }
}