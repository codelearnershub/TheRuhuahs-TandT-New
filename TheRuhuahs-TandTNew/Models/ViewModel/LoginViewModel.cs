namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-za-z-0-9]+\.[A-za-z]{2,4}",ErrorMessage = "Invalid Email")]
        [Display(Name="Email Address")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Password is Required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
    
}