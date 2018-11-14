using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The planet";
            string str2 = "Arrakis:";
            string str3 = "Known as Dune";

            string concat = str1 + " " + str2 + " " + str3;
            Console.WriteLine("Concatting a string can be done in two ways:");
            Console.WriteLine("Like so: " + concat);
            Console.WriteLine("or so: " + str1 + " " + str2 + " " + str3);

            Console.WriteLine("To go Upper: " + concat.ToUpper());

            var paragraph = new StringBuilder();

            Console.WriteLine("\n\nAnd StringBuilder:");
            paragraph.Append("Land of sand.");
            paragraph.Append("Home of the spice melange.");
            paragraph.Append("The spice controls the empire");
            paragraph.Append("Whoever controls Dune, controls the spice.");

            Console.WriteLine(paragraph);

            Console.Read();
        }
    }
}
