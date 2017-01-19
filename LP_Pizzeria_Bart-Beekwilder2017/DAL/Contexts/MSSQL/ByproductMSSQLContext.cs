using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    class ByproductMSSQLContext : IByproduct
    {
        private string ConnectionStr;
        public ByproductMSSQLContext()
        {
            ConnectionStr = MSSQLConnection.ConnectionStr;
        }
        public void Delete(Byproduct byproduct)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "DELETE FROM PZA_Byproduct WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", byproduct.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        public List<Byproduct> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                List<Byproduct> byproducts = new List<Byproduct>();
                connection.Open();
                string query = "SELECT * FROM PZA_Byproduct;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Byproduct byproduct = new Byproduct(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToDouble(reader["CostPrice"])
                             , Convert.ToDouble(reader["SellPrice"])
                             , Convert.ToInt32(reader["TaxPercentage"]));
                    byproducts.Add(byproduct);
                }
                connection.Close();
                return byproducts;
            }
        }

        public void Insert(Byproduct byproduct)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "INSERT INTO PZA_Byproduct (Name, CostPrice, SellPrice, TaxPercentage) "
                               + "VALUES (@Name, @CostPrice, @SellPrice, @TaxPercentage)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", byproduct.Name);
                cmd.Parameters.AddWithValue("@CostPrice", Convert.ToString(byproduct.CostPrice));
                cmd.Parameters.AddWithValue("@SellPrice", Convert.ToString(byproduct.SellPrice));
                cmd.Parameters.AddWithValue("@TaxPercentage", Convert.ToString(byproduct.TaxPercentage));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
