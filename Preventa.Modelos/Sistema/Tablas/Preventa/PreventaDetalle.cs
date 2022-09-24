using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Preventa
{
    [Table("PreventaDetalle", Schema = "Preventa")]
    public class PreventaDetalle : EntidadBase
    {
        [ForeignKey("IdPreventa")]
        public int IdPreventa { get; set; }
        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }
        [ForeignKey("Cantidad")]
        public int Cantidad { get; set; }
        [ForeignKey("Precio")]
        public decimal Precio { get; set; }
        [Column("IvaPorcentaje")]
        public int IvaPorcentaje { get; set; }
        [Column("DescuentoPorcentaje")]
        public int DescuentoPorcentaje { get; set; }

        
        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

        [ForeignKey("IdPreventa")]
        public virtual PreventaEncabezado PreventaEncabezado { get; set; }


    }
}
