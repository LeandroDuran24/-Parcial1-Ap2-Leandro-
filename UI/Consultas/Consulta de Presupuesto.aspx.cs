using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Leandro_.UI.Consultas
{
    public partial class Consulta_de_Prestamos : System.Web.UI.Page
    {
        //lista en donde almaceno la informacion que me trae el filtro para pasarla al reporte
        public static List<Presupuesto> lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Presupuesto presupuesto = new Presupuesto();
           
            lista = BLL.PresupuestoBLL.GetListTodo();
            GridView1.DataSource = BLL.PresupuestoBLL.GetListTodo();
            GridView1.DataBind();
        }

        //funcion en donde dependiendo del items que seleccione hace su funcion por el filtro requerido
        public void SeleccionarItem()
        {
            if (DropDownListPresupuesto.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                lista = BLL.PresupuestoBLL.GetList(p => p.PresupuestoId == id);
               
            }

            else if (DropDownListPresupuesto.SelectedIndex == 1)
            {


                if (desdeFecha.Text != "" && hastaFecha.Text != "")
                {
                    DateTime desde = Convert.ToDateTime(desdeFecha.Text);
                    DateTime hasta = Convert.ToDateTime(hastaFecha.Text);
                    if (desde <= hasta)
                    {
                        lista = BLL.PresupuestoBLL.GetList(p => p.Fecha >= desde && p.Fecha <= hasta);
                        
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('La Primera Fecha debe ser Menor a la Segunda Fecha');</script>");
                        desdeFecha.Text = "";
                        hastaFecha.Text = "";
                        GridView1.DataSource = BLL.PresupuestoBLL.GetListTodo();
                        GridView1.DataBind();
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Intervalo de Fecha');</script>");
                }



            }
            else if (DropDownListPresupuesto.SelectedIndex == 2)
            {

                lista = BLL.PresupuestoBLL.GetListTodo();
                GridView1.DataSource = lista;
                GridView1.DataBind();

            }
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }

        //Boton buscar que llama la funcion de Seleccionar Items del comboBox
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            SeleccionarItem();
        }
    }
}