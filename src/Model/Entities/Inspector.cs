using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Entities
{
    [Table("T_INSPECTOR")]
    public class Inspector : Default
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
