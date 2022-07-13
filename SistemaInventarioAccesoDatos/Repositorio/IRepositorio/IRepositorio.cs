﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaInventarioAccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        T Obtener(int id);
        IEnumerable<T> ObtenerTodos(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> Orderby = null,
            string incluirPropiedades = null
            );
        T ObtenerFoD(
            Expression<Func<T, bool>> filter = null,
            string incluirPropiedades = null
            );
        void Agregar(T entidad);
        void Remover(int id);
        void Remover(T Entidad);
        void RemoverRango(IEnumerable<T> Entidad);
    }
}
