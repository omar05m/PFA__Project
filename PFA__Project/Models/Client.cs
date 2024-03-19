using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public List<RendezVous> rendezVous { get; set;}

        public Utilisateur Utilisateur { get; set; }


        public int UtilisateurId { get; set; }

    }
}
