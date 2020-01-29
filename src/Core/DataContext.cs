using Microsoft.EntityFrameworkCore;
using Sivido.Model.Beakers;
using Sivido.Model.Catalog;
using Sivido.Model.Entities;
using System;

namespace Sivido.Core
{
    public class DataContext : DbContext
    {
        public DataContext()
        { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public virtual DbSet<FormularioOpcion> FormularioOpcion { get; set; }
        public virtual DbSet<TipoVisitaFormulario> TipoVisitaFormulario { get; set; }
        public virtual DbSet<VisitaRespuesta> VisitaRespuesta { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<Opcion> Opcion { get; set; }
        public virtual DbSet<TipoFormulario> TipoFormulario { get; set; }
        public virtual DbSet<TipoVisita> TipoVisita { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<Portafolio> Portafolio { get; set; }
        public virtual DbSet<Visita> Visita { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("MSQL_SAMPEKEY"));
        }

    }
}
