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
            var polinom = new Polinom(1, 3, -5, 20, 6.6, -76, 7, 78);
            var polinom2 = new Polinom(1, 3, -5, 20, 6.5, -76, 7, 78);
            Console.WriteLine(polinom.GetHashCode());
            Console.WriteLine(polinom2.GetHashCode());


            Console.ReadLine();

        }
    }
}
