using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    public class CrustMSSQLContext : ICrust
    {
        private string ConnectionStr;
        public CrustMSSQLContext()
        {
            ConnectionStr = MSSQLConnection.ConnectionStr;
        }
        public void Delete(Crust crust)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "DELETE FROM PZA_Crust WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", crust.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        public List<Crust> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                List<Crust> crusts = new List<Crust>();
                connection.Open();
                string query = "SELECT * FROM PZA_Crust;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Crust crust = new Crust(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToDouble(reader["CostPrice"])
                             , Convert.ToDouble(reader["SellPrice"]));
                    crusts.Add(crust);
                }
                connection.Close();
                return crusts;
            }
        }

        public Crust GetByID(int ID)
        {
            Crust crust;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "SELECT * FROM PZA_Crust WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(ID));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                crust = new Crust(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToInt32(reader["CostPrice"])
                             , Convert.ToInt32(reader["SellPrice"]));
                reader.Close();
                connection.Close();
                return crust;
            }
        }

        public void Insert(Crust crust)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "INSERT INTO PZA_Crust (Name, CostPrice, SellPrice) "
                               + "VALUES (@Name, @CostPrice, @SellPrice)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", crust.Name);
                cmd.Parameters.AddWithValue("@CostPrice", Convert.ToString(crust.CostPrice));
                cmd.Parameters.AddWithValue("@SellPrice", Convert.ToString(crust.SellPrice));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
