using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a -= 1;
            Console.WriteLine(a);
            int b = 5;
            b *= 3;
            Console.WriteLine(b);
            Console.WriteLine(a == b);
            bool Logic1 = a != b;
            bool Logic2 = (a %= 2) == 0;
            Console.WriteLine(Logic1 && Logic2 );
            Console.WriteLine(b != a);
            Console.ReadLine();
        }
    }
}
