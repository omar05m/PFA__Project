using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public virtual IList<RendezVous> RendezVous { get; set;}
        public virtual Utilisateur Utilisateur { get; set; }
        [ForeignKey("IdUtilisateur")]
        public int UtilisateurId { get; set; }

    }
}
