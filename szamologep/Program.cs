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

        static string Muvelet_Kivalasztasa()
        {
            Console.WriteLine("Lehetőségek: '+' '-' '/' '*' '%' ");
            Console.WriteLine("Elvégezndő művelet jele: ");
            string muvelet = Console.ReadLine();
            return muvelet;
        }

        static void Main(string[] args)
        {
            double szam1 = Elso_Szam();
            double szam2 = Masodik_Szam();
            string muvelet = Muvelet_Kivalasztasa();

            Console.WriteLine($"Az első szám: {szam1}");
            Console.WriteLine($"A második szám: {szam2}");

            if(muvelet == "+")
            {
                Console.WriteLine($"Az összeg: {Osszeadas}");
            }
            else if (Muvelet_Kivalasztasa() == "-")
            {
                Console.WriteLine($"A különbség: {Kulonbseg()}");
            }
            else if (Muvelet_Kivalasztasa() == "/")
            {
                Console.WriteLine($"Az osztás eredménye: {Osztas}");
            }
            else if (Muvelet_Kivalasztasa() == "*")
            {
                Console.WriteLine($"A szorzás eredménye: {Szorzas()}");
            }
            else if (Muvelet_Kivalasztasa() == "%")
            {
                Console.WriteLine($"A százaékos osztás eredménye: {Szazalek()}");
            }
            else
            {
                Console.WriteLine("Hibás művelet!");
            }

        }

    }
}
