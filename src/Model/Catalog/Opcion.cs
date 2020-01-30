using System;
using Sivido.Model.Beakers;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sivido.Model.Catalog
{
    [Table("CAT_OPCION")]
    public class Opcion : Default
    {
        [Required]
        [MaxLength(30)]
        public string Value { get; set; }
        [Required]
        public Boolean RequiereFotografia { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public virtual ICollection<FormularioOpcion> FormularioOpciones { get; set; }

        private readonly SividoDataContext context;

        public Opcion(SividoDataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Opcion>> GetAllOpcions()
        {
            return await context.Opcion.ToListAsync();
        }
        public async Task<Opcion> FindOpcionById(string value)
        {
            return await context.Opcion.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Opcion> AddOpcion(Opcion value)
        {
            await context.Opcion.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Opcion> UpdateOpcion(Opcion value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Opcion.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteOpcion(Opcion value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
