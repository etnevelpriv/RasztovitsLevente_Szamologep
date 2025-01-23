using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    internal class Program
    {

        static double Elso_Szam()
        {
            Console.Write("Kérem adja meg az első számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            return szam;
        }

        static double Masodik_Szam()
        {
            Console.Write("Kérem adja meg a második számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            return szam;
        }

        static void Main(string[] args)
        {
            double szam1 = Elso_Szam();
            double szam2 = Masodik_Szam();

            Console.WriteLine($"Az első szám: {szam1}");
            Console.WriteLine($"A második szám: {szam2}");

        }

    }
}
