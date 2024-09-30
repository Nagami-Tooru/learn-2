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
            int So;
            Console.WriteLine("Nhap so tu 1 den 9:");
                So = int.Parse(Console.ReadLine());
            if (So >= 0 & So <= 9) 
            {
                switch (So)
                {
                    case 0:
                        Console.WriteLine("So khong");
                        break;
                    case 1:
                        Console.WriteLine("So mot");
                        break;
                    case 2:
                        Console.WriteLine("So hai");
                        break;
                    case 3:
                        Console.WriteLine("So ba");
                        break;
                    case 4:
                        Console.WriteLine("So bon");
                        break;
                    case 5:
                        Console.WriteLine("So nam");
                        break;
                    case 6:
                        Console.WriteLine("So sau");
                        break;
                    case 7:
                        Console.WriteLine("So bay");
                        break;
                    case 8:
                        Console.WriteLine("So tam");
                        break;
                    case 9:
                        Console.WriteLine("So chin");
                        break;
                }
            }


            else
                {
                    Console.WriteLine("Sai");
                }
            Console.ReadLine();
            
        }
    }
}
