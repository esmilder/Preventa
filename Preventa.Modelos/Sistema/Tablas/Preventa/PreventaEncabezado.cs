using Preventa.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Preventa
{
    [Table("PreventaEncabezado", Schema = "Preventa")]
    public class PreventaEncabezado : EntidadBase
    {
        [Column("Serial")]
        public int? Serial { get; set; }
        [Column("Fecha")]
        public DateTime Fecha { get; set; }
        [Column("Contado")]
        public bool Contado { get; set; }
        [Column("IdCliente")]
        public int IdCliente { get; set; }
        [Column("Observacion")]
        [StringLength(250)]
        public string Observacion { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }



        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<PreventaDetalle> PreventaDetalle { get; set; }
    }
}
