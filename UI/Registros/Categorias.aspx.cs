using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Leandro_.UI.Registros
{
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }
        Categoria cat = new Categoria();

        public void LimpiarTextBox()
        {
            IdTextBox.Text = "";
            CaracteristicaTextBox1.Text = "";
            CaracteristicaTextBox1.Focus();


        }

        public Categoria LLenar()
        {
           cat.CategoriaId= Utilidades.TOINT(IdTextBox.Text);
            cat.Nombre = CaracteristicaTextBox1.Text;

            return cat;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdTextBox.Text);
            cat = BLL.CategoriaBLL.Buscar(p => p.CategoriaId == id);
            if (IsValid)

            {
                if (cat != null)
                {
                   
                    CaracteristicaTextBox1.Text = cat.Nombre;
                    
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe!');</script> ");
                    LimpiarTextBox();
                }
            }

        }

        protected void NuevoButton2_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                cat = LLenar();
                if (cat.CategoriaId != 0)
                {

                    BLL.CategoriaBLL.Mofidicar(cat);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Modificado !');</script> ");
                }
                else
                {

                    BLL.CategoriaBLL.Guardar(cat);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardado !');</script> ");
                    LimpiarTextBox();


                }
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            cat = BLL.CategoriaBLL.Buscar(p => p.CategoriaId == id);

            if (cat != null)
            {
                BLL.CategoriaBLL.Eliminar(cat);
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