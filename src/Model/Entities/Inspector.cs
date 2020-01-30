using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_INSPECTOR")]
    public class Inspector : Default
    {
        [Required]
        [MaxLength(30)]
        public string Usuario { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }

        private readonly SividoDataContext context;

        public Inspector(SividoDataContext _context)
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
