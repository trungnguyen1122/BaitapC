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
         
            List<Product> product1 = new List<Product>();
            List<Product> product2 = new List<Product>();
            MobilePhone mobile1 = new MobilePhone(1,"Samsung s10",2.3,"FlashShip");
            MobilePhone mobile2 = new MobilePhone(2,"Iphone X",2.3,"Number1");
            MobilePhone mobile3 = new MobilePhone(3,"Numia a7",3.3,"Very Bad");
            Book book1 = new Book(1, "ABC 123", 4.0, "Sack");
            Book book2 = new Book(2, "Exam 123", 9.0, "Sack");
            Book book3 = new Book(2, "DarkSoul", 5.0, "Sack");
            product1.Add(mobile1);
            product1.Add(mobile2);
            product1.Add(mobile3);
            product2.Add(book1);
            product2.Add(book2);
            product2.Add(book3);

            
        }
    }
}
