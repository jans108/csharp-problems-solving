using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // wczytaj dane
            string sidesOfTriangle = Console.ReadLine();
            string[] sidesSplited = sidesOfTriangle.Split(';');

            for (int i = 0; i < sidesSplited.Length; i++)
            {
                sidesSplited[i] = sidesSplited[i].Trim();
            }

            var sideA = double.Parse(sidesSplited[0]);
            var sideB = double.Parse(sidesSplited[1]);
            var sideC = double.Parse(sidesSplited[2]);


            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                return;
            }

            else if (sideA + sideB < sideC || sideB + sideC < sideA || sideA + sideC < sideB)
            {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                return;
            }
            // i wykonaj obliczenia

            double obwód = sideA + sideB + sideC;
            Math.Round(obwód, 2);

            double s = obwód / 2;
            double calc = (s * (s - sideA) * (s - sideB) * (s - sideC));
            double pole = Math.Sqrt(calc);
            Math.Round(pole, 2);

            double sideAToSquare = sideA * sideA;
            double sideBToSquare = sideB * sideB;
            double sideCToSquare = sideC * sideC;


            string typ = string.Empty;

            if (sideAToSquare + sideBToSquare == sideCToSquare || sideBToSquare + sideCToSquare == sideAToSquare || sideAToSquare + sideCToSquare == sideBToSquare)
            {
                typ = "prostokątny";
            }

            else if (sideAToSquare + sideBToSquare > sideCToSquare && sideBToSquare + sideCToSquare > sideAToSquare && sideAToSquare + sideCToSquare > sideBToSquare)
            {
                typ = "ostrokątny";
            }

            else
            {
                typ = "rozwartokątny";
            }

            Console.WriteLine($"obwód = {obwód:F2}");
            Console.WriteLine($"pole = {pole:F2}");
            Console.WriteLine($"trójkąt jest {typ}");

            if (sideA ==  sideB && sideB == sideC)
                Console.WriteLine("trójkąt równoboczny");

            else if (sideA == sideB || sideB == sideC || sideA == sideC)
                Console.Write("trójkąt równoramienny");
        }
    }
}