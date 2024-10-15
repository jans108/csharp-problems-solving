namespace LusciousLasagna;

public class Lasagna
{
    private int LasagnaTime { get;  }

    public Lasagna(int lasagnaTime)
    {
        LasagnaTime = lasagnaTime;
    }


    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int timeLeft = 40;
        return timeLeft;
    }


    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)
    {
        var timeLeft = ExpectedMinutesInOven() - minutesInOven;
        return timeLeft;
    }


    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        const int layerTimePrep = 2;
        int prepTime = layerTimePrep * numberOfLayers;

        return prepTime;
    }


    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int numberOfMinutesElapsed)
    {
        int layers = PreparationTimeInMinutes(numberOfLayers);

        layers += numberOfMinutesElapsed;

        return layers;
    }
}

