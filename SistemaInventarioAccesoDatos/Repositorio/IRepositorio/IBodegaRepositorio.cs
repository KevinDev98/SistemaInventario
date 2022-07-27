using SistemaInventario.Modelos.ViewModels.EntidadesDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioAccesoDatos.Repositorio.IRepositorio
{
    public interface IBodegaRepositorio : IRepositorio<Bodega>
    {
        void Actualizar(Bodega bodega);
    }
}
