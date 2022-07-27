using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaInventario.Modelos.ViewModels.EntidadesDB
{
    [Table("BODEGA")]
    public class Bodega
    {
        public Bodega()
        {
            BodegaProd = new HashSet<BodegaProd>();
        }

        [Key]
        [Column("ID_BODEGA")]
        public int IdBodega { get; set; }
        [Required]
        [Column("NOMBRE_B")]
        [StringLength(100)]
        public string NombreB { get; set; }
        [Required]
        [Column("DESCRIPCION_B")]
        [StringLength(1000)]
        public string DescripcionB { get; set; }
        [Required]
        [Column("ESTADO")]
        [StringLength(50)]
        public string Estado { get; set; }

        [InverseProperty("FidProdNavigation")]
        public virtual ICollection<BodegaProd> BodegaProd { get; set; }
    }
}
