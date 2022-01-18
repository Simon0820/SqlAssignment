using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class UpdateCustomer : AddCustomer
    {

        public void UpdateName()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set ContactName = '{Name}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateCompany()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set CompanyName = '{Company}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateTitle()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set ContactTitle = '{Title}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateAddress()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set Address = '{Address}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateCity()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set City = '{City}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdatePostalcode()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set PostalCode = '{PostalCode}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateCountry()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set Country = '{Country}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdatePhone()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=(local)\\SQLEXPRESS;Initial Catalog=Northwind32;Integrated Security=SSPI");
                SqlCommand sc = new SqlCommand($"update Customers set Phone = '{Phone}' where CustomerID = '{CustID}'", con);
                con.Open();
                sc.ExecuteNonQuery();
                Console.WriteLine("\nUpdated Successfully\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSomething is wrong here\n" + e);
            }
            finally
            {
                con.Close();
            }
        }


        /* SqlCommand sc = new SqlCommand($"update Customers set ContactName = '{Name}', CompanyName = '{Company}', ContactTitle = '{}', " +
            $"Address = '{}', City = '{}', PostalCode = '{}', Country = '{}', phone = '{}'"); */


    }
}
