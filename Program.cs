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
            int D;
            Console.WriteLine("Nhap A:");
                A = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
                B = int.Parse(Console.ReadLine());
            D = A;
            C = (D %= 3);
            switch (C)
            {
                case 0:
                    for (int i = A; i <= B; i += 3)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 1:
                    A += 2;
                    for (int i = A; i <= B; i += 3)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 2:
                    A += 1;
                    for (int i = A; i <= B; i += 3)
                    {
                        Console.WriteLine(i);
                    }
                    break;
            }
           Console.ReadLine();
            
            
        }
    }
}
