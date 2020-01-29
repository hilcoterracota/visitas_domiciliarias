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
        public virtual DbSet<Fotografia> Fotografia { get; set; }
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
            optionsBuilder.UseSqlServer("Server=192.168.2.1;Database=sivido;User Id=terrask;Password=yPHIwa4men");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormularioOpcion>().HasKey(c => new { c.IdFormulario, c.IdOpcion });
            modelBuilder.Entity<TipoVisitaFormulario>().HasKey(c => new { c.IdTipoVisita, c.IdFormulartio });
            modelBuilder.Entity<VisitaRespuesta>().HasKey(c => new { c.IdVisita, c.IdFormulario });
        }

    }
}
