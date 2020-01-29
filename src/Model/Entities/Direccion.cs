using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Entities
{
    [Table("T_DIRECCION")]
    public class Direccion : Default
    {
        [Required]
        public string Calle { get; set; }
        [Required]
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        [Required]
        public string CP { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public string pais { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
