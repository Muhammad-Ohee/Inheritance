//Console.WriteLine("Hello, OS");

using System.Net;
using System.Xml.Linq;

namespace IsAAndHasA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee HAS-A Address Relationship
            Address address = new Address("Joggonathpur", "Sylhet", "Sylhet-Division");
            Employee employee = new Employee(4, "OS", address);
            employee.Display();

            /*
            // Address IS-A Employee Relationship
            Employee employee = new Employee(4, "OS", "Joggonathpur", "Sylhet", "Sylhet-Division");
            employee.Display();
            */
        }
    }

    class Address
    {
        public string AddressLine, City, State;

        public Address(string address, string city, string state)
        {
            AddressLine = address;
            City = city;
            State = state;
        }
    }

    
    // Employee HAS-A Address Relationship
    class Employee
    {
        public int Id;
        public string Name;
        Address Address;
        public Employee(int id, string name, Address address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Address: {Address.AddressLine}");
            Console.WriteLine($"Employee City: {Address.City}");
            Console.WriteLine($"Employee State: {Address.State}");
        }
    }


    /*
    // Address IS-A Employee Relationship
    class Employee : Address 
    {
        public int Id;
        public string Name;

        public Employee(int id, string name, string address, string city, string state) : base(address, city, state)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Address: {AddressLine}");
            Console.WriteLine($"Employee City: {City}");
            Console.WriteLine($"Employee State: {State}");
        }
    }
    */
}