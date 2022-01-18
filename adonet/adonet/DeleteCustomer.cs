using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class DeleteCustomer : AddCustomer
    {

        public void Delete() 
        {
            SqlConnection con = null;
            try 
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"delete from Customers where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nDeleted Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething went wrong here\n" + e);
            }
            finally 
            {
                con.Close();
            }
        }
    }
}
