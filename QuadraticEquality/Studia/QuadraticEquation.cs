using System.Globalization;

namespace Studia
{
    public class QuadraticEq
    {


        public static void QuadraticEquation(int a, int b, int c)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("infinity");
                return;
            }

            double x1;
            double x2;

            double delta = (b * b) - (4 * a * c);
            double pierwiastekZDelty = Math.Sqrt(delta);

            double aRazyDwa = 2 * a;

            if (delta < 0 || aRazyDwa == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            else if (delta > 0)
            {

                x1 = (-b - pierwiastekZDelty) / (aRazyDwa);

                x2 = (-b + pierwiastekZDelty) / (aRazyDwa);

                x1 = Math.Round(x1, 2);
                x2 = Math.Round(x2, 2);

                Console.WriteLine($"{nameof(x1)}={x1:F2}");
                Console.WriteLine($"{nameof(x2)}={x2:F2}");
            }
            else if (delta == 0)
            {
                x1 = -b / (aRazyDwa);

                x1 = Math.Round(x1, 2);

                Console.WriteLine($"x={x1:F2}");
            }

        }
    }
}