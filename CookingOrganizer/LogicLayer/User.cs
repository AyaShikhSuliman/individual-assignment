using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length of a name is 3 characters.", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Characters are not allowed.")]
        [StringLength(25, ErrorMessage = "The minimum allowed length of a name is 3 characters.", MinimumLength = 3)]
        public string Password { get; set; }
        public User()
        {

        }
        public User(UserDTO userDTO)
        {
            Name = userDTO.Name;
            Password = userDTO.Password;
        }
        public string GetInfoForDesktop()
        {
            return $"User with id: {Id}, name: {Name} and password: {Password}";
        }
    }
}
