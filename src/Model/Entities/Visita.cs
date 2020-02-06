using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Beakers;
using Sivido.Model.Catalog;
using Sivido.Model.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_VISITA")]
    public class Visita : Default
    {
        [Required]
        public string IdTipoVisita { get; set; }
        [Required]
        public string IdPortafolio { get; set; }
        [Required]
        public string IdCliente { get; set; }
        [Required]
        public string IdDreccion { get; set; }
        [Required]
        public string IdIsnpector { get; set; }
        [Required]
        public DateTime FechaVisita { get; set; }
        [Required]
        public Boolean PrimeraVisita { get; set; }
        [MaxLength(100)]
        public string Destinatario { get; set; }
        [MaxLength(100)]
        public string Puesto { get; set; }
        public virtual TipoVisita TipoVisita { get; set; }
        public virtual Portafolio Portafolio { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual Inspector Inspector { get; set; }
        public virtual ICollection<VisitaRespuesta> VisitaRespuestas { get; set; }
        public virtual ICollection<Fotografia> Fotografias { get; set; }
        
    }
}
