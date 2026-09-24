public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    // Constructors
    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
        NormalizeTime();
    }

    public Duration(int totalSeconds)
    {
        Hours = totalSeconds / 3600;
        int remainingSeconds = totalSeconds % 3600;
        Minutes = remainingSeconds / 60;
        Seconds = remainingSeconds % 60;
    }

    // Normalization Method to ensure valid time representation
    private void NormalizeTime()
    {
        int totalSeconds = (Hours * 3600) + (Minutes * 60) + Seconds;
        Hours = totalSeconds / 3600;
        int remainingSeconds = totalSeconds % 3600;
        Minutes = remainingSeconds / 60;
        Seconds = remainingSeconds % 60;
    }

    // Override Object Members
    public override string ToString()
    {
        if (Hours > 0)
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        return $"Minutes :{Minutes}, Seconds :{Seconds}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Duration d)
            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Hours, Minutes, Seconds);

    // Helpers for operator overloading
    private int TotalSeconds => (Hours * 3600) + (Minutes * 60) + Seconds;

    // Operator Overloading
    public static Duration operator +(Duration d1, Duration d2)
    {
        return new Duration(d1.TotalSeconds + d2.TotalSeconds);
    }

    public static Duration operator +(Duration d, int seconds)
    {
        return new Duration(d.TotalSeconds + seconds);
    }
    
    public static Duration operator +(int seconds, Duration d) // 666 + D3
    {
        return new Duration(d.TotalSeconds + seconds);
    }

    public static Duration operator -(Duration d1, Duration d2)
    {
        return new Duration(Math.Max(0, d1.TotalSeconds - d2.TotalSeconds));
    }

    // Increase/Decrease One Minute (60 Seconds)
    public static Duration operator ++(Duration d)
    {
        return new Duration(d.TotalSeconds + 60);
    }

    public static Duration operator --(Duration d)
    {
        return new Duration(Math.Max(0, d.TotalSeconds - 60));
    }

    public static bool operator >(Duration d1, Duration d2) => d1.TotalSeconds > d2.TotalSeconds;
    public static bool operator <(Duration d1, Duration d2) => d1.TotalSeconds < d2.TotalSeconds;
    public static bool operator >=(Duration d1, Duration d2) => d1.TotalSeconds >= d2.TotalSeconds;
    public static bool operator <=(Duration d1, Duration d2) => d1.TotalSeconds <= d2.TotalSeconds;

    // Implicit bool cast (If (D1))
    public static implicit operator bool(Duration d)
    {
        return d.TotalSeconds > 0; // True if duration is not zero
    }

    // Explicit DateTime cast
    public static explicit operator DateTime(Duration d)
    {
        // Creates a DateTime object starting at minimum value but adding the duration
        return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
    }
}