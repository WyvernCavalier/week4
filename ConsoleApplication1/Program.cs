using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static List<BookStock> Stocking = new List<BookStock>();

        static void Main(string[] args)
        {
            Book AoS = new Book("K. C. Jennins", "Age of Shames", "Supremacy Press", 1988);
            Book ToB = new Book("L. Riley", "Tales of Bravery", "Eresis", 1993);
            Book TLG = new Book("Albert K. Asasaki", "The last glimpse", "Mosaic United", 2006);
            Order Order_A = new Order();
            Order_A.AddBook(AoS);
            Order Order_B = new Order("Kent");
            Order_B.AddBook(ToB);
            Order Order_C = new Order(Order_A);
            Order_C.AddBook(ToB);

            Display_Order(Order_A);
            Console.WriteLine();
            Display_Order(Order_B);
            Console.WriteLine();
            Display_Order(Order_C);

            Stocking.Add(new BookStock(AoS, new decimal(19.99), 5));
            Stocking.Add(new BookStock(ToB, new decimal(14.99), 202));
            Stocking.Add(new BookStock(TLG, new decimal(34.99), 5));

        }

        static void Display_Order(Order order) { Console.WriteLine(order);
            foreach (Book x in order.Books)
                Console.WriteLine(x);
            
        }
        static void Produce_Report (){
            Console.WriteLine(new string('#',40));
            Console.WriteLine("#" + "quantity" + "\t#" + "Title" + "(" + "Year" + ")" + "\t#" + "price" + "\t#");
            Console.WriteLine(new string('#', 40));
            foreach (BookStock x in Stocking)
                Console.WriteLine(x);
            Console.WriteLine(new string('#', 40));


        }

    }
}
