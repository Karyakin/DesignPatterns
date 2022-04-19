using Delegate;

var stockExchangeMonitor = new StockExchangeMonitor();
stockExchangeMonitor.PriceChangeHandler = DisplayPrice;
stockExchangeMonitor.Start();

 static void DisplayPrice(int price)
{
  Console.WriteLine(price);    
}