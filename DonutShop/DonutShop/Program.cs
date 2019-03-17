using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Donut Shop");

            // make a donut
            Donut d1 = new Donut("glazed");
            Donut d2 = new Donut("cake");
            Donut d3 = new Donut("Cronut");
            Donut d4 = new Donut("cAkE");
            Donut d5 = new Donut("Fritter");

            // Instancate a new Sack
            Sack sack1 = new Sack(6);
            // add some donuts to the sack
            sack1.AddDonut(d1);
            sack1.AddDonut(d2);
            sack1.AddDonut(d3);
            sack1.AddDonut(d4);
            sack1.AddDonut(d5);

            Sack sack2 = new Sack();
            sack2.AddDonut(d1);  // 7 donuts in the second sack should get a discount
            sack2.AddDonut(d2);
            sack2.AddDonut(d3);
            sack2.AddDonut(d4);
            sack2.AddDonut(d5);
            sack2.AddDonut(d5);
            sack2.AddDonut(d5);


            // print the bill
            Console.WriteLine(sack1.PrintBill());
            Console.WriteLine();
            Console.WriteLine(sack2.PrintBill());



            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);


            // no sack yet but least way I can make some donuts


            // wait for the return
            Console.ReadLine();
        }
    }
}
