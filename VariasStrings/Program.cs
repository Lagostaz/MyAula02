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
            string s3 = "olá" + "!" + "Adeus" + "!";
            string s4 = "resposta: " + 42;
            s4 += "nao sei";
            string s5 = $"{1 + 1}";
            string s6 = $@"qwerty {4}";
            string s7 = String.Format("Olá {0} no.{1}", "mundo", 3);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}
