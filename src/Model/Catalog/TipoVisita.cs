using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Core;
using Sivido.Model.Entities;

namespace Sivido.Model.Catalog
{
    [Table("CAT_TIPO_VISITA")]
    public class TipoVisita: Default
    {
        public string Nombre {get; set;}
        public string Clave {get; set;}
        public string Descripcion {get; set;}
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<TipoVisitaFormulario> TipoVisitaFormulario { get; set; }
    }
}
