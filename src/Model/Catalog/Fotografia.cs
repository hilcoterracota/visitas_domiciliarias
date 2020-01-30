using System;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Entities;
using Sivido.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sivido.Model.Catalog
{
    [Table("CAT_FOTOGRAFIA")]
    public class Fotografia : Default
    {
        [Required]
        public string IdVisita { get; set; }
        [Required]
        public string ImgBase64 { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }
        public virtual Visita Visita { get; set; }

        private readonly SividoDataContext context;

        public Fotografia(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Fotografia>> GetAllFotografias()
        {
            return await context.Fotografia.ToListAsync();
        }
        public async Task<Fotografia> FindFotografiaById(string value)
        {
            return await context.Fotografia.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Fotografia> AddFotografia(Fotografia value)
        {
            await context.Fotografia.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Fotografia> UpdateFotografia(Fotografia value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Fotografia.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteFotografia(Fotografia value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }

    }
}
