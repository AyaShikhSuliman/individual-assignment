using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IManageUser
    {
        public bool SaveUser(User user);
        public User GetUserByID(int id);
    }
}
