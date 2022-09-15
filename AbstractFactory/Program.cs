using AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Cars.Сoncretely;
using AbstractFactory.Country;
using AbstractFactory.Country.Concretely;
using AbstractFactory.Country.Concretely.Africa;
using AbstractFactory.Сoncretely.CocaCola;
using AbstractFactory.Сoncretely.Pepsi;
using AbstractFactory.Сoncretely.Schweppes;

try
{
    Creator? creator = null;
    creator = new Creator(new PepsiFactory());
    creator.Run();

    creator = new Creator(new CocaColaFactory());
    creator.Run();

    creator = new Creator(new SchweppesFactory());
    creator.Run();

    CarCreator? carCreator = null;
    carCreator = new CarCreator(new OpelFactory());
    carCreator.Run();

    carCreator = new CarCreator(new BmwFactory());
    carCreator.Run();


    CountryCreator? countryCreator;
    countryCreator = new CountryCreator(new RussiaFactory());
    countryCreator.Run();

    countryCreator = new CountryCreator(new AfricaFactory());
    countryCreator.Run();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}