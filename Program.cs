using System;

namespace MethodenRückgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int ausgabeZahl = Addition(10, 5);
            Console.WriteLine(ausgabeZahl);
            int ausgabeZahl2 = Substraktion(20, 4);
            Console.WriteLine(ausgabeZahl2);
            int ausgabeZahl3 = Multiplikation(20, 4);
            Console.WriteLine(ausgabeZahl3);
            int ausgabeZahl4 = Division(20, 4);
            Console.WriteLine(ausgabeZahl4);
            Console.ReadKey();
        }
        static int Addition(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }
        static int Substraktion(int zahl3, int zahl4)
        {
            int ergebnis2 = zahl3 - zahl4;
            return ergebnis2;
        }
        static int Multiplikation(int zahl5, int zahl6)
        {
            int ergebnis3 = zahl5 * zahl6;
            return ergebnis3;
        }
        static int Division(int zahl7, int zahl8)
        {
            int ergebnis4 = zahl7 / zahl8;
            return ergebnis4;
        }
    }
}
