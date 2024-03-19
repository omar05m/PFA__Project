using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class Artisan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int nbrAnneExperience { get; set; }
        [Required(ErrorMessage ="CIN est importante !!")]
        public string cin { get; set; }
        [RegularExpression(@"^\+212\d{9}$", ErrorMessage = "Le numéro de téléphone doit commencer par '+212' et contenir 9 chiffres.")]
        public string numeroTele { get; set; }
        
        public double prixService { get; set; }
        public string photoCIN { get; set; }
        public List<RendezVous> rendezVous { get;set; }

        public Categorie categorie { get; set; }

        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; }



    }
}
