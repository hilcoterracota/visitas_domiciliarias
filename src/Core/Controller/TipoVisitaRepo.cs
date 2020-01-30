using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Catalog;

namespace Sivido.Core.Controller
{
    public class TipoVisitaRepo : ITipoVisita
    {
        private readonly SividoDataContext context;

        public TipoVisitaRepo(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<TipoVisita>> GetAllTipoVisitas()
        {
            return await context.TipoVisita.ToListAsync();
        }
        public async Task<TipoVisita> FindTipoVisitaById(string value)
        {
            return await context.TipoVisita.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<TipoVisita> AddTipoVisita(TipoVisita value)
        {
            await context.TipoVisita.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<TipoVisita> UpdateTipoVisita(TipoVisita value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.TipoVisita.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteTipoVisita(TipoVisita value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
