using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class AddCustomer
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public string ID { get; set; }
        public string CustID { get; set; }
        public string CountrySale { get; set; }
        public int OrderID { get; set; }


        public void Add()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"insert into Customers " +
                    $"(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone)" +
                    $" values ('{ID}', '{Company}', '{Name}', '{Title}', '{Address}', '{City}', '{PostalCode}', '{Country}', '{Phone}')", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nAdded Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nDid not work\n" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
