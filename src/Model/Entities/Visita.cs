using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Beakers;
using Sivido.Model.Catalog;
using Sivido.Model.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_VISITA")]
    public class Visita : Default
    {
        [Required]
        public string IdTipoVisita { get; set; }
        [Required]
        public string IdPortafolio { get; set; }
        [Required]
        public string IdCliente { get; set; }
        [Required]
        public string IdDreccion { get; set; }
        [Required]
        public string IdIsnpector { get; set; }
        [Required]
        public DateTime FechaVisita { get; set; }
        public virtual TipoVisita TipoVisita { get; set; }
        public virtual Portafolio Portafolio { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual Inspector Inspector { get; set; }
        public virtual ICollection<VisitaRespuesta> VisitaRespuestas { get; set; }
        public virtual ICollection<Fotografia> Fotografias { get; set; }


        private readonly SividoDataContext context;
        public Visita(SividoDataContext _context)
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
