using PolinomNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var polinom = new Polinom(1, 1, -5, 20, 6.6, -76, 7, 738);
            var polinom2 = new Polinom(0, 50, 4, 3, -5, 19, 6.5, -76, 57, 78);


            Console.WriteLine(polinom.ToString());
            Console.WriteLine(polinom2.ToString());
            Console.WriteLine("=========================================================");
            var pol = polinom - polinom2;

            Console.WriteLine(pol.ToString());
            Console.WriteLine(polinom.ToString());
            Console.WriteLine(polinom2.ToString());


            Console.WriteLine("=========================================================");

            var pol2 = polinom + polinom2;
            Console.WriteLine(polinom.ToString());
            Console.WriteLine(polinom2.ToString());
            Console.WriteLine(pol2.ToString());

            Console.ReadLine();

        }
    }
}
