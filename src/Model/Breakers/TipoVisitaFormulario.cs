using Sivido.Model.Catalog;
using Sivido.Model.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Beakers
{
    [Table("BRE_TIPO_VISITA_FORMULARIO")]
    public class TipoVisitaFormulario : DefaultBreak
    {
        [Key]
        public string IdTipoVisita { get; set; }
        [Key]
        public string IdFormulario { get; set; }
        public int Order { get; set; }
        public virtual TipoVisita TipoVisita { get; set; }
        public virtual Formulario Formulario { get; set; }
    }
}
