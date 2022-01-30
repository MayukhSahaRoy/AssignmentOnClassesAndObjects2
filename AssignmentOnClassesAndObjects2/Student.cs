using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects2
{
    class Student
    {
        public string Rollno;
        public string StudName;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;

        public Student()
        {
            Console.WriteLine("Enter the name of the student:");
            StudName = Console.ReadLine();
            Console.WriteLine("Enter the roll number:");
            Rollno = Console.ReadLine();
            Console.WriteLine("Enter the marks in English:");
            MarksInEng = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Maths:");
            MarksInMaths = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Science:");
            MarksInScience = double.Parse(Console.ReadLine());
        }

        public void display()
        {
            double total = MarksInEng + MarksInMaths + MarksInScience;
            double per = total / 3;
            Console.WriteLine("The total marks of the student is: " + total);
            Console.WriteLine("The percentage of the student is: " + per);
        }
    }

    class Student_Test
    {
        static void Main()
        {
            Student p1 = new Student();
            p1.display();
            Console.ReadKey();
        }
    }
}
