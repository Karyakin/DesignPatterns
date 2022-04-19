namespace Observer.Widgets;

public interface IWidgetObserver
{
    public void Update(string twitter, string lenta, string tv);
    
    void RemoveFromSubject();
}