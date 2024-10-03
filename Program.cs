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
            Console.WriteLine("Nhap A:");
                A = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B:");
                B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }
            B--;
            for (int i = B; i >= A; i--)
            {  
                Console.WriteLine(i); 
            }
            Console.ReadLine();
        }
    }
}
