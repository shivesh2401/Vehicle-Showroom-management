using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Factory
{
    public abstract class Customer
    {
        public abstract void read();
        public abstract void print();
        public abstract void service();
    }
    public class OldCustomer : Customer
    {
        public int id;
        public String name;
        public String gender;
        public String city;
        public String state;
        public String country;
        public long phone;
        public override void read()
        {
            Console.WriteLine("Enter old customer details: ");
            Console.WriteLine("Enter customer id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter customer gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter customer address: ");
            Console.WriteLine("Enter city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter state: ");
            state = Console.ReadLine();
            Console.WriteLine("Enter country");
            country = Console.ReadLine();
            Console.WriteLine("Enter customer phone number: ");
            phone = Convert.ToInt64(Console.ReadLine());
        }

        public override void print()
        {
            Console.WriteLine("***** Old Customer Details *****");
            Console.WriteLine("Customer Id: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }

        public override void service() 
        {
            Console.WriteLine("Same services to be provided to the old customers...");
        }
    }
    public class NewCustomer : Customer
    {
        public int id;
        public String name;
        public String gender;
        public String city;
        public String state;
        public String country;
        public long phone;
        public override void read()
        {
            Console.WriteLine("Enter new Customer Details: ");
            Console.WriteLine("Enter customer id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter customer gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter customer address: ");
            Console.WriteLine("Enter city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter state: ");
            state = Console.ReadLine();
            Console.WriteLine("Enter country");
            country = Console.ReadLine();
            Console.WriteLine("Enter customer phone number: ");
            phone = Convert.ToInt64(Console.ReadLine());
        }

        public override void print()
        {
            Console.WriteLine("***** New Customer Details *****");
            Console.WriteLine("Customer Id: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }

        public override void service()
        {
            Console.WriteLine("New services to be provided to the new customers...");
        }
    }
    class PremiumCust : Customer
    {
        public int id;
        public override void read()
        {
            Console.WriteLine("Enter the id of the premium customer: ");
            id = Convert.ToInt32(Console.ReadLine());
        }

        public override void print()
        {
            Console.WriteLine("Premium customer id: " + id);
            Console.WriteLine("This customer will receive extra discount.");
        }

        public override void service() 
        {
            Console.WriteLine("Welcome... You will get some extra features");
        }
    }
    class NormalCust : Customer
    {
        public int id;
        public override void read()
        {
            Console.WriteLine("Enter the id of the normal customer: ");
            id = Convert.ToInt32(Console.ReadLine());
        }

        public override void print()
        {
            Console.WriteLine("Normal customer id: " + id);
            Console.WriteLine("This customer will receive no discount.");
        }

        public override void service()
        {
            Console.WriteLine("Stay connected... You will receive the same treatment ");
        }
    }
    public abstract class Cust
    {
        private List<Customer> _customer = new List<Customer>();
        public Cust()
        {
            this.custtype();
        }
        public abstract void custtype();
        public List<Customer> Customers
        {
            get
            {
                return _customer;
            }
        }
    }
    public class Customer1 : Cust
    {
        public override void custtype()
        {
            Customers.Add(new OldCustomer());
            Customers.Add(new NewCustomer());
        }
    }
    public class Customer2 : Cust
    {
        public override void custtype()
        {
            Customers.Add(new OldCustomer());
            Customers.Add(new NewCustomer());
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            Customer c1 = new OldCustomer();
            c1.read();
            c1.print();
            c1.service();
            Customer c2 = new NewCustomer();
            c2.read();
            c2.print(); 
            c2.service();
            Console.WriteLine("Different customers wil be selected for different categories..");
            Customer c3 = new PremiumCust();
            c3.read();
            c3.print();
            c3.service();
            Customer c4 = new NormalCust();
            c4.read();
            c4.print();
            c4.service();
            Cust c5 = new Customer1();
            c5.custtype();
            Cust c6 = new Customer2();
            c6.custtype();
        }
    }
}
