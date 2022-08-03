namespace TimeConversion;

static class TimeConversion
{
    public static void Main(string[] args)
    {
        string? s = Console.ReadLine();
        string? result = TimeConvert(s);

        Console.WriteLine(result);
    }


    private static string? TimeConvert(string? s)
    {
        if (s != null && !s.Any() && s.Length == 10) return "";

        string? convertedTime = s?.Substring(0, 8);
        int hour = Int16.Parse(s?.Substring(0, 2) ?? string.Empty);
        bool isDay = s.Substring(8, 2).ToLower().Equals("am");
        bool addTwelve = !isDay && hour != 12;
        bool subTwelve = isDay && hour == 12;

        if (addTwelve)
        {
            return $"{(hour + 12).ToString()}{convertedTime?.Substring(2, 6)}";
        }

        if (subTwelve)
        {
            return $"0{(hour - 12).ToString()}{convertedTime?.Substring(2, 6)}";
        }

        return convertedTime;
    }
}