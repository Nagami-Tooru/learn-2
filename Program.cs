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
            string Ten;
            int Tuoi;
            string thongTin;
            Console.WriteLine("Nhap ten");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap tuoi");
            Tuoi = int.Parse(Console.ReadLine());
            thongTin = Ten + Tuoi;
            ThongTin(thongTin);
            Console.ReadLine();
        }
        static string ThongTin(string thongTin)
            {
            Console.WriteLine(thongTin);
            return Console.ReadLine();
            }
    }
}
