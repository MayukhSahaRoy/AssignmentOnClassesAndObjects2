using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects2
{
    class Students
    {
        public string Rollno;
        public string StudName;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;

        public Students(string Studname, string Rollno, double MarksInEng, double MarksInMaths, double MarksInScience)
        {
            this.StudName = StudName;
            this.Rollno = Rollno;
            this.MarksInEng = MarksInEng;
            this.MarksInMaths = MarksInMaths;
            this.MarksInScience = MarksInScience;
        }

        public void display()
        {
            double total = MarksInEng + MarksInMaths + MarksInScience;
            double per = total / 3;
            Console.WriteLine("The total marks of the student is: " + total);
            Console.WriteLine("The percentage of the student is: " + per);
        }
    }
    class Students_Test
    {
        static void Main()
        {
            Console.WriteLine("Enter the name, roll number and marks in English, Maths and Science of first student");
            string s1 = Console.ReadLine();
            string r1 = Console.ReadLine();
            double me1 = double.Parse(Console.ReadLine());
            double mm1 = double.Parse(Console.ReadLine());
            double ms1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name, roll number and marks in English, Maths and Science of second student");
            string s2 = Console.ReadLine();
            string r2 = Console.ReadLine();
            double me2 = double.Parse(Console.ReadLine());
            double mm2 = double.Parse(Console.ReadLine());
            double ms2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name, roll number and marks in English, Maths and Science of third student");
            string s3 = Console.ReadLine();
            string r3 = Console.ReadLine();
            double me3 = double.Parse(Console.ReadLine());
            double mm3 = double.Parse(Console.ReadLine());
            double ms3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name, roll number and marks in English, Maths and Science of fourth student");
            string s4 = Console.ReadLine();
            string r4 = Console.ReadLine();
            double me4 = double.Parse(Console.ReadLine());
            double mm4 = double.Parse(Console.ReadLine());
            double ms4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name, roll number and marks in English, Maths and Science of fifth student");
            string s5 = Console.ReadLine();
            string r5 = Console.ReadLine();
            double me5 = double.Parse(Console.ReadLine());
            double mm5 = double.Parse(Console.ReadLine());
            double ms5 = double.Parse(Console.ReadLine());
            Students p1 = new Students(s1, r1, me1, mm1, ms1);
            Students p2 = new Students(s2, r2, me2, mm2, ms2);
            Students p3 = new Students(s3, r3, me3, mm3, ms3);
            Students p4 = new Students(s4, r4, me4, mm4, ms4);
            Students p5 = new Students(s5, r5, me5, mm5, ms5);
            Students[] list = new Students[5] { p1, p2, p3, p4, p5 };
            foreach (Students p in list)
                p.display();
            Console.ReadKey();
        }
    }
}
