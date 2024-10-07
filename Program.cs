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
            int a;
            int b;
            Console.WriteLine("Nhap A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B:");
            b = int.Parse(Console.ReadLine());
            int Tich;
            AB(a, b);
            Console.ReadLine();
        }
        static int AB(int a, int b)
        {
            int Tich = a * b;
            Console.WriteLine($"Tich AB:{Tich}");
            return Tich;
        }

    }
}
