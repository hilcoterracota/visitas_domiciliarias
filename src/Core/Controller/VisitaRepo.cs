using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{
    public class VisitaRepo: IVisita
    {
        private readonly SividoDataContext context;
        public VisitaRepo(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Visita>> GetAllVisitas()
        {
            return await context.Visita.ToListAsync();
        }
        
        public async Task<Visita> FindVisitaById(string value)
        {
            return await context.Visita.FirstOrDefaultAsync(i => i.Id == value);
        }

        public async Task<Visita> AddVisita(Visita value)
        {
            await context.Visita.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Visita> UpdateVisita(Visita value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Visita.FirstOrDefaultAsync(i => i.Id == value.Id);
        }

        public async Task<bool> DeleteVisita(Visita value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;
        }
        
    }
}
