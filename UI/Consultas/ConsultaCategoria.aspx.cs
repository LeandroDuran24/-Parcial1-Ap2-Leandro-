using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Leandro_.UI.Consultas
{
    public partial class ConsultaCategoria : System.Web.UI.Page
    {
        public static List<Categoria> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();

            lista = BLL.CategoriaBLL.GetListTodo();
            GridView1.DataSource = BLL.CategoriaBLL.GetListTodo();
            GridView1.DataBind();
        }

        public void SeleccionarItem()
        {
            if (DropDownListCategoria.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                lista = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);

            }

            
            else if (DropDownListCategoria.SelectedIndex == 2)
            {

                lista = BLL.CategoriaBLL.GetListTodo();
                GridView1.DataSource = lista;
                GridView1.DataBind();

            }
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }


        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            SeleccionarItem();
        }
    }
}