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

    }
}
