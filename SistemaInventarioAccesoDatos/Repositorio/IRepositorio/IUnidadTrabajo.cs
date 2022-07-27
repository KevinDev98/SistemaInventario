using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioAccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        IBodegaRepositorio Bodega { get; }
    }
}
