using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
   public class PresupuestoBLL
    {
        public static Presupuesto Guardar(Presupuesto nuevo)
        {
            Presupuesto retorno = null;
            using (var conn = new DAL.Repositorio<Presupuesto>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static Presupuesto Buscar(Expression<Func<Presupuesto, bool>> tipo)
        {
            Presupuesto Result = null;
            using (var repositorio = new DAL.Repositorio<Presupuesto>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }



        public static bool Mofidicar(Presupuesto criterio)
        {
            bool mod = false;
            using (var db = new DAL.Repositorio<Presupuesto>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Presupuesto existente)
        {
            bool eliminado = false;
            using (var repositorio = new DAL.Repositorio<Presupuesto>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static List<Presupuesto> GetList(Expression<Func<Presupuesto, bool>> criterio)
        {
            List<Presupuesto> retorno = null;
            using (var conn = new DAL.Repositorio<Presupuesto>())
            {
                try
                {
                    retorno = conn.GetList(criterio).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }

        public static List<Presupuesto> GetListTodo()
        {
            List<Presupuesto> retorno = null;
            using (var conn = new DAL.Repositorio<Presupuesto>())
            {
                try
                {
                    retorno = conn.GetListTodo().ToList();

                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }

    }
}
