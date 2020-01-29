using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Core;
using Sivido.Model.Entities;

namespace Sivido.Model.Catalog
{
    [Table("BRE_VISITA_RESPUESTA")]
    public class VisitaRespuesta : DefaultBreak
    {
        [Key]
        public string IdVisita { get; set; }
        [Key]
        public string IdFormulario { get; set; }
        public string Respuesta { get; set; }
        public string Ovservaciones { get; set; }

        public virtual Visita Visita { get; set; }
        public virtual Formulario Formulario { get; set; }

    }
}
