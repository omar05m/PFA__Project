namespace PFA__Project.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string NomCategorie { get; set; }
        public string DescriptionCategorie { get; set; }
        public List<Artisan> artisans { get; set; }
    }
}
