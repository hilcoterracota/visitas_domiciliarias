using System;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Entities;
using Sivido.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sivido.Model.Catalog
{
    [Table("CAT_FOTOGRAFIA")]
    public class Fotografia : Default
    {
        [Required]
        public string IdVisita { get; set; }
        [Required]
        public string ImgBase64 { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }
        public virtual Visita Visita { get; set; }


    }
}
