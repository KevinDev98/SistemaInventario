using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaInventario.Modelos.ViewModels.EntidadesDB
{
    [Table("MARCA")]
    public partial class Marca
    {
        public Marca()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        [Column("ID_MARCA")]
        public int IdMarca { get; set; }
        [Required]
        [Column("NOMBRE_M")]
        [StringLength(100)]
        public string NombreM { get; set; }
        [Column("ESTADO_M")]
        public int EstadoM { get; set; }

        [InverseProperty("FidMarcaNavigation")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
