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
            int Choose;
            string Ten;
            int Tuoi;
            string DiaChi;
            Console.WriteLine("Nhap ten:");
                Ten = Console.ReadLine();
                
            Console.WriteLine("Nhap tuoi:");
                Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Dia chi:");
                DiaChi = Console.ReadLine(); 
            Console.WriteLine("1.Ten");
            Console.WriteLine("2.Tuoi");
            Console.WriteLine("3.Dia Chi");
                Choose = int.Parse(Console.ReadLine());
            switch (Choose)
            {
                case 1:
                    Console.WriteLine($"Ten la: {Ten}");
                    break;
                case 2:
                    Console.WriteLine($"{Tuoi} tuoi");
                    break;
                case 3:
                    Console.WriteLine($"Dia chi la: {DiaChi}");
                    break;
                default:
                    Console.WriteLine("Vui long chon lai");
                    break;
            }
            Console.ReadLine();
        }
    }
}
