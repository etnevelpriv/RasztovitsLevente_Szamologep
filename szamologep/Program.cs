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

        static void Main(string[] args)
        {
            Console.WriteLine($"Az első szám: {Elso_Szam()}");
        }

    }
}
