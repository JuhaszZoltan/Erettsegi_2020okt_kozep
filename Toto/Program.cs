using System;
using System.Collections.Generic;
using System.IO;

namespace Toto
{
    class Program
    {
        static List<Fordulo> fordulok;
        static void Main()
        {
            F02();
            F03();
            F04();
            F05();
            F06();
            F08();
            Console.ReadKey(true);
        }

        private static void F02()
        {
            fordulok = new List<Fordulo>();
            var sr = new StreamReader(@"..\..\Forras\toto.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                fordulok.Add(new Fordulo(sr.ReadLine()));
            }
            sr.Close();
        }
        private static void F03()
        {
            Console.WriteLine($"3. feladat: Fordulók száma: {fordulok.Count}");
        }
        private static void F04()
        {
            var sum = 0;
            foreach (var f in fordulok)
            {
                sum += f.Telitalalat;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {sum} db");
        }
        private static void F05()
        {
            long sum = 0;
            int db = 0;
            foreach (var f in fordulok)
            {
                if (f.Telitalalat > 0)
                {
                    db++;
                    sum += f.Telitalalat * f.Nyeremeny;
                }
            }
            //a minta az így néz ki:
            Console.WriteLine($"5. feladat: Átlag: {sum / fordulok.Count} Ft");
            //de a feladat szövege nem ezt kéri:
            //Console.WriteLine($"5. feladat: Átlag: {db / fordulok.Count} Ft");
        }
        private static void F06()
        {
            Console.WriteLine("6. feladat:");

            var talalatos = new List<Fordulo>();
            foreach (var f in fordulok) if (f.Nyeremeny != 0) talalatos.Add(f);
            int mini = 0;
            int maxi = 0;
            for (int i = 1; i < talalatos.Count; i++)
            {
                if (talalatos[i].Nyeremeny < talalatos[mini].Nyeremeny)
                    mini = i;
                if (talalatos[i].Nyeremeny > talalatos[maxi].Nyeremeny)
                    maxi = i;
            }

            Console.WriteLine("\tLegnagyobb:");
            Console.WriteLine($"\tÉv: {talalatos[maxi].Ev}");
            Console.WriteLine($"\tHét: {talalatos[maxi].Het}.");
            Console.WriteLine($"\tForduló: {talalatos[maxi].Sorszam}.");
            Console.WriteLine($"\tTelitalálat: {talalatos[maxi].Telitalalat} db");
            Console.WriteLine($"\tNyeremény: {talalatos[maxi].Nyeremeny} Ft");
            Console.WriteLine($"\tEredménye: {talalatos[maxi].Eredmenyek}");

            Console.WriteLine("\n\tLegkisebb:");
            Console.WriteLine($"\tÉv: {talalatos[mini].Ev}");
            Console.WriteLine($"\tHét: {talalatos[mini].Het}.");
            Console.WriteLine($"\tForduló: {talalatos[mini].Sorszam}.");
            Console.WriteLine($"\tTelitalálat: {talalatos[mini].Telitalalat} db");
            Console.WriteLine($"\tNyeremény: {talalatos[mini].Nyeremeny} Ft");
            Console.WriteLine($"\tEredménye: {talalatos[mini].Eredmenyek}");
        }
        private static void F08()
        {
            int i = 0;
            while (i < fordulok.Count && !new EredmenyElemzo(fordulok[i].Eredmenyek).NemvoltDontetlenMerkozes)
            {
                i++;
            }
            Console.WriteLine($"8. feladat : {(i < fordulok.Count ? "V" : "Nem v")}olt döntetlen nélküli forduló");
        }
    }
}