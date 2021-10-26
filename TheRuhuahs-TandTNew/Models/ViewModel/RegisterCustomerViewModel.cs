using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class RegisterCustomerViewModel : LoginViewModel
    {
       
        [Display(Name="First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set;}

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name="Last Name")]
        public string LastName { get; set;}

        [Required(ErrorMessage = "Gender is Required")]
        [Display(Name=" Gender")]
        public string Gender { get; set;}


        [Required(ErrorMessage = "Phone Number is Required")]
        [Display(Name="Phone Number")]
        [MaxLength(11, ErrorMessage ="Invalid Mobile Number! Please Check The Number And TryAgain ")]
        [MinLength(11, ErrorMessage ="Invalid Mobile Number! Please Check The Number And TryAgain ")]
        public string Mobile { get; set;}
        
        [Required(ErrorMessage = "Date Of Birth is Required")]
        [Display ( Name = " Date Of Birth")]
        public DateTime DateOfBirth { get; set;}

        [Required(ErrorMessage = "Date Of Birth is Required")]
        [Display(Name="Street Address")]
        public string StreetAddress { get; set;}

        [Required(ErrorMessage = "State is Required")]
        [Display(Name="State")]
        public string State { get; set;}

        [Required(ErrorMessage = "Country")]
        [Display(Name="Country")]
        public string Country { get; set;}

        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Does Not Match!!!")]
        public string ConfirmPassword { get; set;}
        [Required(ErrorMessage = "Password is Required")]
        [Display(Name="Password")]
        public List<Role> Roles { get; set; }
         
    }
    public class UpdateUserViewModel : RegisterCustomerViewModel
    {
        
    }
}