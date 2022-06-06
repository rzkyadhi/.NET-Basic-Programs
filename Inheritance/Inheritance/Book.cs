using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public sealed class Book : Publication
    {
        public string Author { get; set; }
        public Book(string title, string publisher, string publicationType, string author) : base(title, publisher, publicationType) {
            Author = author;
        }

        public override string ToString() => $"Book title is {Title}, publisher is {Publisher}, publicationType is {PublicationType}, and the author is {Author}";
    }
}
