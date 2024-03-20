using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PFA__Project.Models
{
    public class ArtisanCategorie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Clé étrangère pour Artisan
        public int ArtisanId { get; set; }
        [ForeignKey("ArtisanId")]
        public virtual Artisan Artisan { get; set; }
        // Clé étrangère pour Categorie
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie Categorie { get; set; }
    }
}
