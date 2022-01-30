using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects2
{
    class Person
    {
        public string Firstname;
        public string Lastname;
        public string Emailaddress;
        public long dateofbirth;

        public Person(string Firstname, string Lastname, string Emailaddress, long dateofbirth)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Emailaddress = Emailaddress;
            this.dateofbirth = dateofbirth;
        }

        public Person(string Firstname, string Lastname, string Emailaddress)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Emailaddress = Emailaddress;
        }

        public Person(string Firstname, string Lastname, long dateofbirth)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.dateofbirth = dateofbirth;
        }
         public void display()
        {
            Console.WriteLine("The first name is: " + Firstname);
            Console.WriteLine("The last name is: " + Lastname);
            Console.WriteLine("The Email address is: " + Emailaddress);
            Console.WriteLine("The Date of Birth is: " + dateofbirth);
        }

    }

    class Person_Test
    {
        static void Main()
        {
            Console.WriteLine("Enter first name, last name, email address and date of birth of person:");
            string Firstname = Console.ReadLine();
            string Lastname = Console.ReadLine();
            string Emailaddress = Console.ReadLine();
            long dateofbirth = long.Parse(Console.ReadLine());
            Person p1 = new Person(Firstname,Lastname,Emailaddress,dateofbirth);
            Person p2 = new Person(Firstname, Lastname, Emailaddress);
            Person p3 = new Person(Firstname, Lastname, dateofbirth);
            p1.display();
            p2.display();
            p3.display();
            Console.ReadKey();
        }
    }
}
