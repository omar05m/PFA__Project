using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class Utilisateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUtilisateur { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire", AllowEmptyStrings = false)]
        public required string Nom { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire", AllowEmptyStrings = false)]
        public required string Prenom { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "L'adresse email n'est pas valide.")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire", AllowEmptyStrings = false)]
        public required string Password { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateInscription { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
        public IList<Notification> Notifications { get; set; }
        public virtual Client? Client { get; set; }
        public virtual Artisan? Artisan { get; set; }



    }
}
