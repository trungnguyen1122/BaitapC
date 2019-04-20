using System;
using System.Collections;
namespace asm
{
    public class asm
    {
          public static void Main(string[] args)
                {
                     int n1 = 0, n2 = 1, trm, i, n;
        
                    Console.Write("\n");
                    Console.Write("In day Fibonacci trong C#:\n\n");
        
                    Console.Write("Nhap so phan tu can hien thi: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Day Fibonacci gom {0} phan tu la: \n", n);
                    Console.Write("{0}    {1}", n1, n2);
        
                    for (i = 3; i <= n; i++)
                    {
                        trm = n1+ n2;
                        Console.Write("  {0}  ", trm);
                        n1 = n2;
                        n2 = trm;
                    }
                    Console.Write("\n");   
        
                    Console.ReadKey();
                }
    }
}
