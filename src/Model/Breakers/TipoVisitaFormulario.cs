using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Core;
using Sivido.Model.Entities;

namespace Sivido.Model.Catalog
{
    [Table("BRE_TIPO_VISITA_FORMULARIO")]
    public class TipoVisitaFormulario : Default
    {
        public string IdTipoVisita { get; set; }
        public string IdFormulartio { get; set; }
        public virtual TipoVisitaFormulario TipoVisita { get; set; }
        public virtual Formulario Formulario { get; set; }
    }
}
