using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę w stopniach Celcjusza");
            double C, F;
            C = Convert.ToDouble(Console.ReadLine());
            F = 32 + 9.0 / 5 * C;
            Console.WriteLine(C + " stoppni Celcjusza to " + F + " stopni Fahrenheita");
            Console.ReadKey();
        }
    }
}
