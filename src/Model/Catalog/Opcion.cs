using System;
using Sivido.Model.Beakers;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sivido.Model.Catalog
{
    [Table("CAT_OPCION")]
    public class Opcion : Default
    {
        [Required]
        [MaxLength(30)]
        public string Value { get; set; }
        [Required]
        public Boolean RequiereFotografia { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public virtual ICollection<FormularioOpcion> FormularioOpciones { get; set; }

    }
}
