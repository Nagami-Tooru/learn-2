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
            int B;
            int C;
                Console.WriteLine("Nhap A:");
                    A = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap B:");
                    B = int.Parse(Console.ReadLine());
            while (B <= A)
            {
                Console.WriteLine("Nhap lai");
                    Console.WriteLine("A:");
                A = int.Parse(Console.ReadLine());
                    Console.WriteLine("B:");
                B = int.Parse(Console.ReadLine());
            }
            C = A % 3;
            while (C != 0)
            {
                A++;
                C = A % 3;
            }
            while (B >= A)
            {
                Console.WriteLine(A);
                A = A + 3;
            }
            Console.ReadLine();
        }
    }
}
