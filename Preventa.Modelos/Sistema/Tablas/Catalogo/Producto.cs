using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Producto", Schema = "Catalogo")]
    public class Producto : EntidadBase
    {
        [StringLength(250)]
        [Column("Descripcion")]
        public string Descripcion { get; set; }
        [Column("IdCategoria")]
        public int IdCategiria { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }
        [Column("Excento")]
        public bool Excento { get; set; }


        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<ListaPrecioDetalle> ListaPrecioDetalle { get; set; }
    }
}
