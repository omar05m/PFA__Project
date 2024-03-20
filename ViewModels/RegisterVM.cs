using System.ComponentModel.DataAnnotations;


namespace PFA_Project.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "Nom")]
        public string? Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage ="les mots de passe ne sont pas les même")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
    }
}
