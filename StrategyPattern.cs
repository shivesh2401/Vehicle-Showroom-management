using System;
namespace strategydemo
{
    public enum CustomerType
    {
        Old,
        New
    }
    public interface ICustomer
    {
        void read();
        void print();
        void Discount();
    }
    public class OldCustStrategy : ICustomer
    {
        public int id;
        public String name;
        public String gender;
        public String city;
        public String state;
        public String country;
        public long phone;
        
        public void read()
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

        public void print()
        {
            Console.WriteLine("***** Old Customer Details *****");
            Console.WriteLine("Customer Id: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }
        public void Discount()
        {
            Console.WriteLine("Discount of 50% is there for Old Customers.....");
        }
    }
    public class NewCustStrategy : ICustomer
    {
        public int id;
        public String name;
        public String gender;
        public String city;
        public String state;
        public String country;
        public long phone;

        public void read()
        {
            Console.WriteLine("Enter new customer details: ");
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

        public void print()
        {
            Console.WriteLine("***** New Customer Details *****");
            Console.WriteLine("Customer Id: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }
        public void Discount()
        {
            Console.WriteLine("Discount of 25% is there for New Customers.....");
        }
    }
   
    public class Context
    {
        private static Dictionary<CustomerType, ICustomer> strategies = new Dictionary<CustomerType, ICustomer>();
        public void add()
        {
            strategies.Add(CustomerType.Old, new OldCustStrategy());
            strategies.Add(CustomerType.New, new NewCustStrategy());
        }
        public void Discount(CustomerType title)
        {
            strategies[title].read();
            strategies[title].print();
            strategies[title].Discount();
        }
    }
    public class Program
    {
        public static void Main()
        {

            Context n = new Context();
            n.add();
            n.Discount(CustomerType.Old);
        }
    }
}
