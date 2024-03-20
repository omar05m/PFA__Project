using PFA__Project.Models;
using Microsoft.EntityFrameworkCore;

namespace PFA__Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Artisan> Artisans { get; set; }
        public DbSet<ArtisanCategorie> ArtisansCategories { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }


    }
}
