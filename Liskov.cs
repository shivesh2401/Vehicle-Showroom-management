+using System;

namespace Liskov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public interface Icust      

    {

        void read();

        void print();

    }

    public class Customer : Icust
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
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Icust c1 = new Customer();               //liskov substitution
            c1.read();
            c1.print();
        }
    }

}
