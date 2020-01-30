using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Catalog;

namespace Sivido.Core.Controller
{
    public class FotografiaRepo : IFotografia
    {
        private readonly SividoDataContext context;

        public FotografiaRepo(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Fotografia>> GetAllFotografias()
        {
            return await context.Fotografia.ToListAsync();
        }
        public async Task<Fotografia> FindFotografiaById(string value)
        {
            return await context.Fotografia.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Fotografia> AddFotografia(Fotografia value)
        {
            await context.Fotografia.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Fotografia> UpdateFotografia(Fotografia value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Fotografia.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteFotografia(Fotografia value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }

    }
}
