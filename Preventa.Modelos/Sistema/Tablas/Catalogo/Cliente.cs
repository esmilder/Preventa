using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Preventa.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Cliente", Schema = "Catalogo")]
    public class Cliente : EntidadBase
    {
        [Required(ErrorMessage ="Se requiere nombre del Cliente")]
        [StringLength(150)]
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requiere cédula del Cliente")]
        [Column("Cedula")]
        [StringLength(50)]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Se requiere dirección del Cliente")]
        [Column("Direccion")]
        [StringLength(250)]
        public string Direccion { get; set; }

        [Column("Correo")]
        [StringLength(25)]
        public string Correo { get; set; }
        [Column("Observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }


        public virtual ICollection<ClienteContacto> ClienteContacto { get; set; }
    }
}
