using Sivido.Model.Catalog;
using Sivido.Model.Core;
using Sivido.Model.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Beakers
{
    [Table("BRE_VISITA_RESPUESTA")]
    public class VisitaRespuesta : DefaultBreak
    {
        [Key]
        public string IdVisita { get; set; }
        [Key]
        public string IdFormulario { get; set; }
        [Required]
        [MaxLength(500)]
        public string Respuesta { get; set; }
        [MaxLength(200)]
        public string Observaciones { get; set; }

        public virtual Visita Visita { get; set; }
        public virtual Formulario Formulario { get; set; }

    }
}
