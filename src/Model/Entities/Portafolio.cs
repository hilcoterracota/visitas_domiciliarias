using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_PORTAFOLIO")]
    public class Portafolio : Default
    {
        [Required]
        [MaxLength(100)]
        public string RasonSocial { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }

        private readonly SividoDataContext context;
        public Portafolio(SividoDataContext _context)
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
