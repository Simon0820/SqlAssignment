using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class AddOrder : AddCustomer
    {

        
        public void OrderAdd() 
        {

            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");

                //Adding new Customer
                SqlCommand sc = new SqlCommand($"insert into Customers " +
                    $"(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone)" +
                    $" values ('ADAD', 'McDonalds', 'Simon', 'Owner', 'Gatan 2', 'Gothenburg', '53452', 'Sweden', '0725438910')", con);

                //Insert Orderinfo for customer above
                SqlCommand sc2 = new SqlCommand($"insert into Orders (CustomerID, EmployeeID, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipCountry, ShipPostalCode) " +
                    $"values ('ADAD', '5', '2', '130', 'McDonalds', 'FrulundaGatan', 'Gothenburg', 'Sweden', '53450')", con); 

                SqlCommand red = new SqlCommand($"select OrderID from Orders where CustomerID = 'ADAD'", con);


                con.Open();
                sc.ExecuteNonQuery();
                sc2.ExecuteNonQuery();

                SqlDataReader sdr = red.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["OrderID"]);
                }
                con.Close();

                Console.WriteLine("\nType your OrderID here: (The Number Above)\nRemember the number for removal later");
                int number = int.Parse(Console.ReadLine());

                con.Open();

                //Insert OrderDetails for customer above
                SqlCommand sc3 = new SqlCommand($"insert into [Order Details] (OrderID, ProductID, Quantity, Discount) " +
                    $"values ('{number}', '14', '9', '0')", con);
                sc3.ExecuteNonQuery();
                Console.WriteLine("\nAdded Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nDid not work\n\n" + e);
            }
            finally
            {
                con.Close();
            }
        }
        
        public void DeleteOrderCustomer()
        {
            SqlConnection con = null;
            try
            {
                Console.WriteLine("Enter your OrderID");
                int OdId = int.Parse(Console.ReadLine());
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");

                SqlCommand sc = new SqlCommand($"delete from [Order Details] where OrderID = '{OdId}'", con);
                SqlCommand sc2 = new SqlCommand($"delete from Orders where OrderID = '{OdId}'", con);
                SqlCommand sc3 = new SqlCommand($"delete from Customers where CustomerID = 'ADAD'", con);

                con.Open();
                sc.ExecuteNonQuery();
                sc2.ExecuteNonQuery();
                sc3.ExecuteNonQuery();
                Console.WriteLine("\nDeleted Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong\n\n" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
