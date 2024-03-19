using System.ComponentModel.DataAnnotations;

namespace PFA__Project.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateOnly dateNaissance { get; set; }
        public DateTime dateInscription { get; set; }
        public List<Notification> notifications { get; set; }
        public Artisan? artisan { get; set; }
        public Client? client { get; set; }

    }
}
