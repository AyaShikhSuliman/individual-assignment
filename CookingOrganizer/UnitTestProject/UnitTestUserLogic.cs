using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestUserLogic
    {
        private static MockUserInfoDAl mockUserInfoDAl = new MockUserInfoDAl();
        private readonly UserManager userManager1 = new UserManager(mockUserInfoDAl);


        [TestMethod]
        public void TestConstructor()
        {
            UserManager userManager = new UserManager(new MockUserInfoDAl());
            Assert.ReferenceEquals(userManager, userManager1);
        }
        [TestMethod]
        public void TestSaveUser()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = "Name";
            userDTO.Password = "Password";
            User user = new User(userDTO);
            bool isDone = userManager1.SaveUser(user);
            Assert.AreEqual(isDone, true);
        }
        [TestMethod]
        public void TestCheckExistence()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Id = int.Parse("1");
            userDTO.Name = "Name";
            userDTO.Password = "Password";
            User user = new User(userDTO);
            bool exists = userManager1.CheckExistence(user);

            Assert.AreEqual(exists, true);
        }

    }
}
