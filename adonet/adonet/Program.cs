using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class Program
    {
        static void Main(string[] args) 
        {

            bool option = true;
            do
            {
                Console.WriteLine("Hey, what do you want to do?:" +
                    "\n1. Add Customer." +
                    "\n2. Delete Customer." +
                    "\n3. Update Customer." +
                    "\n4. Read countries sales." +
                    "\n5. Make an order." +
                    "\n6. Delete OrderCustomer" +
                    "\n0. Exit Application.\n");
                int answer = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (answer) 
                {
                    case 1:
                        Console.WriteLine("What's your full name?:");
                        string name = Console.ReadLine();
                        Console.WriteLine("What's your companyname?:");
                        string company = Console.ReadLine();
                        Console.WriteLine("What's your jobtitle?:");
                        string title = Console.ReadLine();
                        Console.WriteLine("What country do you live in?:");
                        string country = Console.ReadLine();
                        Console.WriteLine("What city do you live in?:");
                        string city = Console.ReadLine();
                        Console.WriteLine("What address do you have?:");
                        string address = Console.ReadLine();
                        Console.WriteLine("What's your postalcode?:");
                        int postalcode = int.Parse(Console.ReadLine());
                        Console.WriteLine("What's your phonenumber?: (Only Numbers please)");
                        int phone = int.Parse(Console.ReadLine());
                        Console.WriteLine("What CustomerID do you want?: in this format (ABCDEFG)");
                        string id = Console.ReadLine();

                        AddCustomer addcustomer = new AddCustomer();
                        addcustomer.Name = name;
                        addcustomer.Company = company;
                        addcustomer.Title = title;
                        addcustomer.Country = country;
                        addcustomer.City = city;
                        addcustomer.Address = address;
                        addcustomer.PostalCode = postalcode;
                        addcustomer.Phone = phone;
                        addcustomer.ID = id;
                        addcustomer.Add();
                        break;

                    case 2:
                        Console.WriteLine("Please enter the CustomerID to delete:");
                        string custID = Console.ReadLine();

                        DeleteCustomer deletecustomer = new DeleteCustomer();
                        deletecustomer.CustID = custID;
                        deletecustomer.Delete();
                        break;

                    case 3:

                        Console.WriteLine("What's your CustomerID?");
                        string cID = Console.ReadLine();
                        UpdateCustomer updatecustomer = new UpdateCustomer();
                        updatecustomer.CustID = cID;
                        Console.WriteLine("\nWhat do you want to update?:\n" + 
                            "1. Name\n" + "2. Companyname\n" + "3. Job title\n" + "4. Country\n" + 
                            "5. City\n" + "6. Address\n" + "7. Postalcode\n" + "8. Phonenumber\n" + 
                            "Choose number between 1-8\n");
                        int x = int.Parse(Console.ReadLine());

                        Console.Clear();
                        if (x == 1) 
                        {
                            Console.WriteLine("What do you want to change your name to?");
                            string Nachange = Console.ReadLine();
                            updatecustomer.Name = Nachange;
                            updatecustomer.UpdateName();
                        }
                        else if (x == 2) 
                        {
                            Console.WriteLine("What do you want to change your Companyname to?");
                            string CNchange = Console.ReadLine();
                            updatecustomer.Company = CNchange;
                            updatecustomer.UpdateCompany();
                        }
                        else if (x == 3)
                        {
                            Console.WriteLine("What do you want to change your Jobtitle to?");
                            string Tchange = Console.ReadLine();
                            updatecustomer.Title = Tchange;
                            updatecustomer.UpdateTitle();
                        }
                        else if (x == 4)
                        {
                            Console.WriteLine("What do you want to change your country to?");
                            string COchange = Console.ReadLine();
                            updatecustomer.Country = COchange;
                            updatecustomer.UpdateCountry();
                        }
                        else if (x == 5)
                        {
                            Console.WriteLine("What do you want to change your city to?");
                            string CTchange = Console.ReadLine();
                            updatecustomer.City = CTchange;
                            updatecustomer.UpdateCity();
                        }
                        else if (x == 6)
                        {
                            Console.WriteLine("What do you want to change your address to?");
                            string Achange = Console.ReadLine();
                            updatecustomer.Address = Achange;
                            updatecustomer.UpdateAddress();
                        }
                        else if (x == 7)
                        {
                            Console.WriteLine("What do you want to change your postalcode to?");
                            int PCchange = int.Parse(Console.ReadLine());
                            updatecustomer.PostalCode = PCchange;
                            updatecustomer.UpdatePostalcode();
                        }
                        else if (x == 8)
                        {
                            Console.WriteLine("What do you want to change your phonenumber to?");
                            int PHchange = int.Parse(Console.ReadLine());
                            updatecustomer.Phone = PHchange;
                            updatecustomer.UpdatePhone();
                        }
                        else 
                        {
                            Console.WriteLine("Only 1-8 is accepted\n");
                        }

                        break;

                    case 4:
                        ShowCountrySales showcountry = new ShowCountrySales();
                        Console.WriteLine("Which countries total sales do you wish to see? IN FORMAT (Sweden)");
                        string Csale = Console.ReadLine();
                        showcountry.CountrySale = Csale;
                        showcountry.Show();
                        Console.WriteLine("\n\nenter to continue\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        AddOrder addorder = new AddOrder();
                        addorder.OrderAdd();
                        break;

                    case 6:
                        AddOrder deleteorder = new AddOrder();
                        deleteorder.DeleteOrderCustomer();
                        break;

                    case 0:
                        option = false;
                        break;
                }
            }
            while (option);


            
         //AddCustomer addcustomer = new AddCustomer();
         //addcustomer.Hello();
         //Console.ReadKey();
            


            Console.ReadLine();
        }



    }
}
