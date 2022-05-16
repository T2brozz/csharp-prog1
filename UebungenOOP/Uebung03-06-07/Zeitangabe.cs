namespace UebungenOOP;

public class Zeitangabe
{
    private int _hours;
    private int _minutes;
    private int _seconds;
    public int Days { get; set; }
    public int Hours
    {
        get => _hours;
        set
        {
            if (value > 23)
            {
                Days++;
                Hours = value - 24;
            }
            else if (value < 0)
            {
                Days--;
                Hours = value + 24;
            }
            else
            {
                _hours = value;
            }
        }
    }
    public int Minutes
    {
        get => _minutes;
        set
        {
            if (value > 59)
            {
                Hours++;
                Minutes = value - 60;
            }
            else if (value < 0)
            {
                Hours--;
                Minutes = value + 60;
            }
            else
            {
                _minutes = value;
            }
        }
    }
    public int Seconds
    {
        get => _seconds;
        set
        {
            if (value > 59)
            {
                Minutes++;
                Seconds = value - 60;
            }
            else if (value < 0)
            {
                Minutes--;
                Seconds = value + 60;
            }
            else
            {
                _seconds = value;
            }
        }
    }

    public Zeitangabe(int days, int hours, int minutes, int seconds)
    {
        Days = days;
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public static Zeitangabe operator +(Zeitangabe z1, Zeitangabe z2)
    {
        return new Zeitangabe(z1.Days + z2.Days, z1.Hours + z2.Hours, z1.Minutes + z2.Minutes, z1.Seconds + z2.Seconds);
    }

    //minus operator
    public static Zeitangabe operator -(Zeitangabe z1, Zeitangabe z2)
    {
        return new Zeitangabe(z1.Days - z2.Days, z1.Hours - z2.Hours, z1.Minutes - z2.Minutes, z1.Seconds - z2.Seconds);
    }

    //inkrement seconds
    public static Zeitangabe operator ++(Zeitangabe z)
    {
        return new Zeitangabe(z.Days, z.Hours, z.Minutes, z.Seconds + 1);
    }

    //dekrement seconds
    public static Zeitangabe operator --(Zeitangabe z)
    {
        return new Zeitangabe(z.Days, z.Hours, z.Minutes, z.Seconds - 1);
    }

    //print 
    public override string ToString()
    {
        return $"{Days} days {Hours} hours {Minutes} minutes {Seconds} seconds";
    }
}