class Lasagna
{
    private const int timeInOven = 40; //minutes in oven according to cookbook
    private const int layerTime = 2; //minutes per layer
    public Lasagna()
    {
            
    }
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return timeInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesElapsed)
    {
        return timeInOven - minutesElapsed;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {

        return layers * layerTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesElapsed)
    {
        return (layers * layerTime) + minutesElapsed;
    }
}
