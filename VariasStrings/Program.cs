using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "\t olá! \"\u00A9\"";
            string s2 = @"\t olá! ""\u00A9""";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
