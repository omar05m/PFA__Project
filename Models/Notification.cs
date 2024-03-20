using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateNotification { get; set; }
        public Utilisateur utilisateur { get; set; }
        public int UtilisateurId { get; set; }

    }
}
