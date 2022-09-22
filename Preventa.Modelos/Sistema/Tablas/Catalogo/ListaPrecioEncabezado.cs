using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Catalogo
{
    [Table("ListaPrecioEncabezado", Schema = "Catalogo")]
    public class ListaPrecioEncabezado:EntidadBase
    {
        [StringLength(50)]
        [Column("Lista")]
        public string Lista { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }
        public virtual ICollection<ListaPrecioDetalle> ListaPrecioDetalle { get; set; }
    }
}
