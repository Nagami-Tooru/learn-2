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
                Console.WriteLine("Chon phep tinh:");
                Console.WriteLine("1:Cong");
                Console.WriteLine("2:Tru");
                Console.WriteLine("3:Nhan");
                Console.WriteLine("4:Chia");
            int So;
                    So = int.Parse(Console.ReadLine());

            switch (So)
                {
                    case 1:
                        So = A + B;
                        Console.WriteLine($"Tong AB la:{So}");
                    break;
                    case 2:
                        So = A - B;
                    Console.WriteLine($"Hieu AB la:{So}");
                    break;
                    case 3:
                        So = A * B;
                        Console.WriteLine($"Tich AB la:{So}"); 
                    break;
                    case 4:
                        So = A / B;
                        Console.WriteLine($"Thuong AB la:{So}");
                    break;
                }
            Console.ReadLine();
        }
    }
}
