//(Наблюдатель)
//_______________________________________
/*
 *Паттерн наблюдать определяет отношения одинк ко многим, позволяя при этом оповещать зависимые объекты наблюдателей об изменениях в объекте субъекта 
 */


using Observer.News;
using Observer.Widgets;

var newsAggregator = new NewsAggregator();
var twitterWidget = new TwitterWidget(newsAggregator);
var lentaWidget = new LentaWidget(newsAggregator);
var tvWidget = new TvWidget(newsAggregator);

newsAggregator.NewNewsAvailable();
Console.WriteLine();
twitterWidget.RemoveFromSubject();
newsAggregator.NewNewsAvailable();



Console.ReadKey();