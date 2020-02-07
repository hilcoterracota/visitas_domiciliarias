using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("CAT_STATUS")]
    public class Status : Default
    {
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(10)]
        public string Clave { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
