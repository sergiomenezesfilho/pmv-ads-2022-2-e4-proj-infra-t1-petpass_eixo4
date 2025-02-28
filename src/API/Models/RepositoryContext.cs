﻿using Microsoft.EntityFrameworkCore;

namespace PetPassBackend.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UsuarioPet>()
                .HasKey(c => new { c.PetId, c.UsuarioId });
            builder.Entity<UsuarioPet>()
                .HasOne(c => c.Usuario).WithMany(c => c.Pets)
                .HasForeignKey(c => c.UsuarioId);
            builder.Entity<UsuarioPet>()
                .HasOne(c => c.Pet).WithMany(c => c.Usuarios)
                .HasForeignKey(c => c.PetId);

            builder.Entity<RegistroVacina>()
                .HasOne(c => c.Pet).WithMany(c => c.RegistroVacinas)
                .HasForeignKey(c => c.PetId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<RegistroVacina>()
                .HasOne(c => c.Vacina).WithMany(c => c.PetsVacinados)
                .HasForeignKey(c => c.VacinaId).OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioPet> UsuarioPets { get; set; }
        public DbSet<RegistroVacina> RegistroVacinas { get; set; }
    }
}
