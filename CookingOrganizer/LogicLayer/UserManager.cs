using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class UserManager : IManageUser
    {
        private readonly IUserInformation userInformation;

        public UserManager(IUserInformation userInformation)
        {
            this.userInformation = userInformation ?? throw new ArgumentNullException(nameof(userInformation));
        }

        public User GetUserByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveUser(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = user.Name;
            userDTO.Password = user.Password;
            if (!userInformation.SaveUser(userDTO))
            {
                return false;
            }
            return true;
        }
        public bool CheckExistence(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = user.Name;
            userDTO.Password = user.Password;
            if (!userInformation.CheckExistence(userDTO))
            {
                return false;
            }
            return true;
        }
        public User CreateUser(string name, string password)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = name;
            userDTO.Password = password;
            return new User(userDTO);
        }
    }
}
