using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA__Project.Models
{
    public class RendezVous
    {
        [Key]
        public int IdRendezVous { get; set; }
        public DateTime DateRendezVous { get; set; }
        public double TauxService { get; set; }
        public string Description { get; set; }
        [ForeignKey("ArtisanId")]
        public Artisan Artisan { get; set; }
        public int ArtisanId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public int ClientId { get; set; }

    }
}
