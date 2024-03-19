using Microsoft.EntityFrameworkCore;

namespace PFA__Project.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Artisan> Artisans { get; set; }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<RendezVous> rendezVous { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }

        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {

        }
    }
}
