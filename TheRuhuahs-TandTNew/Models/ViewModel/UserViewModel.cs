using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheRuhuahs_TandTNew.Models.ViewModel
{
    public class UserViewModel
    {
        public List<User> Users { get; set;}
        public int Id { get; set;}
        public string FirstName { get; set;}

        public string LastName { get; set;}

        public string Gender { get; set;}

        public string PasswordHash { get; set;}

        public string HashSalt { get; set;}

        public string Mobile { get; set;}

        public DateTime DateOfBirth { get; set;}

        public string StreetAddress { get; set;}

        public string State { get; set;}

        public string Country { get; set;}
        [Key]
        public string Email { get; set;}

        public string Password { get; set;}
    }
}