using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Entities
{
    [Table("T_CLIENTE")]
    public class Cliente : Default
    {

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}