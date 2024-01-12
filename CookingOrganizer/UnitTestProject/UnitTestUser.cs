using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestUser
    {
        [TestMethod]
        public void TestConstructor()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = "Name";
            userDTO.Password = "Password";
            User user = new User(userDTO);
            Assert.IsNotNull(user);
        }
        [TestMethod]
        public void TestNameProperty()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = "Name";
            userDTO.Password = "Password";
            User user = new User(userDTO);
            Assert.AreEqual(user.Name, userDTO.Name);
        }
        [TestMethod]
        public void TestPasswordProperty()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = "Name";
            userDTO.Password = "Password";
            User user = new User(userDTO);
            Assert.AreEqual(user.Password, userDTO.Password);
        }
        [TestMethod]
        public void TestGetInfoForDesktop()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name = "Name";
            userDTO.Password = "Password";
            User user = new User(userDTO);
            Assert.AreEqual(user.GetInfoForDesktop(), $"User with id: {user.Id}, name: {user.Name} and password: {user.Password}");
        }
    }
}
