using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Beakers;
using Sivido.Model.Core;

namespace Sivido.Model.Catalog
{
    [Table("CAT_OPCION")]
    public class Opcion: Default
    {
        public string Value { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<FormularioOpcion> FormularioOpciones { get; set; }
    }
}
