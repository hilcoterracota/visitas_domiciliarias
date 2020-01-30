using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Catalog;

namespace Sivido.Core.Controller
{
    public class OpcionRepo : IOpcion
    {
        private readonly DataContext context;

        public OpcionRepo(DataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Opcion>> GetAllOpcions()
        {
            return await context.Opcion.ToListAsync();
        }
        public async Task<Opcion> FindOpcionById(string value)
        {
            return await context.Opcion.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Opcion> AddOpcion(Opcion value)
        {
            await context.Opcion.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Opcion> UpdateOpcion(Opcion value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Opcion.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteOpcion(Opcion value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
