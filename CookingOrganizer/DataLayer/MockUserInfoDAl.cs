using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MockUserInfoDAl : IUserInformation
    {
        public bool SaveUser(UserDTO user)
        {
            return true;
        }

        public UserDTO GetUserByID(int id)
        {
            return new UserDTO();
        }

        public bool CheckExistence(UserDTO user)
        {
            return true;
        }

        
    }
}
