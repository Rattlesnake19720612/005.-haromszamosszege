using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.haromszamosszege
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy harmadik számot!");
            int szam3 = Convert.ToInt32(Console.ReadLine());
            int osszeg = szam1 + szam2 + szam3;
            Console.WriteLine("A három szám összege: "  +osszeg + "." + "\n");

            Console.ReadKey();
        }
    }
}
