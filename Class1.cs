using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop.sutawee
{
    internal abstract class Shoes //คลาสรองเท้า
    {
        private string Color;
        public string color
        {
            get { return Color; }
            set { Color = value; } 
        }
        public void Price()
        {
           
        }
        public void Brand()
        {
            
        }
    }
    class Sneakers : Shoes //มีทั้งหมด 2 class
    {
        public void Brand() //Brandของรองเท้าประเภทผ้าใบออกมาแล้ว
        {
            Console.WriteLine("  Adidas");
            Console.WriteLine("  Lacost");
            Console.WriteLine("  Converse");       
        }
        public void Price() //ราคาของรองเท้าผ้าใบ
        {
            Console.WriteLine("2500");
        }
        public void Color() //สีของรองเท้าผ้าใบ 
        {
            Console.WriteLine(" Color Shoes : red");
        }

    }

    class Slippers : Shoes
    {
        public void Brand() //Brandของรองเท้าประเภทเเตะออกมาแล้ว
        {          
            Console.WriteLine("  Adidas");
            Console.WriteLine("  Lacost");
            Console.WriteLine("  Converse");  
        }

        public void Price() //ราคาของรองเท้าเเตะ
        {
            Console.WriteLine("900");
        }
        public void Color() //สีของรองเท้าเเตะ
        {
            Console.WriteLine(" Color Shoes : white ");
        }


    }
}