using System;

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
                
            
        }
    }
}