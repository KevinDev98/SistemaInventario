using SistemaInventarioAccesoDatos.Data;
using SistemaInventarioAccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioAccesoDatos.Repositorio
{
    public class UnidadTrabajo :IUnidadTrabajo
    {
        private readonly DbContextConnect _db;
        public IBodegaRepositorio Bodega { get; private set; }
        public UnidadTrabajo( DbContextConnect db)
        {
            _db = db;
            Bodega = new BodegaRepositorio(_db);//Inicializando
        }
        public void Guardar()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
