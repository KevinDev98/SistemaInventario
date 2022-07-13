using Microsoft.EntityFrameworkCore;
using SistemaInventarioAccesoDatos.Data;
using SistemaInventarioAccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaInventarioAccesoDatos.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly DbContextConnect _db;
        internal DbSet<T> dbSet;
        public Repositorio(DbContextConnect db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Agregar(T entidad)
        {
            dbSet.Add(entidad);
        }

        public T Obtener(int id)
        {
            return dbSet.Find(id);
        }

        public T ObtenerFoD(Expression<Func<T, bool>> filter = null, string incluirPropiedades = null)
        {
            IQueryable<T> Query = dbSet;
            if (filter != null)
            {
                Query = Query.Where(filter);
            }
            if (incluirPropiedades != null)
            {
                foreach (var includeProperties in incluirPropiedades.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Query = Query.Include(includeProperties);
                }
            }
            return Query.FirstOrDefault();
        }

        public IEnumerable<T> ObtenerTodos(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> Orderby = null, string incluirPropiedades = null)
        {
            IQueryable<T> Query = dbSet;
            if (filter!=null)
            {
                Query = Query.Where(filter);
            }
            if (incluirPropiedades !=null)
            {
                foreach (var includeProperties in incluirPropiedades.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Query = Query.Include(includeProperties);
                }
            }
            if (Orderby!=null)
            {
                return Orderby(Query).ToList();
            }
            return Query.ToList();
        }
        public void Remover(int id)
        {
            T Entidad = dbSet.Find(id);
            Remover(Entidad);
        }

        public void Remover(T Entidad)
        {
            dbSet.Remove(Entidad);
        }

        public void RemoverRango(IEnumerable<T> Entidad)
        {
            dbSet.RemoveRange(Entidad);
        }
    }
}
