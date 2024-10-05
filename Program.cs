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
                Console.WriteLine("Nhap so A:");
                    A = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so B:");
                    B = int.Parse(Console.ReadLine());
                C = A;
            while (C < B)
            {
                Console.WriteLine(C);
                    C++;
            }
            while (A <= B) 
            { 
                Console.WriteLine(B);
                B--;
            }
                Console.ReadLine();
        }
    }
}
