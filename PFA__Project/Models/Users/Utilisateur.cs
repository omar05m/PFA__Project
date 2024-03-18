using System.ComponentModel.DataAnnotations;

namespace PFA__Project.Models.Users
{
    public abstract class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get ; set; }
        public string password { get ; set; }
        public DateOnly DateNaissance { get ; set; }
      
    }
}
