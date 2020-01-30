using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Beakers;
using Sivido.Model.Core;
using Sivido.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Catalog
{
    [Table("CAT_TIPO_VISITA")]
    public class TipoVisita : Default
    {
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        [MaxLength(10)]
        public string Clave { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<TipoVisitaFormulario> TipoVisitaFormularios { get; set; }

        private readonly SividoDataContext context;

        public TipoVisita(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<TipoVisita>> GetAllTipoVisitas()
        {
            return await context.TipoVisita.ToListAsync();
        }
        public async Task<TipoVisita> FindTipoVisitaById(string value)
        {
            return await context.TipoVisita.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<TipoVisita> AddTipoVisita(TipoVisita value)
        {
            await context.TipoVisita.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<TipoVisita> UpdateTipoVisita(TipoVisita value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.TipoVisita.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteTipoVisita(TipoVisita value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
