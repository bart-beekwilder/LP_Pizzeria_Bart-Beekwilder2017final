using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    public class PizzaMSSQLContext : IPizza
    {
        private string ConnectionStr;
        public PizzaMSSQLContext()
        {
            ConnectionStr = MSSQLConnection.ConnectionStr;
        }

        public void Delete(Pizza pizza)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "DELETE FROM PZA_Pizza WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", pizza.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        public List<Pizza> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                List<Pizza> pizzas = new List<Pizza>();
                connection.Open();
                string query = "SELECT * FROM PZA_Pizza;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pizza pizza = new Pizza(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToInt32(reader["SurfaceArea"])
                             , Convert.ToInt32(reader["ShapeID"])
                             , Convert.ToBoolean(reader["IsStandard"])
                             , Convert.ToInt32(reader["CrustID"]));
                    pizzas.Add(pizza);
                }
                connection.Close();
                return pizzas;
            }
        }

        public List<Pizza> GetAll(bool isStandard)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                List<Pizza> pizzas = new List<Pizza>();
                connection.Open();
                string query = "SELECT * FROM PZA_Pizza WHERE IsStandard = @IsStandard;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IsStandard", isStandard);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pizza pizza = new Pizza(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToInt32(reader["SurfaceArea"])
                             , Convert.ToInt32(reader["ShapeID"])
                             , Convert.ToBoolean(reader["IsStandard"])
                             , Convert.ToInt32(reader["CrustID"]));
                    pizzas.Add(pizza);
                }
                connection.Close();
                return pizzas;
            }
        }

        public Pizza GetByID(int ID)
        {
            Pizza pizza;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "SELECT * FROM PZA_Pizza WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(ID));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                pizza = new Pizza(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToInt32(reader["SurfaceArea"])
                             , Convert.ToInt32(reader["ShapeID"])
                             , Convert.ToBoolean(reader["IsStandard"])
                             , Convert.ToInt32(reader["CrustID"]));
                reader.Close();
                connection.Close();
                return pizza;
            }
        }

        public void Insert(Pizza pizza)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "INSERT INTO PZA_Pizza (ShapeID, Name, IsStandard, SurfaceArea, CrustID) "
                               + "VALUES (@ShapeID, @Name, @IsStandard, @SurfaceArea, @CrustID);";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ShapeID", Convert.ToString(pizza.Shape + 1));
                cmd.Parameters.AddWithValue("@Name", pizza.Name);
                cmd.Parameters.AddWithValue("@IsStandard", Convert.ToString(pizza.IsStandard));
                cmd.Parameters.AddWithValue("@SurfaceArea", Convert.ToString(pizza.SurfaceArea));
                cmd.Parameters.AddWithValue("@CrustID", Convert.ToString(pizza.Crust.ID));
                cmd.ExecuteNonQuery();

                query = "select IDENT_CURRENT('PZA_Pizza') AS ID";
                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int pizzaID = Convert.ToInt32(reader["ID"]);
                reader.Close();

                foreach (Ingredient ingredient in pizza.Ingredients)
                {
                    query = "INSERT INTO PZA_OrderByproduct (PizzaID, IngredientID) "
                                   + "VALUES (@PizzaID, @IngredientID)";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PizzaID", Convert.ToString(pizzaID));
                    cmd.Parameters.AddWithValue("@IngredientID", Convert.ToString(ingredient.ID));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
