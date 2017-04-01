using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BookStock
    {
        private Book _book;
        private Int32 _quantity;
        private decimal _price;


        public void import(Int32 count)
        { _quantity += count; }
        public void price_overrid(decimal new_price)
        { _price=new_price; }

        public Book book { get { return _book; } }
        public Int32 quantity { get { return _quantity; } }
        public decimal price { get { return _price; } }

        public BookStock(Book book,decimal price ) { _book = book;
            _price = price;
            _quantity = 0;
        }
        public BookStock(Book book, decimal price,Int32 quantity) { _book = book;
            _price = price;
            _quantity = quantity;
        }

        public override string ToString()
        {
            return ("#"+quantity+"\t#"+book.Title+"("+book.Year+")"+ "\t#"+price+ "\t#");
        }

        }
}
