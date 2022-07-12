using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaInventario.Modelos.ViewModels.EntidadesDB
{
    [Table("CATEGORIA")]
    public partial class Categoria
    {
        public Categoria()
        {
            BodegaProd = new HashSet<BodegaProd>();
            Producto = new HashSet<Producto>();
        }

        [Key]
        [Column("ID_CATEGORIA")]
        public int IdCategoria { get; set; }
        [Required]
        [Column("NOMBRE_C")]
        [StringLength(100)]
        public string NombreC { get; set; }
        [Column("ESTADO_C")]
        public int EstadoC { get; set; }

        [InverseProperty("FidBodegaNavigation")]
        public virtual ICollection<BodegaProd> BodegaProd { get; set; }
        [InverseProperty("FidCategoriaNavigation")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
