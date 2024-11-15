namespace CloneVolume;

public class Calculate
{

    public void CalculateCone()
    {
        try
        {
            string input = Console.ReadLine();

            string[] split = input.Split(' ');

            double R = double.Parse(split[0]);

            double L = double.Parse(split[1]);

            if (R > 1_000_000 || L > 1_000_000)
            {
                throw new OverflowException();
            }

            else if (R < 0 || L < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            else if (L < R)
            {
                throw new InvalidOperationException();
            }

            double h = Math.Sqrt((L * L) - (R * R));

            if (h < 0)
            {
                throw new InvalidOperationException();
            }

            double pi = Math.PI;

            double volume = (1.0 / 3) * pi * (R * R) * h;

            double a = Math.Floor(volume);

            double b = Math.Ceiling(volume);

            if (0 > a || a > b)
            {
                throw new InvalidOperationException();
            }
            
            
            Console.WriteLine($"{a} {b}");
            
        }
        catch (OverflowException)
        {
            Console.WriteLine("wartość parametrów jest zbyt duża");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("obiekt nie istnieje");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("ujemny argument");
        }
    }
}
