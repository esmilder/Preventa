using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Categoria",Schema = "Catalogo")]
    public class Categoria:EntidadBase
    {
        [StringLength(150)]
        [Column("Descripcion")]
        public string  Descripcion { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
