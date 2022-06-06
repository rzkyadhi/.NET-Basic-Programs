using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Publication
    {
        public string Title { get; }
        public string Publisher { get; }
        public string PublicationType { get; }

        private int _totalPages;

        public int Pages 
        { 
            get { return _totalPages; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "the pages cannot negative");
                }
                _totalPages = value;
            }
        
        }

        public Publication(string title, string publisher, string publicationType)
        {
            if (title == null) throw new ArgumentNullException(nameof(title), "title cannot be null");
            else if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(nameof(title), "title cannot null or having empty string");
            Title = title;

            if (publisher == null) throw new ArgumentNullException(nameof(publisher), "publisher cannot be null");
            else if (string.IsNullOrWhiteSpace(publisher)) throw new ArgumentException(nameof(publisher), "publisher cannot null or having empty string");
            Publisher = publisher;

            if (publicationType == null) throw new ArgumentNullException(nameof(publicationType), "publication type cannot be null");
            else if (string.IsNullOrWhiteSpace(publicationType)) throw new ArgumentException(nameof(publicationType), "publication type cannot null or having empty string");
            PublicationType = publicationType;
        }
    }
}
