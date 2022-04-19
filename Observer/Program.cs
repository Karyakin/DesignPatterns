//(Наблюдатель)
//_______________________________________
/*
 *Паттерн наблюдать определяет отношения одинк ко многим, позволяя при этом оповещать зависимые объекты наблюдателей об изменениях в объекте субъекта 
 */


using Observer.News;
using Observer.Widgets;

var newsAggregator = new NewsAggregator();
var twitterWidget = new TwitterWidget();
var lentaWidget = new LentaWidget();
var tvWidget = new TvWidget();

newsAggregator.NewsChanged += twitterWidget.Update;
newsAggregator.NewsChanged += lentaWidget.Update;
newsAggregator.NewsChanged += tvWidget.Update;

newsAggregator.NewNewsAvailable();
Console.WriteLine();

newsAggregator.NewsChanged -= lentaWidget.Update;

newsAggregator.NewNewsAvailable();



Console.ReadKey();