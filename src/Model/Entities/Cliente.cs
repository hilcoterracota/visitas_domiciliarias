using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_CLIENTE")]
    public class Cliente : Default
    {
        [Required]
        [MaxLength(100)]
        public string RasonSocial { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }

        private readonly SividoDataContext context;

    }
}