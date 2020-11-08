using oop.sutawee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        public static void Main(string[] args)
        {
             Sneakers mySneakers = new Sneakers();
             mySneakers.Brand();
             mySneakers.Color();
             mySneakers.Price();
             Slippers mySlippers = new Slippers();
             mySlippers.Brand();
             mySlippers.Color();
             mySlippers.Price();  //ถ้ากด start ไม่ขึ้น กด Ctrl+F5
        }
    }

