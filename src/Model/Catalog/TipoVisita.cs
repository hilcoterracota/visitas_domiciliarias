using Sivido.Model.Beakers;
using Sivido.Model.Core;
using Sivido.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Catalog
{
    [Table("CAT_TIPO_VISITA")]
    public class TipoVisita : Default
    {
        [Required]
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<TipoVisitaFormulario> TipoVisitaFormularios { get; set; }
    }
}
