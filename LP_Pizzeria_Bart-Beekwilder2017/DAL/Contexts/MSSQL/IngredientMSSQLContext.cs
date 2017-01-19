using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    public class IngredientMSSQLContext : IIngredient
    {
        private string ConnectionStr;
        public IngredientMSSQLContext()
        {
            ConnectionStr = MSSQLConnection.ConnectionStr;
        }
        public void Delete(Ingredient ingredient)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "DELETE FROM PZA_Ingredient WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", ingredient.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        public List<Ingredient> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                connection.Open();
                string query = "SELECT * FROM PZA_Ingredient;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ingredient ingredient = new Ingredient(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToInt32(reader["CostPrice"])
                             , Convert.ToInt32(reader["SellPrice"])
                             , Convert.ToBoolean(reader["IsVegetarian"])
                             , Convert.ToBoolean(reader["IsHalal"]));
                    ingredients.Add(ingredient);
                }
                connection.Close();
                return ingredients;
            }
        }

        public List<Ingredient> GetAllForPizza(int ID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                connection.Open();
                string query = "SELECT I.* FROM PZA_Ingredient I, PZA_PizzaIngredient IP WHERE I.ID = IP.IngredientID AND IP.PizzaID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ingredient ingredient = new Ingredient(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToInt32(reader["CostPrice"])
                             , Convert.ToInt32(reader["SellPrice"])
                             , Convert.ToBoolean(reader["IsVegetarian"])
                             , Convert.ToBoolean(reader["IsHalal"]));
                    ingredients.Add(ingredient);
                }
                connection.Close();
                return ingredients;
            }
        }

        public void Insert(Ingredient ingredient)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "INSERT INTO PZA_Ingredient (Name, CostPrice, SellPrice, IsVegetarian, IsHalal) "
                               + "VALUES (@Name, @CostPrice, @SellPrice, @IsVegetarian, @IsHalal)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", ingredient.Name);
                cmd.Parameters.AddWithValue("@CostPrice", Convert.ToString(ingredient.CostPrice));
                cmd.Parameters.AddWithValue("@SellPrice", Convert.ToString(ingredient.SellPrice));
                cmd.Parameters.AddWithValue("@IsVegetarian", ingredient.IsVegetarian);
                cmd.Parameters.AddWithValue("@IsHalal", ingredient.IsHalal);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
