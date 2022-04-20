using Observer.Widgets;

namespace Observer.News;

public class NewsAggregator
{
    private static Random _random;

    public NewsAggregator()
    {
        _random = new Random();
    }
    public string GetTwitterNews()
    {
        var news = new List<string>
        {
            "Новость из Twitter номер 1",
            "Новость из Twitter номер 2",
            "Новость из Twitter номер 3"
        };
        return news[_random.Next(3)];
    }

    public string GetLentaNews()
    {
        var news = new List<string>
        {
            "Новость из Lenta номер 1",
            "Новость из Lenta номер 2",
            "Новость из Lenta номер 3"
        };
        return news[_random.Next(3)];
    }

    public string GetTvNews()
    {
        var news = new List<string>
        {
            "Новость из Tv номер 1",
            "Новость из Tv номер 2",
            "Новость из Tv номер 3"
        };
        return news[_random.Next(3)];
    }

    
    public delegate void NewsChangeEventsHandler(object sender, NewsEventArgs args);
    public event NewsChangeEventsHandler NewsChanged;

    public void NewNewsAvailable()
    {
        var twitter = GetTwitterNews();
        var lenta = GetLentaNews();
        var tv = GetTvNews();

        if (NewsChanged != null)
                NewsChanged(this, new NewsEventArgs(twitter, lenta, tv));
    }
}