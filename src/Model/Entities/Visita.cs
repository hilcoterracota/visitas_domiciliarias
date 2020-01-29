using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Catalog;
using Sivido.Model.Core;

namespace Sivido.Model.Entities
{
    [Table("T_VISITA")]
    public class Visita : Default
    {
        public string IdTipoVisita { get; set; }
        public string IdPortafolio { get; set; }
        public string IdCliente { get; set; }
        public string IdDreccion { get; set; }
        public string IdIsnpector { get; set; }
        public DateTime FechaVisita { get; set; }
        public virtual TipoVisita TipoVisita { get; set; }
        public virtual Portafolio Portafolio { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual Inspector Inspector { get; set; }
        public virtual ICollection<VisitaRespuesta> VisitaRespuestas { get; set; }
    }
}
