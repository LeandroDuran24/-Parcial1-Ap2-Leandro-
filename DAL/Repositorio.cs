using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Parcial1Db context = null;

        public Repositorio()
        {
            context = new Parcial1Db();
        }

        private DbSet<TEntity>EntitySet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> criterio)
        {
            TEntity result = null;
            try
            {

                result = EntitySet.FirstOrDefault(criterio);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public void Dispose()
        {
            if(context!=null)
            {
                context.Dispose();
            }
        }

        public bool Eliminar(TEntity criterio)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(criterio);
                EntitySet.Remove(criterio);
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterio)
        {
            try
            {
                return EntitySet.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntity Guardar(TEntity nuevo)
        {
            TEntity retorno = null;
            try
            {
                EntitySet.Add(nuevo);
                context.SaveChanges();
                retorno = nuevo;

            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public bool Modificar(TEntity criterio)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(criterio);
                context.Entry(criterio).State = EntityState.Modified;
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
