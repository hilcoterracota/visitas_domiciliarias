using Sivido.Model.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Catalog
{
    [Table("BRE_TIPO_VISITA_FORMULARIO")]
    public class TipoVisitaFormulario : DefaultBreak
    {
        [Key]
        public string IdTipoVisita { get; set; }
        [Key]
        public string IdFormulartio { get; set; }
        public virtual TipoVisitaFormulario TipoVisita { get; set; }
        public virtual Formulario Formulario { get; set; }
    }
}
