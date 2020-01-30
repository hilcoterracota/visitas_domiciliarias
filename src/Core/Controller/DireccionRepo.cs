using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{
    public class DireccionRepo : IDireccion
    {

        private readonly SividoDataContext context;

        public DireccionRepo(SividoDataContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<Direccion>> GetAllDireccions()
        {
            return await context.Direccion.ToListAsync();
        }
        public async Task<Direccion> FindDireccionById(string value)
        {
            return await context.Direccion.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Direccion> AddDireccion(Direccion value)
        {
            await context.Direccion.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Direccion> UpdateDireccion(Direccion value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Direccion.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteDireccion(Direccion value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }

    }
}
