using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class RoleViewModel
    {
        public int Id { get; set;}
        public string RoleName { get; set;}
        public  List<Role> Roles { get; set;}
        public DateTime CreatedAt { get; set;}
    }
        public class CreateRoleViewModel
        {
            public int Id { get; set;}
            
            [Display(Name=" Name")]
            [Required(ErrorMessage = "Name is Required")]
            public string RoleName { get; set;}

        } 
    public class UpdateRoleViewModel
    {
        public int Id { get; set;}
        [Display(Name="Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string RoleName { get; set;}
        
    }
}