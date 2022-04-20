namespace Observer.Weather;

public class WeatherEventArgs
{
    public string Minsk { get; set; }
    public string Moskow { get; set; }
    public string Piter { get; set; }
    
    public WeatherEventArgs(string minsk, string moskow, string piter)
    {
        Minsk = minsk;
        Moskow = moskow;
        Piter = piter;
    }
}