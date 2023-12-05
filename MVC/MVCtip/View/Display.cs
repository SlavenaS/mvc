using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtip.View
{
    class Display
    {
        public double Amount { get; private set; }
        public double Persent { get; private set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }

        public void Input()
        {
            Console.Write("enter amount of meal:");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("enter persent:");
            Persent = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("----------------------");
            //Console.WriteLine("++++++++++++++++++++++");
            Console.WriteLine($"your tip is:{TipAmount:C}!!!");
            Console.WriteLine("+_____________________");
            Console.WriteLine("the total is:{0:C}!!!",Total);
        }
    }
}
