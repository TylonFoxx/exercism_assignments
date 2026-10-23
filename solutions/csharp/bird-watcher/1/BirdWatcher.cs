using System.Linq;
class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
        return this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[this.birdsPerDay.Length - 1] = this.birdsPerDay[this.birdsPerDay.Length - 1] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        return this.birdsPerDay.Any(x=> x == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return this.birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return this.birdsPerDay.Where(x=> x >= 5).Count();
    }
}
