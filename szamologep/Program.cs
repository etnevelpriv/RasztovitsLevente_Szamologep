using System;

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
            Console.WriteLine("Lehetőségek: '+' '-' '/' '*' '%' '^' ");
            Console.WriteLine("Elvégezndő művelet jele: ");
            string muvelet = Console.ReadLine();
            return muvelet;
        }

        static double Osszeadas(double szam1, double szam2)
        {
            return szam1 + szam2;
        }

        static double Kivonas(double szam1, double szam2)
        {
            return szam1 - szam2;
        }

        static double Osztas(double szam1, double szam2)
        {
            return szam1 / szam2;
        }
        static double Szorzas(double szam1, double szam2)
        {
            return szam1 * szam2;
        }
        static double Szazalek(double szam1, double szam2)
        {
            return szam1 % szam2;
        }
        static double Hatvanyozas(double szam1, double szam2)
        {
            return Math.Pow(szam1, szam2);
        }

        static string Indit()
        {
            while (true)
            {
                Console.WriteLine("Szeretné elindítani a programot? (Igen/Nem)");
                string valasz = Console.ReadLine().ToLower();
                if (valasz == "igen")
                {
                    return valasz;
                }
                else
                {
                    Console.WriteLine("Hibás válasz!");
                }
            }
        }

        static void Main(string[] args)
        {
            double szam1 = Elso_Szam();
            double szam2 = Masodik_Szam();
            string muvelet = Muvelet_Kivalasztasa();
            string valasz = Indit();

            Console.WriteLine($"Az első szám: {szam1}");
            Console.WriteLine($"A második szám: {szam2}");

            if (muvelet == "+")
            {
                Console.WriteLine($"Az összeg: {Osszeadas(szam1, szam2)}");
            }
            else if (muvelet == "-")
            {
                Console.WriteLine($"A különbség: {Kivonas(szam1, szam2)}");
            }
            else if (muvelet == "/")
            {
                Console.WriteLine($"Az osztás eredménye: {Osztas(szam1, szam2)}");
            }
            else if (muvelet == "*")
            {
                Console.WriteLine($"A szorzás eredménye: {Szorzas(szam1, szam2)}");
            }
            else if (muvelet == "%")
            {
                Console.WriteLine($"A százaékos osztás eredménye: {Szazalek(szam1, szam2)}");
            }
            else if (muvelet == "^")
            {
                Console.WriteLine($"A hatványozás eredménye: {Hatvanyozas(szam1, szam2)}");
            }
            else
            {
                Console.WriteLine("Hibás művelet!");
            }
        }
    }
}
