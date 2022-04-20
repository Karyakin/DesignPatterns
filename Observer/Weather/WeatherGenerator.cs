namespace Observer.Weather;

public class WeatherGenerator
{
    
    private static Random _random;

    public WeatherGenerator()
    {
        _random = new Random();
    }
    
    public string GetMinsk()
    {
        var minskWeather = new List<string>
        {
            "Minsk: 21 градус тепла",
            "Minsk: 33 градуса тепла",
            "Minsk: 15 градусов тепла"
        };
        return minskWeather[_random.Next(3)];
    }

    public string GetMoskow()
    {
        var moskowWeather = new List<string>
        {
            "Minsk: 21 градус тепла",
            "Minsk: 33 градуса тепла",
            "Minsk: 15 градусов тепла"
        };
        return moskowWeather[_random.Next(3)];
    }
    
    public string GetPiter()
    {
        var piterWeather = new List<string>
        {
            "Minsk: 21 градус тепла",
            "Minsk: 33 градуса тепла",
            "Minsk: 15 градусов тепла"
        };
        return piterWeather[_random.Next(3)];
    }

    public delegate void WeatherChangeEventHandler(object sender, WeatherEventArgs e);

    public event WeatherChangeEventHandler WeatherChanged;


    public void WeatherAvaileble()
    {
        var moskowWeater = GetMoskow();
        var minskWeather = GetMinsk();
        var piterWeather = GetPiter();

        WeatherChanged(this, new WeatherEventArgs(moskowWeater, minskWeather, piterWeather));
    }
    
    

}