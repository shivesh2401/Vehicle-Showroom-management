using System;

namespace Dip
{ 
    public interface ICust
    {
        public float calcSal();
    }

    public class Customer : ICust 
    {
        public int id;
        public String name;
        public String gender;
        public String city;
        public String state;
        public String country;
        public long phone;
        public int age;
        public String dep;
        public float salary;
        public float tax;
        public float TotSal;

        public void read()
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

        public void print()
        {
            Console.WriteLine("****Customer Deatails****");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }

        public float calcSal()
        {
            Console.WriteLine("Enter salary: ");
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tax: ");
            tax = float.Parse(Console.ReadLine());
            TotSal = salary - tax;
            Console.WriteLine("Total salary: " + TotSal);

            return TotSal;
        }
    }

    public class Details
    {
        private ICust _cust;
        public Details(ICust cust)              //constructor injection
        {
            _cust = cust;
        }

        public float getDetails()
        {
            return _cust.calcSal();
        }
    }


    public class Program
    { 

        public static void Main(String[] args)
        {
            Customer c = new Customer();
            Details d = new Details(c);            //dependency injection
            d.getDetails();
        }
    }
}
