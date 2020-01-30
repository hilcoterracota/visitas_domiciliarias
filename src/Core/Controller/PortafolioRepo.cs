using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{

    public class PortafolioRepo : IPortafolio
    {
        
        private readonly DataContext context;
        public PortafolioRepo(DataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Portafolio>> GetAllPortafolios()
        {
            return await context.Portafolio.ToListAsync();
        }
        
        public async Task<Portafolio> FindPortafolioById(string value)
        {
            return await context.Portafolio.FirstOrDefaultAsync(i => i.Id == value);
        }

        public async Task<Portafolio> AddPortafolio(Portafolio value)
        {
            await context.Portafolio.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Portafolio> UpdatePortafolio(Portafolio value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Portafolio.FirstOrDefaultAsync(i => i.Id == value.Id);
        }

        public async Task<bool> DeletePortafolio(Portafolio value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
