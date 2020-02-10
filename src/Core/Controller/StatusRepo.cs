using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{
    public class StatusRepo: IStatus
    {
        private readonly SividoDataContext context;
        public StatusRepo(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Status>> GetAllStatus()
        {
            return await context.Status.ToListAsync();
        }
        
        public async Task<Status> FindStatusById(string value)
        {
            return await context.Status.FirstOrDefaultAsync(i => i.Id == value);
        }

        public async Task<Status> AddStatus(Status value)
        {
            await context.Status.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Status> UpdateStatus(Status value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Status.FirstOrDefaultAsync(i => i.Id == value.Id);
        }

        public async Task<bool> DeleteStatus(Status value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;
        }
        
    }
}
