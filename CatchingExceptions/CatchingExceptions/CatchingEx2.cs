namespace CatchingExceptions;

internal class CatchingEx2
{
    public void Catch()
    {
        try
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();

            int aParsed = int.Parse(a);
            int bParsed = int.Parse(b);
            int cParsed = int.Parse(c);

            long multiply = (long)aParsed * (long)bParsed * (long)cParsed;

            if (multiply > int.MaxValue || multiply < int.MinValue)
            {
                throw new OverflowException();
            }

            int result = aParsed * bParsed * cParsed;

            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("format exception, exit");
        }
        catch (OverflowException)
        {
            Console.WriteLine("overflow exception, exit");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("argument exception, exit");
        }
        catch (Exception)
        {
            Console.WriteLine("non supported exception, exit");
        }
    }
}
