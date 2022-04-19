using Observer.Widgets;

namespace Observer.News;

public class NewsAggregator : ISubject
{
    private static Random _random;
    private List<IWidgetObserver> _widgetObservers;

    public NewsAggregator()
    {
        _random = new Random();
        _widgetObservers = new List<IWidgetObserver>();
    }
    public void RegisterObserver(IWidgetObserver widgetObserver)
    {
      _widgetObservers.Add(widgetObserver);
    }

    public void RemoveObserver(IWidgetObserver widgetObserver)
    {
        _widgetObservers.Remove(widgetObserver);
    }

    public void NotifyObserver()
    {
        var twitter = GetTwitterNews();
        var lenta = GetLentaNews();
        var tv = GetTvNews();
        
        foreach (var observer in _widgetObservers)
        {
          observer.Update(twitter, lenta, tv);
        }
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
    public void NewNewsAvailable()
    {
        NotifyObserver();
    }
}