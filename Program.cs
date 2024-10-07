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
            Dem();
                Console.ReadLine();
        }
        static void Dem() 
        {
            int A;    
            Console.WriteLine("Nhap A");
                A = int.Parse(Console.ReadLine());
            for (int i = 0; i <= A; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
