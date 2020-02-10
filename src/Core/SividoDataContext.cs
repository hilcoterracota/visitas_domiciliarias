using Microsoft.EntityFrameworkCore;
using Sivido.Model.Beakers;
using Sivido.Model.Catalog;
using Sivido.Model.Entities;
using System;

namespace Sivido.Core
{
    public class SividoDataContext : DbContext
    {
        public SividoDataContext()
        { }

        public SividoDataContext(DbContextOptions<SividoDataContext> options) : base(options)
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
        public virtual DbSet<Status> Status { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("MSQL_SIVIDO"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Visita>(entity =>
            {

                entity.HasOne(d => d.TipoVisita)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.IdTipoVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Portafolio)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.IdPortafolio)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.IdDreccion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Inspector)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.IdIsnpector)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<VisitaRespuesta>(entity =>
            {
                entity.HasKey(c => new { c.IdVisita, c.IdFormulario });

                entity.HasOne(d => d.Visita)
                    .WithMany(p => p.VisitaRespuestas)
                    .HasForeignKey(d => d.IdVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Formulario)
                    .WithMany(p => p.VisitaRespuestas)
                    .HasForeignKey(d => d.IdFormulario)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<Fotografia>(entity =>
            {

                entity.HasOne(d => d.Visita)
                    .WithMany(p => p.Fotografias)
                    .HasForeignKey(d => d.IdVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<Formulario>(entity =>
            {

                entity.HasOne(d => d.tipoFormulario)
                    .WithMany(p => p.Formularios)
                    .HasForeignKey(d => d.IdTipoFormulario)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<TipoVisitaFormulario>(entity =>
            {

                entity.HasKey(c => new { c.IdTipoVisita, c.IdFormulario });

                entity.HasOne(d => d.TipoVisita)
                    .WithMany(p => p.TipoVisitaFormularios)
                    .HasForeignKey(d => d.IdTipoVisita)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Formulario)
                    .WithMany(p => p.TipoVisitaFormularios)
                    .HasForeignKey(d => d.IdFormulario)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<FormularioOpcion>(entity =>
            {

                entity.HasKey(c => new { c.IdFormulario, c.IdOpcion });

                entity.HasOne(d => d.Opcion)
                    .WithMany(p => p.FormularioOpciones)
                    .HasForeignKey(d => d.IdOpcion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Formulario)
                    .WithMany(p => p.FormularioOpciones)
                    .HasForeignKey(d => d.IdFormulario)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });

        }

    }
}
