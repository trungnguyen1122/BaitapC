using System;
using System.Collections.Generic;
using System.Text;

namespace asm2
{
    class Product
    {
        int id;
        String name;
        Double price;
        int qty;
        String image;
        String desc;
       List<String> gallery;
        private int count;
      

        public Product(int id, string name, double price, int qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public Product(int v)
        {
        }
        public void getInfor()
        {
            Console.WriteLine("Id :  "+this.id + "Name  : "+this.name+" price   : "+this.price + "Image   : "+this.image + "Desc   : "+this.desc+"glalery   :"+this.gallery
                );
        }
        public void ThongBao()
        {
            if (qty <= 0)
            {
                Console.WriteLine("Hết hàng rồi.");
            }
            else
            {
                Console.WriteLine("Vẫn còn hàng.");
            }
        }
        public void AddGallery(String gallery)
        {
            count = 0;
            if (this.gallery.Count <10)
            {
                this.gallery.Add(gallery);
                Console.WriteLine("Add thành công");
            }else
            {
                foreach (var item in this.gallery)
                {
                    count++;
                    Console.WriteLine("STT :"+count + " - "+item);
                }
                Console.WriteLine("Nhiều ảnh quá rồi bạn muốn xoá cái thứ mấy");

                String stt =  Console.ReadLine();
                this.gallery.RemoveAt(5);
                foreach (var item in this.gallery)
                {
                 
                    Console.WriteLine( item);
                }

            }
        }
    }

}
