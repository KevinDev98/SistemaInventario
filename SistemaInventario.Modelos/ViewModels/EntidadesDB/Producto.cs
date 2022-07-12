using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaInventario.Modelos.ViewModels.EntidadesDB
{
    [Table("PRODUCTO")]
    public partial class Producto
    {
        [Key]
        [Column("ID_PROD")]
        public int IdProd { get; set; }
        [Required]
        [Column("NUM_SERIE")]
        [StringLength(100)]
        public string NumSerie { get; set; }
        [Required]
        [Column("DESCRIPCION_P")]
        [StringLength(1000)]
        public string DescripcionP { get; set; }
        [Column("FID_CATEGORIA")]
        public int? FidCategoria { get; set; }
        [Column("FID_MARCA")]
        public int? FidMarca { get; set; }
        [Column("TIPO")]
        public int Tipo { get; set; }
        [Column("PROD_PADRE")]
        public int? ProdPadre { get; set; }
        [Column("COSTO")]
        public double Costo { get; set; }
        [Column("PRECIO")]
        public double Precio { get; set; }

        [ForeignKey(nameof(FidCategoria))]
        [InverseProperty(nameof(Categoria.Producto))]
        public virtual Categoria FidCategoriaNavigation { get; set; }
        [ForeignKey(nameof(FidMarca))]
        [InverseProperty(nameof(Marca.Producto))]
        public virtual Marca FidMarcaNavigation { get; set; }
    }
}
