using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Beakers;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_INSPECTOR")]
    public class Inspector : Default
    {
        [Required]
        [MaxLength(30)]
        public string Usuario { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<InspectorPortafolio> InspectorPortafolios { get; set; }

    }
}
