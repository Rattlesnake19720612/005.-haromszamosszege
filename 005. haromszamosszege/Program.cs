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

/*Ez a kód a következőket csinálja soronként:

Az System névtér importálása.
Egy saját névtér (namespace) definiálása, amelyben a kódunk található.
Egy Program osztály definiálása.
Az osztályon belül egy Main függvény definiálása, amely a program belépési pontja.
Kiírja a képernyőre a "Kérek egy számot!" üzenetet.
Beolvas egy egész számot a felhasználótól, majd eltárolja az értékét a szam1 változóban.
Kiírja a képernyőre a "Kérek még egy számot!" üzenetet.
Beolvas egy másik egész számot a felhasználótól, majd eltárolja az értékét a szam2 változóban.
Kiírja a képernyőre a "Kérek egy harmadik számot!" üzenetet.
Beolvas egy harmadik egész számot a felhasználótól, majd eltárolja az értékét a szam3 változóban.
Az osszeg változóba eltárolja a három szám összegét.
Kiírja a képernyőre az összeget, egy szöveggel kiegészítve.
Várakozás a felhasználó billentyűleütésére a továbblépéshez.*/
