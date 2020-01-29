using Microsoft.EntityFrameworkCore;
using Sivido.Core;
using Sivido.Model.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Sivido.Model.Entities
{
    [Table("T_DIRECCION")]
    public class Direccion : Default
    {
        [Required]
        [MaxLength(100)]
        public string Calle { get; set; }
        [Required]
        [MaxLength(10)]
        public string NumeroExterior { get; set; }
        [MaxLength(10)]
        public string NumeroInterior { get; set; }
        [Required]
        [MaxLength(10)]
        public string CP { get; set; }
        [MaxLength(30)]
        public string Colonia { get; set; }
        [MaxLength(20)]
        public string Estado { get; set; }
        [MaxLength(20)]
        public string Pais { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }

        private readonly DataContext context;

        public Direccion(DataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Direccion>> GetAllDireccions()
        {
            return await context.Direccion.ToListAsync();
        }
        public async Task<Direccion> FindDireccionById(string value)
        {
            return await context.Direccion.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Direccion> AddDireccion(Direccion value)
        {
            await context.Direccion.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Direccion> UpdateDireccion(Direccion value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Direccion.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteDireccion(Direccion value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }

    }
}
