using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Catalogo
{
    [Table("ClienteContacto", Schema = "Catalogo")]
    public class ClienteContacto : EntidadBase
    {
        [Column("IdCliente")]
        public int IdCliente { get; set; }
        [StringLength(50)]
        [Column("Celular")]
        public string Celular { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }



        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }
    }
}
