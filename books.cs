using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class books
    {

        public class Book
        {
            private int bookId; 
            private string title;
            private string author;
            private int no_page;
            private int OGPrice;
            private int vol;
            public double Dprice;

            public Book (int bookId, string title, string author, int no_page, int oGPrice, int vol)
            {
                this.bookId = bookId;
                this.title = title;
                this.author = author;
                this.no_page = no_page;
                OGPrice = oGPrice;
                this.vol = vol;
            }

            public void discount()
            {
                if (no_page > 500)
                {
                    Dprice = OGPrice - (3*(OGPrice * .10));
                }
                else if (no_page > 300)
                {
                    Dprice = OGPrice - (2 * (OGPrice * .10));
                }
                else
                {
                    Dprice = OGPrice - (OGPrice * .10);
                }
            }
            public void showBook()
            {
                Console.WriteLine("bookId: " + bookId);
                Console.WriteLine("book title: " + title);
                Console.WriteLine("book author: " + author);
                Console.WriteLine("no of oages: " + no_page);
                Console.WriteLine("original price: " + OGPrice);
                Console.WriteLine("volume of book: " + vol);
                Console.WriteLine("discount price: " + Dprice);
            }
        }
        public static void Main(string[] args)
        {
            Book b1 = new Book(111,"AAA","aaa",504,2000,2);
            b1.discount();
            b1.showBook();
            Book b2 = new Book(112, "AAB", "aab", 304, 1990, 3);
            b2.discount();

            if (b1.Dprice < b2.Dprice)
            {
                b1.showBook();
            }
            else
            {
                b2.showBook();
            }

        }

    }
}
