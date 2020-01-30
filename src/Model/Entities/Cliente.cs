using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_CLIENTE")]
    public class Cliente : Default
    {
        [Required]
        [MaxLength(100)]
        public string RasonSocial { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }

        private readonly SividoDataContext context;

        public Cliente(SividoDataContext _context)
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