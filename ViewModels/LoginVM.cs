using System.ComponentModel.DataAnnotations;

namespace PFA_Project.ViewModels
{
    public class LoginVM
    {
        
        [Required(ErrorMessage ="Nom du compte est obligatoir")]
        [Display(Name ="Nom du compte")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Mot de passe est obligatoir")]
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Remember Me ")]
        public bool RememberMe { get; set; }
        
    }
}
