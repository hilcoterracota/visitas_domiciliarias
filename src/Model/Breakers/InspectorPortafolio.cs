using Sivido.Model.Catalog;
using Sivido.Model.Core;
using Sivido.Model.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Beakers
{
    [Table("BRE_INSPECTOR_PORTAFORLIO")]
    public class InspectorPortafolio : DefaultBreak
    {
        [Key]
        public string IdInspector { get; set; }
        [Key]
        public string Idportafolio { get; set; }
        public virtual Inspector Inspector { get; set; }
        public virtual Portafolio Portafolio { get; set; }
    }
}
