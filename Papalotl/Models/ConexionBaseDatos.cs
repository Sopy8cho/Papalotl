using Microsoft.EntityFrameworkCore;
namespace Papalotl.Models
{
    public class ConexionBaseDatos : DbContext
    {

        public ConexionBaseDatos (DbContextOptions<ConexionBaseDatos> opt)
            : base(opt) { }
        public DbSet<Admin>  Admins { get; set; }
        public DbSet<Psic> Psics { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
