using System.Collections.Generic;
using System.Threading.Tasks;
using Sivido.Model.Catalog;
using Sivido.Model.Entities;

namespace Sivido.Core.Repository
{
    public interface IVisita
    {
        Task<IEnumerable<Visita>> GetAllVisitas();
        Task<Visita> FindVisitaById(string value);
        Task<Visita> AddVisita(Visita value);
        Task<Visita> UpdateVisita(Visita value);
        Task<bool> DeleteVisita(Visita value);
    }
    public interface IPortafolio
    {

        Task<IEnumerable<Portafolio>> GetAllPortafolios();
        Task<Portafolio> FindPortafolioById(string value);
        Task<Portafolio> AddPortafolio(Portafolio value);
        Task<Portafolio> UpdatePortafolio(Portafolio value);
        Task<bool> DeletePortafolio(Portafolio value);
    }
    public interface IInspector
    {
        Task<IEnumerable<Inspector>> GetAllInspectors();
        Task<Inspector> FindInspectorById(string value);
        Task<Inspector> AddInspector(Inspector value);
        Task<Inspector> UpdateInspector(Inspector value);
        Task<bool> DeleteInspector(Inspector value);
    }
    public interface IDireccion
    {
        Task<IEnumerable<Direccion>> GetAllDireccions();
        Task<Direccion> FindDireccionById(string value);
        Task<Direccion> AddDireccion(Direccion value);
        Task<Direccion> UpdateDireccion(Direccion value);
        Task<bool> DeleteDireccion(Direccion value);
    }
    public interface ICliente
    {
        Task<IEnumerable<Cliente>> GetAllClientes();
        Task<Cliente> FindClienteById(string value);
        Task<Cliente> AddCliente(Cliente value);
        Task<Cliente> UpdateCliente(Cliente value);
        Task<bool> DeleteCliente(Cliente value);
    }
    public interface ITipoVisita
    {
        Task<IEnumerable<TipoVisita>> GetAllTipoVisitas();
        Task<TipoVisita> FindTipoVisitaById(string value);
        Task<TipoVisita> AddTipoVisita(TipoVisita value);
        Task<TipoVisita> UpdateTipoVisita(TipoVisita value);
        Task<bool> DeleteTipoVisita(TipoVisita value);
    }
    public interface ITipoFormulario
    {
        Task<IEnumerable<TipoFormulario>> GetAllTipoFormularios();
        Task<TipoFormulario> FindTipoFormularioById(string value);
        Task<TipoFormulario> AddTipoFormulario(TipoFormulario value);
        Task<TipoFormulario> UpdateTipoFormulario(TipoFormulario value);
        Task<bool> DeleteTipoFormulario(TipoFormulario value);
    }
    public interface IOpcion
    {
        Task<IEnumerable<Opcion>> GetAllOpcions();
        Task<Opcion> FindOpcionById(string value);
        Task<Opcion> AddOpcion(Opcion value);
        Task<Opcion> UpdateOpcion(Opcion value);
        Task<bool> DeleteOpcion(Opcion value);
    }
    public interface IFotografia
    {
        Task<IEnumerable<Fotografia>> GetAllFotografias();
        Task<Fotografia> FindFotografiaById(string value);
        Task<Fotografia> AddFotografia(Fotografia value);
        Task<Fotografia> UpdateFotografia(Fotografia value);
        Task<bool> DeleteFotografia(Fotografia value);
    }
    public interface IFormulario
    {
        Task<IEnumerable<Formulario>> GetAllFormularios();
        Task<Formulario> FindFormularioById(string value);
        Task<Formulario> AddFormulario(Formulario value);
        Task<Formulario> UpdateFormulario(Formulario value); Task<bool> DeleteFormulario(Formulario value);
    }
}
