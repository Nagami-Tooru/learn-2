using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Nhap A:");
                A = int.Parse(Console.ReadLine());
            for (int i = 3; i <= A; i += 3) 
            { 
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
