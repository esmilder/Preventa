using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Catalogo
{
    [Table("ListaPrecioEncabezado", Schema = "Catalogo")]
    public class ListaPrecioDetalle:EntidadBase
    {
        [Column("IdLista")]
        public int IdLista { get; set; }
        [Column("IdProducto")]
        public int IdProducto { get; set; }
        [Column("Precio")]
        public decimal Precio { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
        [ForeignKey("IdLista")]
        public virtual ListaPrecioEncabezado ListaPrecioEncabezado { get; set; }
    }
}
