using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book
    {
        private string _Author;
        private string _Title;
        private string _Publisher;
        private Int32 _Year;

        public Book(string Author,string Title, string Publisher, Int32 Year )
        {
            _Author = Author;
            _Title = Title;
            _Publisher = Publisher;
            _Year = Year;
        }

        public string Author { get { return _Author; } }
        public string Title { get { return _Title; } }
        public string Publisher { get { return _Publisher; } }
        public Int32 Year { get { return _Year; } }

        public override string ToString()
        {
            return (_Author+"\t"+_Title+"\t"+_Publisher+"\t"+Year);

        }
    }
}
