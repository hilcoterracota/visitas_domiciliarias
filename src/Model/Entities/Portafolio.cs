using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Entities
{
    [Table("T_PORTAFOLIO")]
    public class Portafolio : Default
    {
        [Required]
        [MaxLength(100)]
        public string RasonSocial { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
