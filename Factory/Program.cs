using Factory.Facility;


/*
 * Патерн Фабричный метод позволяет определить общий интерфейс создания объектов(продуктов), при этом позволяя субклассам выбирать конкретный продукт для создания
 * Иными словами - паььрен Фабричный метод инкапсулирует создание объектов
 */

VolkswagenFactory factory = new DeutschVolkswagenFactory();

factory.GetCar("Golf");
Console.WriteLine();
factory.GetCar("Passat");
Console.WriteLine();
factory.GetCar("Tiguan");
Console.WriteLine();
factory.GetCar("Touareg");
Console.WriteLine();







Console.ReadKey();