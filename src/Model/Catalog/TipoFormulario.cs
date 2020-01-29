using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Catalog
{
    [Table("CAT_TIPO_FORMULARIO")]
    public class TipoFormulario : Default
    {
        public string Value { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Formulario> Formularios { get; set; }
    }
}
