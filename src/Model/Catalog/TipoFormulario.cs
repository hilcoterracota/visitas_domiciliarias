using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Catalog
{
    [Table("CAT_TIPO_FORMULARIO")]
    public class TipoFormulario : Default
    {
        [Required]
        [MaxLength(10)]
        public string Value { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public virtual ICollection<Formulario> Formularios { get; set; }

    }
}
