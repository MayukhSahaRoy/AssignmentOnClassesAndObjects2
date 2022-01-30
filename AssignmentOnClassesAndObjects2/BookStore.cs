using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects2
{
    class BookStore
    {
        public string isbn;
        public string bookname;
        public string booktitle;
        public string bookauthor;
        public int quantity;
        public double bookprice;

        public BookStore(string isbn, string bookname, string booktitle, string bookauhor, int quantity, double bookprice)
        {
            this.isbn = isbn;
            this.bookname = bookname;
            this.booktitle = booktitle;
            this.bookauthor = bookauthor;
            this.quantity = quantity;
            this.bookprice = bookprice;
        }
    }

    class BookStrore_Test
    {
        static void Main()
        {
            Console.WriteLine("Enter the isbn, name of the book, title, author, quantity and price of the book:");
            string isbn = Console.ReadLine();
            string bookname = Console.ReadLine();
            string booktitle = Console.ReadLine();
            string bookauthor = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double bookprice = double.Parse(Console.ReadLine());
            BookStore p1 = new BookStore(isbn,bookname,booktitle,bookauthor,quantity,bookprice);
            Console.WriteLine("The ISBN of the book is: " + p1.isbn);
            Console.WriteLine("The name of the book is: " + p1.bookname);
            Console.WriteLine("The title of the book is: " + p1.booktitle);
            Console.WriteLine("The author of the book is: " + p1.bookauthor);
            Console.WriteLine("Quantity of books is: " + p1.quantity);
            Console.WriteLine("The price of a book is: " + p1.bookprice);
            Console.WriteLine("The bill amount is: " + (p1.quantity * p1.bookprice));
            Console.ReadKey();
        }
    }
}
