using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Leandro_.UI.Registros
{
    public partial class Registro_Prestamos : System.Web.UI.Page
    {
        Presupuesto presupuesto = new Presupuesto();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox1.Text = string.Format("{0:G}", DateTime.Now);


            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }

        public void LimpiarTextBox()
        {
            IdTextBox.Text = "";
            FechaTextBox1.Text= string.Format("{0:G}", DateTime.Now);
            DescripcionTextBox1.Text = "";
            MontoTextBox1.Text = "";
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            RequiredFieldValidator3.Text = "";
            RequiredFieldValidator4.Text = "";


        }

        public Presupuesto LLenar()
        {
            presupuesto.PresupuestoId = Convert.ToInt32(IdTextBox.Text);
            presupuesto.Descripcion = DescripcionTextBox1.Text;
            presupuesto.Fecha = Convert.ToDateTime(FechaTextBox1.Text);
            presupuesto.Monto = Convert.ToDouble(MontoTextBox1.Text);
            return presupuesto;
        }

        protected void NuevoButton2_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            
            presupuesto = LLenar();
             Convert.ToInt32(IdTextBox.Text);


            if (presupuesto.PresupuestoId!=0)
            {
                
                BLL.PresupuestoBLL.Mofidicar(presupuesto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Modificado !');</script> ");
            }
            else
            {
                BLL.PresupuestoBLL.Guardar(presupuesto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardado !');</script> ");
                LimpiarTextBox();
                FechaTextBox1.Focus();

            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            presupuesto = BLL.PresupuestoBLL.Buscar(p => p.PresupuestoId == id);

            if(presupuesto!=null)
            {
                FechaTextBox1.Text = Convert.ToString(presupuesto.Fecha);
                DescripcionTextBox1.Text = presupuesto.Descripcion;
                MontoTextBox1.Text = Convert.ToString(presupuesto.Monto);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe!');</script> ");
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            presupuesto = BLL.PresupuestoBLL.Buscar(p => p.PresupuestoId == id);

            if(presupuesto !=null)
            {
                BLL.PresupuestoBLL.Eliminar(presupuesto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Eliminado!');</script> ");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe!');</script> ");
            }
        }
    }
}