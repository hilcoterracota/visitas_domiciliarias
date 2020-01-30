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

        private readonly SividoDataContext context;

        public TipoFormulario(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<TipoFormulario>> GetAllTipoFormularios()
        {
            return await context.TipoFormulario.ToListAsync();
        }
        public async Task<TipoFormulario> FindTipoFormularioById(string value)
        {
            return await context.TipoFormulario.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<TipoFormulario> AddTipoFormulario(TipoFormulario value)
        {
            await context.TipoFormulario.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<TipoFormulario> UpdateTipoFormulario(TipoFormulario value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.TipoFormulario.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        
        public async Task<bool> DeleteTipoFormulario(TipoFormulario value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
