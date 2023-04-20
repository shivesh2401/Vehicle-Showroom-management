using System;

namespace Dec
{
    abstract class Customer
    {
        public int id;
        public String name;
        public String gender;
        public String city;
        public String state;
        public String country;
        public long phone;

        public abstract void read_details();

        public abstract void print_details();
    }

    class ConcreteCustomer : Customer
    {
        public override void read_details()
        {
            Console.WriteLine("Enter Customer id: ");
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
            Console.WriteLine("Enter country: ");
            country = Console.ReadLine();
            Console.WriteLine("Enter customer phone number: ");
            phone = Convert.ToInt64(Console.ReadLine());
        }

        public override void print_details()
        {
            Console.WriteLine("****Customer Deatails****");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }
    }

    abstract class Decorator : Customer
    {
        protected Customer _customer;

        public void setCustomer(Customer customer)
        {
            this._customer = customer;
        }

        public override void read_details()
        {
            if (_customer != null)
            {
                _customer.read_details();
            }
        }

        public override void print_details()
        {
            if (_customer != null)
            {
                _customer.print_details();
            }
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        public override void read_details()
        {
            base.read_details();
            addedBehaviorA();
        }

        public void addedBehaviorA()
        {
            Console.WriteLine("Enter new customer details: ");
            Console.WriteLine("Enter new customer id: ");
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
            Console.WriteLine("Enter country: ");
            country = Console.ReadLine();
            Console.WriteLine("Enter customer phone number: ");
            phone = Convert.ToInt64(Console.ReadLine());
        }

        public override void print_details()
        {
            base.print_details();
            addedBehaviorB();
        }

        public void addedBehaviorB()
        {
            Console.WriteLine("**New Customer Details**");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);

        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCustomer c = new ConcreteCustomer();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
          
            d1.setCustomer(c);
            d1.read_details();
            d1.print_details();
        }
    }
}
