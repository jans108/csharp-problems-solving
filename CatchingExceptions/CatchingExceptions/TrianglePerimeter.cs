namespace CatchingExceptions;

internal class TrianglePerimeter1
{
    public static double TrianglePerimeter(int a, int b, int c, int precision = 2)
    {
        if (precision < 2 || precision > 8 || a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentOutOfRangeException("wrong arguments");
        }

        if ((a + b <= c || a + c <= b || b + c <= a) && a > 0 && b > 0 && c > 0)
        {
            throw new ArgumentException("object not exist");
        }

        var perimeter = a + b + c;

        return perimeter;
    }
}
