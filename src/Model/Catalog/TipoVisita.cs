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
        [MaxLength(30)]
        public string Nombre { get; set; }
        [MaxLength(10)]
        public string Clave { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<TipoVisitaFormulario> TipoVisitaFormularios { get; set; }
    }
}
