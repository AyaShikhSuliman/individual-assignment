using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RecipeSuggestionInfoDAL : BaseDAL, IRecipeSuggestionInformation
    {
        public RecipeSuggestionDTO GetRecipeByID(int id)
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            SqlConnection connection = GetDBConnection();

            try
            {
                connection.Open();
                string sql = $"SELECT * FROM RecipeSuggestion where RecipeSuggestion.id = {id}";
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
                    recipeDTO.Name = reader[4].ToString();
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

        public List<RecipeSuggestionDTO> GetRecipes()
        {
            List<RecipeSuggestionDTO> recipes = new List<RecipeSuggestionDTO>();
            SqlConnection connection = GetDBConnection();
            try
            {
                connection.Open();
                string sql = "SELECT * FROM RecipeSuggestion";
                SqlCommand cmnd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmnd.ExecuteReader();
                while (reader.Read())
                {
                    RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
                    recipeDTO.Id = Convert.ToInt32(reader[0].ToString());
                    recipeDTO.Ingredients = reader[1].ToString();
                    recipeDTO.Description = reader[2].ToString();
                    if (reader[3] is not DBNull)
                    {
                        recipeDTO.Owner = reader[3].ToString();
                    }
                    recipeDTO.Name = reader[4].ToString();
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

        public bool RemoveRecipe(RecipeSuggestionDTO recipe)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                string delete = $"DELETE FROM RecipeSuggestion WHERE id = {recipe.Id}";
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

        public bool SaveRecipe(RecipeSuggestionDTO recipe)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                string saveRecipe = $"INSERT into RecipeSuggestion (ingredients,description,owner,name) VALUES ('{recipe.Ingredients}','{recipe.Description}','{recipe.Owner}','{recipe.Name}')";
                SqlCommand cmnd = new SqlCommand(saveRecipe, connection);
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
