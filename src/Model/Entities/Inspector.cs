using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Catalog;
using Sivido.Model.Core;

namespace Sivido.Model.Entities
{
    [Table("T_INSPECTOR")]
    public class Inspector: Default
    {
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
