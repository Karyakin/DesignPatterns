namespace Observer.Weather.Region;

public class MoskowWeather: IWeatherDisplay
{

    private string _moskow;

    public void Update(object sender, WeatherEventArgs args)
    {
        _moskow = args.Moskow;
        Display();
    }
    
    public void Display()
    {
        Console.WriteLine(_moskow);
    }
}