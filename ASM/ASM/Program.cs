using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    class Program
    {
        static void Main(string[] args)
        {
            double result=0;
         
            List<Product> product= new List<Product>();

            MobilePhone mobile1 = new MobilePhone(1,"Samsung s10",2.3,"FlashShip");
            MobilePhone mobile2 = new MobilePhone(2,"Iphone X",2.3,"Number1");
            MobilePhone mobile3 = new MobilePhone(3,"Numia a7",3.3,"Very Bad");
            Book book1 = new Book(1, "ABC 123", 4.0, "Sack");
            Book book2 = new Book(2, "Exam 123", 9.0, "Sack");
            Book book3 = new Book(2, "DarkSoul", 5.0, "Sack");
            product.Add(mobile1);
            product.Add(mobile2);
            product.Add(mobile3);
            product.Add(book1);
            product.Add(book2);
            product.Add(book3);
            foreach(Product item in product)
            {
            result += item.price;
            }
            Console.WriteLine(result);
            Console.ReadKey();

            
        }
    }
}
