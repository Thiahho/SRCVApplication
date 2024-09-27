using Microsoft.EntityFrameworkCore;
using SRVCWebApi.Modelos;

namespace SRVCWebApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<DbContext> options) : base(options) 
        {
        
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Donde> Donde { get; set; }
        public DbSet<Entra> Entra{ get; set; }
        public DbSet<Motivo> Motivo{ get; set; }
        public DbSet<Registro> Registro { get; set; }
        public DbSet<Salida> Salida { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(true);

            });
        }
    }
}
