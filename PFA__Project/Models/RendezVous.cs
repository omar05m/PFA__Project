using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class RendezVous
    {
        public int Id { get; set; }
        public DateTime DateRendezVous { get; set; }
        public double TauxService { get; set; }
        public string Description { get; set; }

        public Artisan artisan { get; set; }

        public int ArtisanId { get; set; }

        public Client client { get; set; }

        public int ClientId { get; set; }
        

    }
}
