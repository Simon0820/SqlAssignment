using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class ShowCountrySales : AddCustomer
    {

        public void Show() 
        {
            SqlConnection con = null;
            try 
            {

                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand cm = new SqlCommand("select TotalSell = sum(UnitPrice), EmployeeID from [Order Details] as od " +
                    "join Orders on od.OrderID = Orders.OrderID " +
                    $"where ShipCountry = '{CountrySale}' " +
                    "group by EmployeeID " +
                    "order by TotalSell DESC", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();

                Console.WriteLine("\nTotalSell / EmployeeID");

                while (sdr.Read()) 
                {
                    Console.WriteLine(sdr["TotalSell"] + " / " + sdr["EmployeeID"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong\n" + e);
            }
            finally 
            {
                con.Close();
            } 
        }

    }
}
