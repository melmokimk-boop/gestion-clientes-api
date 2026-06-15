using Microsoft.EntityFrameworkCore;
using GestionClientesAPI.Models;

namespace GestionClientesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mensaje>()
                .HasOne(m => m.Cliente)
                .WithMany(c => c.Mensajes)
                .HasForeignKey(m => m.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}