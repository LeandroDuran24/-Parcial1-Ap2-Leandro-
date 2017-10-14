using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            if (!Page.IsPostBack)
            {
                Presupuesto presupuesto = new Presupuesto();
                ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
                myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
                myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
                myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
                myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
                ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            }

        }

        //funcion en donde dependiendo del items que seleccione hace su funcion por el filtro requerido
        public void SeleccionarItem()
        {
            if (DropDownListPresupuesto.SelectedIndex == 0)//id
            {
                if (TextBox1.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Favor Llenar Campo);</script>");
                }
                else
                {
                    int id = Convert.ToInt32(TextBox1.Text);
                    lista = BLL.PresupuestoBLL.GetList(p => p.PresupuestoId == id);
                    GridView1.DataSource = lista;
                    GridView1.DataBind();

                }

            }

            else if (DropDownListPresupuesto.SelectedIndex == 1)//fecha
            {


                if (desdeFecha.Text != "" && hastaFecha.Text != "")
                {
                    DateTime desde = Convert.ToDateTime(desdeFecha.Text);
                    DateTime hasta = Convert.ToDateTime(hastaFecha.Text);
                    if (desde <= hasta)
                    {
                        lista = BLL.PresupuestoBLL.GetList(p => p.Fecha >= desde && p.Fecha <= hasta);
                        GridView1.DataSource = lista;
                        GridView1.DataBind();

                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('La Primera Fecha debe ser Menor a la Segunda Fecha');</script>");
                        desdeFecha.Text = "";
                        hastaFecha.Text = "";

                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Intervalo de Fecha');</script>");
                }

            }
            else if (DropDownListPresupuesto.SelectedIndex == 2)//todo
            {


                lista = BLL.PresupuestoBLL.GetListTodo();

                GridView1.DataSource = lista;
                GridView1.DataBind();

            }
            else if (DropDownListPresupuesto.SelectedIndex == 3)//seleccionar por categoria de presupuesto y agruparlo
            {
                if (TextBox1.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Favor Llenar Campo);</script>");
                }
                else
                {


                    int id = Convert.ToInt32(TextBox1.Text);
                    Presupuesto busqueda = new Presupuesto();
                    Button1.Enabled = false;


                    busqueda = BLL.PresupuestoBLL.Buscar(x => x.CategoriaId == id);


                    if (busqueda != null)
                    {

                        SqlConnection conexion = new SqlConnection();
                        conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\Leandro UCNE\Aplicada 2\Parcial1-AP2-Leandro\[Parcial1-Ap2-Leandro]\Base de Datos\Parcial1Db.mdf;Integrated Security = True; Connect Timeout = 30";

                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexion;

                        comando.CommandText = "select pres.CategoriaId,cat.Nombre,Sum(pres.Monto)as Monto from presupuestoes pres inner join Categorias cat on cat.CategoriaId = pres.CategoriaId where pres.CategoriaId=" + Utilidades.TOINT(TextBox1.Text) + "group by pres.CategoriaId,cat.Nombre";

                        DataTable tabla = new DataTable();
                        SqlDataAdapter sql = new SqlDataAdapter(comando);

                        sql.Fill(tabla);

                        GridView1.DataSource = tabla;
                        GridView1.DataBind();

                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Categoria');</script>");
                    }
                }
            }


        }

        //Boton buscar que llama la funcion de Seleccionar Items del comboBox
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            SeleccionarItem();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/Reporte Presupuesto.aspx");
        }
    }
}