using LusciousLasagna;
using System.Text;

int lasagnaTime = 0;

Lasagna lasagna = new(lasagnaTime);

StringBuilder sb = new();
sb.AppendLine($"Expected time in oven: {lasagna.ExpectedMinutesInOven()}");
sb.AppendLine();
sb.AppendLine($"Remaining minutes in oven: {lasagna.RemainingMinutesInOven(15)}");
sb.AppendLine();
sb.AppendLine($"Preparation time in minutes: {lasagna.PreparationTimeInMinutes(4)}");
sb.AppendLine();
sb.AppendLine($"Elapsed time in oven: {lasagna.ElapsedTimeInMinutes(4, 6)}");

Console.WriteLine($"{sb}");
