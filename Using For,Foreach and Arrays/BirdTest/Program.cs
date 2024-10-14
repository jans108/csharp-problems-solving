using System;

class BirdCount
{
    //Solving problems associated with using loops and arrays

    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };

        return birdsLastWeek;
    }

    public int Today() =>  birdsPerDay[6];
    

    public void IncrementTodaysCount()
    {
        birdsPerDay[6] = birdsPerDay[6] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var bird in birdsPerDay)
        {
            if (bird == 0)
                return true;
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        birdsPerDay = birdsPerDay[..numberOfDays];
        int birdAmount = 0;

        foreach (var bird in birdsPerDay)
        {
            birdAmount += bird;
        }

        return birdAmount;
    }

    public int BusyDays()
    {
        int amountOfBusyDays = 0;

        foreach (var day in birdsPerDay)
        {
            if (day >= 5)
                amountOfBusyDays++;
        }

        return amountOfBusyDays;
    }
}
