using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Order
    {
        private const string DEFAULT_CUSTOMER = "UNDEFINED";
        private string _Customer;
        private List<Book> _Books;

        public Order(string Customer)
        {
            _Customer = Customer;
            _Books = new List<Book>();
        }
        public Order()
            : this(DEFAULT_CUSTOMER) { }
        public Order(Order Source)
        { _Customer = Source.Customer;
            _Books = new List<Book>(Source.Books);
        }
        public void AddBook(Book book)
        { _Books.Add(book); }
        public string Customer { get { return _Customer; } }
        public IReadOnlyCollection<Book> Books { get { return _Books; } }

        public override string ToString()
        {
            return ("This " + _Books.Count + "\t Order is for customer "+_Customer+"\t .");
        }
    }
}
