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

            llenarCombo();
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }

        //funcion para limpiar todos los textbox del formulario
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
            DropDownList1.Text = "";
            FechaTextBox1.Focus();


        }

        //funcion para crear una instancia con los campos de los textbox 

        public Presupuesto LLenar()
        {
            presupuesto.PresupuestoId = Utilidades.TOINT(IdTextBox.Text);
            presupuesto.Descripcion = DescripcionTextBox1.Text;
            presupuesto.Fecha = Convert.ToDateTime(FechaTextBox1.Text);
            presupuesto.Monto = Convert.ToDouble(MontoTextBox1.Text);
            presupuesto.CategoriaId =Utilidades.TOINT(DropDownList1.SelectedValue.ToString());
            return presupuesto;
        }

        public void llenarCombo()
        {
            List<Categoria> lista = BLL.CategoriaBLL.GetListTodo();
            DropDownList1.DataSource = lista;
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataValueField = "CategoriaId";
            DropDownList1.DataBind();

          
           
        }


        protected void NuevoButton2_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                presupuesto = LLenar();
                if (presupuesto.PresupuestoId != 0)
                {

                    BLL.PresupuestoBLL.Mofidicar(presupuesto);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Modificado !');</script> ");
                }
                else
                {

                    BLL.PresupuestoBLL.Guardar(presupuesto);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardado !');</script> ");
                    LimpiarTextBox();


                }
            }
           
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            presupuesto = BLL.PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
            if(IsValid)

            {
                if (presupuesto != null)
                {
                    FechaTextBox1.Text = Convert.ToString(presupuesto.Fecha);
                    DescripcionTextBox1.Text = presupuesto.Descripcion;
                    MontoTextBox1.Text = Convert.ToString(presupuesto.Monto);
                    DropDownList1.Text = Convert.ToString(presupuesto.CategoriaId);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe!');</script> ");
                    LimpiarTextBox();
                }
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
                LimpiarTextBox();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe!');</script> ");
                LimpiarTextBox();
            }
        }
    }
}