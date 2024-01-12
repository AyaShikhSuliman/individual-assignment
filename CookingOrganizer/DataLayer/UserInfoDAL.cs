using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer
{
    public class UserInfoDAL : BaseDAL, IUserInformation
    {
        public UserDTO GetUserByID(int id)
        {
            UserDTO userDTO = new UserDTO();
            SqlConnection connection = GetDBConnection();

            try
            {
                connection.Open();
                string sql = $"SELECT * FROM User where User.id = {id}";
                SqlCommand cmnd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    userDTO.Id = Convert.ToInt32(reader[0].ToString());
                    userDTO.Name = reader[1].ToString();
                    userDTO.Password = reader[2].ToString();
                }
                reader.Close();
                return userDTO;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool SaveUser(UserDTO user)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                string saveUser = $"INSERT INTO[dbo].[User] (name, password) VALUES ('{user.Name}','{user.Password}')";
                SqlCommand cmnd = new SqlCommand(saveUser, connection);
                connection.Open();
                cmnd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool CheckExistence(UserDTO user)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                string selectUser = $"Select * From [dbo].[User] Where name = '{user.Name}' And password = '{user.Password}'";
                SqlCommand cmnd = new SqlCommand(selectUser, connection);
                connection.Open();
                cmnd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
