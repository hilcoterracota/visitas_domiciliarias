using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{
    public class InspectorRepo : IInspector
    {

        private readonly DataContext context;

        public InspectorRepo(DataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Inspector>> GetAllInspectors()
        {
            return await context.Inspector.ToListAsync();
        }
        public async Task<Inspector> FindInspectorById(string value)
        {
            return await context.Inspector.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Inspector> AddInspector(Inspector value)
        {
            await context.Inspector.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Inspector> UpdateInspector(Inspector value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Inspector.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteInspector(Inspector value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }

    }
}
