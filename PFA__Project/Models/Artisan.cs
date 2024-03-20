using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class Artisan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArtisan { get; set; }
        public int NbrAnneeExperience { get; set; }
        [Required(ErrorMessage ="CIN est importante !!")]
        [RegularExpression(@"^[A-Z]{1,2}\d{6}$", ErrorMessage = "Le numéro CIN n'est pas valide.")]
        public string CIN { get; set; }
        [RegularExpression(@"^\+212\d{9}$", ErrorMessage = "Le numéro de téléphone doit commencer par '+212' et contenir 9 chiffres.")]
        public string NumTele { get; set; }
        public float PrixDeService { get; set; }
        public string ImageDeCarteID { get; set; }
        public virtual IList<RendezVous> RendezVous { get;set; }
        public virtual IList<ArtisanCategorie> ArtisanCategories { get; set; } // Relation Many-to-Many avec Categories
        public int IdUtilisateur { get; set; } // Clé étrangère pour la relation One-to-One avec Utilisateur
        [ForeignKey("IdUtilisateur")]
        public virtual Utilisateur Utilisateur { get; set; }




    }
}
