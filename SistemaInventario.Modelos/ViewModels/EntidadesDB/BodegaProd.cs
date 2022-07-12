using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaInventario.Modelos.ViewModels.EntidadesDB
{
    [Table("BODEGA_PROD")]
    public partial class BodegaProd
    {
        [Key]
        [Column("ID_BP")]
        public int IdBp { get; set; }
        [Required]
        [Column("UBICACION")]
        [StringLength(250)]
        public string Ubicacion { get; set; }
        [Column("CANTIDAD")]
        public int Cantidad { get; set; }
        [Column("FID_BODEGA")]
        public int? FidBodega { get; set; }
        [Column("FID_PROD")]
        public int? FidProd { get; set; }

        [ForeignKey(nameof(FidBodega))]
        [InverseProperty(nameof(Categoria.BodegaProd))]
        public virtual Categoria FidBodegaNavigation { get; set; }
        [ForeignKey(nameof(FidProd))]
        [InverseProperty(nameof(Bodega.BodegaProd))]
        public virtual Bodega FidProdNavigation { get; set; }
    }
}
