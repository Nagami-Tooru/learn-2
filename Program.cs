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
            Console.WriteLine("Nhap 1 so");
            A = int.Parse(Console.ReadLine());
            if (A >= 0 && A <= 9)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{A}X{i}={A * i}");
                }

            }
            else { }
            Console.ReadLine();
        }
    }
}
