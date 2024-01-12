using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestConnectionWithDatabase()
        //{
        //    List<RecipeDTO> recipes = new List<RecipeDTO>();
        //    try
        //    {
        //        OpenDBConnection();
        //        string sql = "SELECT * FROM 'Recipes'";
        //        SqlCommand cmnd = new SqlCommand(sql, GetDBConnection());
        //        SqlDataReader reader = cmnd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int id = Convert.ToInt32(reader[0].ToString());
        //            var ingredients = reader[1].ToString();
        //            var description = reader[2].ToString();
        //            var owner = reader[3].ToString();
        //            recipes.Add(new RecipeDTO());
        //        }
        //        reader.Close();
        //        return recipes;
        //    }
        //    catch (Exception)
        //    {
        //        return recipes;
        //    }
        //    finally
        //    {
        //        CloseDBConnection();

        //    }
        //}
    }
}
