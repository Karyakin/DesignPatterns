namespace Observer.News;

public class NewsEventArgs
{
    public NewsEventArgs(string twitter, string lenta, string tv)
    {
        Twitter = twitter;
        Lenta = lenta;
        Tv = tv;
    }
    public string Twitter { get; set; }
    public string Lenta { get; set; }
    public string Tv { get; set; }
}