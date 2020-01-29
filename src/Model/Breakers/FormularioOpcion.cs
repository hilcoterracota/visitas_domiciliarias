using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Catalog;
using Sivido.Model.Core;

namespace Sivido.Model.Beakers
{
    [Table("BRE_FORMULARIO_OPCION")]
    public class FormularioOpcion : DefaultBreak
    {
        [Key]
        public string IdFormulario { get; set; }
        [Key]
        public string IdOpcion { get; set; }
        public virtual Formulario Formulario { get; set; }
        public virtual Opcion Opcion { get; set; }
    }
}