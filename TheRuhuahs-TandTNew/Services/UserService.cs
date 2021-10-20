using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;

            _roleRepository = roleRepository;
        }
        private string HashPassword(string password, string salt)
        {
            byte[] saltByte = Convert.FromBase64String(salt);
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
        public void Register(RegisterViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = _roleRepository.FindByRoleName("Customer");
            if (role != null){
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Gender = model.Gender,
                    Password = model.Password,
                    PasswordHash = hashedPassword,
                    HashSalt = saltString,
                    Mobile = model.Mobile,
                    DateOfBirth = model.DateOfBirth,
                    StreetAddress = model.StreetAddress,
                    State = model.State,
                    Country = model.Country

                };
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id,
                };
                user.UserRoles.Add(userRole);
                _userRepository.AddUser(user);
                }
            else{
                throw new Exception("No Role found");
            }
        }
              
        // public void RegisterUser(RegisterViewModel model)
        // {
        //     byte[] salt = new byte[128 / 8];

        //     using (var rng = RandomNumberGenerator.Create())
        //     {
        //         rng.GetBytes(salt);
        //     }

        //     string saltString = Convert.ToBase64String(salt);

        //     string hashedPassword = HashPassword(model.Password, saltString);
        //     var role = _roleRepository.FindByRoleName("Admin");
        //     if (role != null)
        //     {
        //         User user = new User
        //         {
        //             FirstName = model.FirstName,
        //             LastName = model.LastName,
        //             Email = model.Email,
        //             Gender = model.Gender,
        //             Password = model.Password,
        //             PasswordHash = hashedPassword,
        //             HashSalt = saltString,
        //             Mobile = model.Mobile,
        //             DateOfBirth = model.DateOfBirth,
        //             StreetAddress = model.StreetAddress,
        //             State = model.State,
        //             Country = model.Country

                    
        //         };
            
            
        //         var userRole = new UserRole
        //         {
        //             UserId = user.Id,
        //             RoleId = role.Id,
        //         };
        //         user.UserRoles.Add(userRole);
        //         _userRepository.AddUser(user);
        //     };
        // }
        public User LoginUser(string email, string password)
        {
            User user = _userRepository.FindByUserEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            string HashedPassword = HashPassword(password, user.HashSalt);

            if (user.PasswordHash.Equals(HashedPassword))
            {
                Console.WriteLine("User is found");

                return user;
            }
            return null;
        }

        public void RegisterUser(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}