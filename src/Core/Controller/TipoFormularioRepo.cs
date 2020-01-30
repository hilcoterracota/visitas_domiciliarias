using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Catalog;

namespace Sivido.Core.Controller
{
    public class TipoFormularioRepo : ITipoFormulario
    {
        private readonly DataContext context;

        public TipoFormularioRepo(DataContext _context)
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
