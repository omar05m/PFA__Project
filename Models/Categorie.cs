using System.ComponentModel.DataAnnotations;

namespace PFA__Project.Models
{
    public class Categorie
    {
        [Key]
        public int IdCategorie { get; set; } // Identifiant de la catégorie
        public string NomCategorie { get; set; } // Nom de la catégorie
        public string DescriptionCategorie { get; set; } // Description de la catégorie
        public IList<Artisan> Artisans { get; set; } // Liste des artisans associés à cette catégorie

    }
}
