using Observer.Widgets;

namespace Observer.News;

public interface ISubject
{
    void RegisterObserver(IWidgetObserver widgetObserver);
    void RemoveObserver(IWidgetObserver widgetObserver);
    void NotifyObserver();
}