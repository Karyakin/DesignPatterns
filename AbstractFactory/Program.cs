using AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Cars.Сoncretely;
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

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}