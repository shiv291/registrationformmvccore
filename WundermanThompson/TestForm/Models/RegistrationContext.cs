using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestForm.Models
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext()
        {
        }

        public RegistrationContext(DbContextOptions<RegistrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegistrationForm> RegistrationForms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PCPC;Database=Interview;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<RegistrationForm>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__RegistrionForm");
                               
            });
        }
    }
}
