using System;

namespace Intseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public interface Ioldcust            //interface segragation

    {

        void read1();

        void print1();

    }

    public interface Inewcust        //interface segragation
    {

        void read2();

        void print2();
    }

    public class Customer : Ioldcust, Inewcust
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

        public void read1()
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

        public void print1()
        {

            Console.WriteLine("****Customer Details****");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer Gender: " + gender);
            Console.WriteLine("Customer Address:- \nCity: " + city + "\nState: " + state + "\nCountry: " + country);
            Console.WriteLine("Customer Phone Number: " + phone);
        }

        public void read2()
        {
            Console.WriteLine("Enter new customer details: ");
            Console.WriteLine("Enter Customer age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer department: ");
            dep = Console.ReadLine();

        }

        public void print2()
        {

            Console.WriteLine("**** Updated Customer Details****");
            Console.WriteLine("Customer Age: " + age);
            Console.WriteLine("Customer Department: " + dep);
           
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            Ioldcust c1 = new Customer();       
            Inewcust c2 = new Customer();     
            c1.read1();
            c1.print1();
            c2.read2();
            c2.print2();
        }
    }

}
