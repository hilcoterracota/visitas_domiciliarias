using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{
    public class ClienteRepo : ICliente
    {
        private readonly SividoDataContext context;

        public ClienteRepo(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            return await context.Cliente.ToListAsync();
        }
        public async Task<Cliente> FindClienteById(string value)
        {
            return await context.Cliente.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Cliente> AddCliente(Cliente value)
        {
            await context.Cliente.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Cliente> UpdateCliente(Cliente value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Cliente.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteCliente(Cliente value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }

    }
}