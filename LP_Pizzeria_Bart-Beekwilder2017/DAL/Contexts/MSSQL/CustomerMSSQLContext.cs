using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    class CustomerMSSQLContext : ICustomer
    {

        private string ConnectionStr;
        public CustomerMSSQLContext()
        {
            ConnectionStr = MSSQLConnection.ConnectionStr;
        }
        public Customer GetByID(int ID)
        {
            Customer customer;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "SELECT * FROM PZA_Customer WHERE ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(ID));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                customer = new Customer(Convert.ToInt32(reader["ID"])
                             , Convert.ToString(reader["Name"])
                             , Convert.ToString(reader["Residence"])
                             , Convert.ToString(reader["Street"])
                             , Convert.ToInt32(reader["Housenumber"]));
                reader.Close();
                connection.Close();
                return customer;
            }
        }

        public void Insert(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "INSERT INTO PZA_Customer (Name, Recidence, Street, Housenumber) "
                               + "VALUES (@Name, @Residence, @Street, @Housenumber)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Residence", customer.Residence);
                cmd.Parameters.AddWithValue("@Street", customer.Street);
                cmd.Parameters.AddWithValue("@Housenumber", Convert.ToString(customer.Housenumber));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
