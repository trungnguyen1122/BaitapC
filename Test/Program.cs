using System;
using System.Collections;

namespace Test
{
    class Program
    {
        public int age =21;
        public static int year = 2019;
        private const int century = 21;
        public static void Main(string[] args)
        {
            
                Console.WriteLine("Hello World!");
                Program mc = new Program();
                Console.WriteLine("age: "+ mc.age);
                Console.WriteLine("year: "+ Program.year);
                Console.WriteLine("century: "+ Program.century);
                
                
                Console.WriteLine("Nhap n");
                int n = Console.Read();
                Console.ReadLine();
                Console.WriteLine("Nhap 1 chuoi");
                string str = Console.ReadLine();
                Console.WriteLine("Nhap 1 so thuc");
                float f = float.Parse(Console.ReadLine());




        }
    }
}