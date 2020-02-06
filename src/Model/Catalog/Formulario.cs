using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Beakers;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Catalog
{
    [Table("CAT_FORMULARIO")]
    public class Formulario : Default
    {
        [Required]
        public string IdTipoFormulario { get; set; }
        [Required]
        [MaxLength(200)]
        public string Pregunta { get; set; }
        public virtual TipoFormulario tipoFormulario { get; set; }
        public virtual ICollection<VisitaRespuesta> VisitaRespuestas { get; set; }
        public virtual ICollection<TipoVisitaFormulario> TipoVisitaFormularios { get; set; }
        public virtual ICollection<FormularioOpcion> FormularioOpciones { get; set; }

        
    }
}
