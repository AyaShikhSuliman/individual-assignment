using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace DataLayer
{
    public class RecipeInfoDAL : BaseDAL, IRecipeInformation
    {
        public RecipeDTO GetRecipeByID(int id)
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            SqlConnection connection = GetDBConnection();

            try
            {
                connection.Open();
                string sql = $"SELECT * FROM Recipe where Recipe.id = {id}";
                SqlCommand cmnd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    recipeDTO.Id = Convert.ToInt32(reader[0].ToString());
                    recipeDTO.Ingredients = reader[1].ToString();
                    recipeDTO.Description = reader[2].ToString();
                    if (reader[3] is not DBNull)
                    {
                        recipeDTO.Owner = reader[3].ToString();
                    }
                    if (reader[4] is not DBNull)
                    {
                        try
                        {
                            recipeDTO.Image = ByteToImage((byte[])reader[4]);
                            recipeDTO.ImageInBytes = (byte[])reader[4];
                        }
                        catch (System.ArgumentException)
                        {
                            recipeDTO.Image = null;
                        }
                    }
                    recipeDTO.Name = reader[5].ToString();
                }
                reader.Close();
                return recipeDTO;
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
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream memoryStream = new MemoryStream();
            byte[] pData = blob;
            memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(memoryStream, false);
            memoryStream.Dispose();
            return bm;

        }
        public List<RecipeDTO> GetRecipes()
        {
            List<RecipeDTO> recipes = new List<RecipeDTO>();
            SqlConnection connection = GetDBConnection();
            try
            {
                connection.Open();
                string sql = "SELECT * FROM Recipe";
                SqlCommand cmnd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    RecipeDTO recipeDTO = new RecipeDTO();
                    recipeDTO.Id = Convert.ToInt32(reader[0].ToString());
                    recipeDTO.Ingredients = reader[1].ToString();
                    recipeDTO.Description = reader[2].ToString();
                    if (reader[3] is not DBNull)
                    {
                        recipeDTO.Owner = reader[3].ToString();
                    }
                    if (reader[4] is not DBNull)
                    {
                        try
                        {
                            recipeDTO.Image = ByteToImage((byte[])reader[4]);
                            recipeDTO.ImageInBytes = (byte[])reader[4];
                        }
                        catch (System.ArgumentException)
                        {
                            recipeDTO.Image = null;
                            recipeDTO.ImageInBytes = null;
                        }
                    }
                    recipeDTO.Name = reader[5].ToString();
                    recipes.Add(recipeDTO);
                }
                reader.Close();
                return recipes;
            }
            catch (Exception)
            {
                return recipes;
            }
            finally
            {
                connection.Close();
            }

        }

        //public Recipe LoadRecipe(string recipeInfo)
        //{
        //    try
        //    {
        //        OpenDBConnection();
        //        string sql = "SELECT * FROM 'Recipes'";
        //        SqlCommand cmnd = new SqlCommand(sql, GetDBConnection());
        //        SqlDataReader reader = cmnd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int id = Convert.ToInt32(reader[0].ToString());
        //            string? ingredients = reader[1].ToString();
        //            string? description = reader[2].ToString();
        //            string? owner = reader[3].ToString();
        //        }
        //        reader.Close();

        //        //return new Recipe(id);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        CloseDBConnection();
        //    }
        //}

        public bool RemoveRecipe(RecipeDTO recipe)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                string delete = $"DELETE FROM Recipe WHERE id = {recipe.Id}";
                SqlCommand cmnd = new SqlCommand(delete, connection);

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

        public static byte[] ImageToByte2(System.Drawing.Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                if (img != null)
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }
        public bool SaveRecipe(RecipeDTO recipe)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                string saveRecipe = $"INSERT into Recipe (ingredients,description,owner,image, name) VALUES ('{recipe.Ingredients}','{recipe.Description}','{recipe.Owner}',CONVERT(varbinary(MAX), @image), '{recipe.Name}')";
                SqlCommand cmnd = new SqlCommand(saveRecipe, connection);
                cmnd.Parameters.AddWithValue("@image", ImageToByte2((recipe.Image)));


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
        public bool UpdateRecipe(RecipeDTO recipe)
        {
            SqlConnection conn = GetDBConnection();
            try
            {
                /*picture = @image */
                string replaceInfo = $"Update Recipe Set ingredients = @ingredients, description = @description, owner = @owner where id = {recipe.Id}";
                SqlCommand cmnd = new SqlCommand(replaceInfo, conn);
                cmnd.Parameters.AddWithValue("@ingredients", recipe.Ingredients);
                cmnd.Parameters.AddWithValue("@description", recipe.Description);
                cmnd.Parameters.AddWithValue("@owner", recipe.Owner);
                //cmnd.Parameters.AddWithValue("@image", recipe.Image);

                conn.Open();
                cmnd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
