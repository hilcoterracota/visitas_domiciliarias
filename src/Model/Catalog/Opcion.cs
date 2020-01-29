using Sivido.Model.Beakers;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Catalog
{
    [Table("CAT_OPCION")]
    public class Opcion : Default
    {
        [Required]
        public string Value { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<FormularioOpcion> FormularioOpciones { get; set; }
    }
}
