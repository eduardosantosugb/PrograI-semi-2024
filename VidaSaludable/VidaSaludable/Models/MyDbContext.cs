using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidaSaludable.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<usuarioLogin> usuarioLogin { get; set; }
        public DbSet<Peso> Peso { get; set; }
        public DbSet<Dieta> Dieta { get; set; }
        public DbSet<HistorialDieta> HistorialDieta { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public DbSet<Actividad> Actividade { get; set; }
        public DbSet<HistorialActividades> HistorialActividad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Pesos)
            .WithOne(p => p.Usuario)
            .HasForeignKey(p => p.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Dietas)
                .WithOne(d => d.Usuario)
                .HasForeignKey(d => d.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Metas)
                .WithOne(m => m.Usuario)
                .HasForeignKey(m => m.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Actividades)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UsuarioId);
        }
    }
}
