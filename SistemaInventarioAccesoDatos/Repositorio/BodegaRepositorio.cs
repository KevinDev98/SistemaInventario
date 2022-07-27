using SistemaInventario.Modelos.ViewModels.EntidadesDB;
using SistemaInventarioAccesoDatos.Data;
using SistemaInventarioAccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaInventarioAccesoDatos.Repositorio
{
    public class BodegaRepositorio: Repositorio<Bodega>, IBodegaRepositorio
    {
        private readonly DbContextConnect _db;
        public BodegaRepositorio(DbContextConnect db) :base(db)
        {
            _db = db;
        }

        public void Actualizar(Bodega bodega)
        {
            //throw new NotImplementedException();
            var bodegaDb = _db.Bodega.FirstOrDefault(b => b.IdBodega == bodega.IdBodega);
            if (bodegaDb !=null)
            {
                bodegaDb.NombreB = bodega.NombreB;
                bodegaDb.DescripcionB = bodega.DescripcionB;
                bodegaDb.Estado = bodega.Estado;
                _db.SaveChanges();
            }
        }
    }
}
