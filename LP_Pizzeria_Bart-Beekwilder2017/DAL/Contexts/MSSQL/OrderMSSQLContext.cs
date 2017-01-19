using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    public class OrderMSSQLContext : IOrder
    {
        private string ConnectionStr;
        public OrderMSSQLContext()
        {
            ConnectionStr = MSSQLConnection.ConnectionStr;
        }

        public void Insert(Order order)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                string query = "INSERT INTO Order (CustomerID) "
                               + "VALUES (@CustomerID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                if(order.Customer != null)
                {
                    cmd.Parameters.AddWithValue("@SellPrice", Convert.ToString(order.Customer.ID));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SellPrice", Convert.ToString(DBNull.Value));
                }
                cmd.ExecuteNonQuery();

                query = "select IDENT_CURRENT('PZA_Order') AS ID";
                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int orderID = Convert.ToInt32(reader["ID"]);
                reader.Close();

                foreach (Byproduct byproduct in order.Byproducts)
                {
                    query = "INSERT INTO PZA_OrderByproduct (OrderID, ByproductID) "
                                   + "VALUES (@OrderID, @ByproductID)";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@OrderID", Convert.ToString(orderID));
                    cmd.Parameters.AddWithValue("@ByproductID", Convert.ToString(byproduct.ID));
                    cmd.ExecuteNonQuery();
                }

                foreach (Pizza pizza in order.Pizzas)
                {
                    query = "INSERT INTO PZA_OrderPizza (OrderID, PizzaID) "
                                   + "VALUES (@OrderID, @PizzaID)";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@OrderID", Convert.ToString(orderID));
                    cmd.Parameters.AddWithValue("@PizzaID", Convert.ToString(pizza.ID));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
