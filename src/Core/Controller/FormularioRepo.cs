using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivido.Core.Repository;
using Sivido.Model.Catalog;
using Sivido.Model.Entities;

namespace Sivido.Core.Controller
{
    public class FormularioRepo : IFormulario
    {

        private readonly DataContext context;

        public FormularioRepo(DataContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Formulario>> GetAllFormularios()
        {
            return await context.Formulario.ToListAsync();
        }
        public async Task<Formulario> FindFormularioById(string value)
        {
            return await context.Formulario.FirstOrDefaultAsync(i => i.Id == value);
        }
        public async Task<Formulario> AddFormulario(Formulario value)
        {
            await context.Formulario.AddAsync(value);
            context.SaveChanges();
            return value;
        }

        public async Task<Formulario> UpdateFormulario(Formulario value)
        {
            context.Update(value);
            context.SaveChanges();
            return await context.Formulario.FirstOrDefaultAsync(i => i.Id == value.Id);
        }
        public async Task<bool> DeleteFormulario(Formulario value)
        {
            context.Remove(value);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
