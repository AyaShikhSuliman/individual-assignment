using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUserInformation
    {
        public bool SaveUser(UserDTO user);
        public UserDTO GetUserByID(int id);
        public bool CheckExistence(UserDTO user);
    }
}
