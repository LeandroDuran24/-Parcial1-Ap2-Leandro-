using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBLL
    {

        public static Categoria Guardar(Categoria nuevo)
        {
            Categoria retorno = null;
            using (var conn = new DAL.Repositorio<Categoria>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static Categoria Buscar(Expression<Func<Categoria, bool>> tipo)
        {
            Categoria Result = null;
            using (var repositorio = new DAL.Repositorio<Categoria>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }



        public static bool Mofidicar(Categoria criterio)
        {
            bool mod = false;
            using (var db = new DAL.Repositorio<Categoria>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Categoria existente)
        {
            bool eliminado = false;
            using (var repositorio = new DAL.Repositorio<Categoria>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static List<Categoria> GetList(Expression<Func<Categoria, bool>> criterio)
        {
            List<Categoria> retorno = null;
            using (var conn = new DAL.Repositorio<Categoria>())
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

        public static List<Categoria> GetListTodo()
        {
            List<Categoria> retorno = null;
            using (var conn = new DAL.Repositorio<Categoria>())
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
