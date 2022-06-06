// See https://aka.ms/new-console-template for more information

namespace Inheritance
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Book harryPotta = new("Harry Poah", "Harry", "Book", "Po ah");
            harryPotta.Pages = 20;

            Book theTempest = new("The Tempest", "Temp", "Book", "Pest");
            theTempest.Pages = 20;
        }
    }
}
