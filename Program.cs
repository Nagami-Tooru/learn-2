using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input;
            Console.WriteLine($"Nhap diem Toan:");
            Input = Console.ReadLine();
            string a = Input;
            Console.WriteLine($"Nhap diem Van:");
            Input = Console.ReadLine();
            string b = Input;
            Console.WriteLine($"Nhap diem Anh:");
            Input = Console.ReadLine();
            string c = Input;
            int A = int.Parse(a);
            int B = int.Parse(b);
            int C = int.Parse(c);
            A *= 3; B *= 3; C *= 2;
            float d = A + B + C;
            d /= 8;
            Console.WriteLine($"Diem trung binh 3 mon la: {d}");
            Console.ReadLine();


        }
    }
}
