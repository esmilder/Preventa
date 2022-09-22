using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas
{
    public class EntidadBase
    {
        [Key]
        [Column("Id")]
        public virtual int Id { get; set; }
        [StringLength(50)]
        [Column("RegistroUsuario")]
        public virtual string RegistroUsuario { get; set; }
        [Column("RegistroFecha")]
        public virtual DateTime RegistroFecha { get; set; }
    }
}
