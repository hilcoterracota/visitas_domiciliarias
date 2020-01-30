using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Beakers;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Catalog
{
    [Table("CAT_FORMULARIO")]
    public class Formulario : Default
    {
        [Required]
        public string IdTipoFormulario { get; set; }
        [Required]
        [MaxLength(200)]
        public string Pregunta { get; set; }
        public virtual TipoFormulario tipoFormulario { get; set; }
        public virtual ICollection<VisitaRespuesta> VisitaRespuestas { get; set; }
        public virtual ICollection<TipoVisitaFormulario> TipoVisitaFormularios { get; set; }
        public virtual ICollection<FormularioOpcion> FormularioOpciones { get; set; }

        private readonly SividoDataContext context;

        public Formulario(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Formulario>> GetAllFormularios()
        {
            return await context.Formulario.ToListAsync();
        }
        public async Task<Formulario> FindFormularioById(string value)
        {
            return await context.Formulario.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Formulario> AddFormulario(Formulario value)
        {
            await context.Formulario.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Formulario> UpdateFormulario(Formulario value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Formulario.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteFormulario(Formulario value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
