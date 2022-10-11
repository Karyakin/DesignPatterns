

using FactoryMethod.Domain;
using FactoryMethod.Domain.Factories;

#region MemberShip
/*Console.WriteLine(">>> Welcome to fitnessClub <<<\n");
Console.WriteLine("Enter Membership type: ");

Console.WriteLine("G - Gym");
Console.WriteLine("P - SwimmingPool");
Console.WriteLine("T - Personal trainer");
var type = Console.ReadLine();

Console.WriteLine("MonthCount: ");
int monthCount = Convert.ToInt32(Console.ReadLine());

MemberShipFactory factory = GetFactory(type, monthCount);

Console.WriteLine($"Name:{factory.GetMembership().Name}");
Console.WriteLine($"Description:{factory.GetMembership().Description}");
Console.WriteLine($"MonthCount:{factory.GetMembership().MonthCount}");
Console.WriteLine($"Price:{factory.GetMembership().GetPrice()}");


var aa = new
{
    name = factory.GetMembership().Name,
    desc = factory.GetMembership().Description,
    count = factory.GetMembership().MonthCount,
    price = factory.GetMembership().GetPrice()
};

Console.ReadKey();

static MemberShipFactory GetFactory(string type, int monthCount)
{
    return (type switch
    {
        "g" => new GymMemberShipFactory(monthCount, "GymMemberShipFactory"),
        "p" => new GymSwimmingPoolMemberShipFactory(monthCount, "GymMemberShipFactory"),
        "t" => new GymPersonalTrainingMemberShipFactory(monthCount, "GymMemberShipFactory"),
        _ => null
    })!;
}*/
#endregion

#region Cars
Console.WriteLine(">>> Welcome to carFactory <<<\n");
Console.WriteLine("Enter car type: ");

Console.WriteLine("1 - BmwX1");
Console.WriteLine("3 - BmwX3");
Console.WriteLine("5 - BmwX5");
var carType = Console.ReadLine();

Console.WriteLine("Would you have black glass? Y/N");
var blackGlass = Console.ReadLine();

Console.WriteLine("Would you have cd car multimedia? Y/N");
var carMultimedia = Console.ReadLine();

Console.WriteLine("Would you have wheels radius");
var wheelsRadius = Console.ReadLine();

var newBlackClass = blackGlass.Equals("Y");
var newCarMultimedia = carMultimedia.Equals("Y");
var newWheelsRadius = Convert.ToInt32(wheelsRadius);



void GetCars(bool glass,bool multimedia, int radius)
{
    if (carType.Equals("1"))
    {
        CarsFactory carsFactory = new BmwX1Factory(newBlackClass, newCarMultimedia, newWheelsRadius);
        Console.WriteLine("Name: " + carsFactory.GetCars().Name);
        Console.WriteLine("BlackGlass: " + carsFactory.GetCars().BlackGlass);
        Console.WriteLine("CdMultimedia: " + carsFactory.GetCars().CdMultimedia);
        Console.WriteLine("Total price: " + carsFactory.GetCars().GetTotalPrice());
    }
    if (carType.Equals("3"))
    {
        CarsFactory carsFactory = new BmwX3Factory(newBlackClass, newCarMultimedia, newWheelsRadius);
        Console.WriteLine("Name: " + carsFactory.GetCars().Name);
        Console.WriteLine("BlackGlass: " + carsFactory.GetCars().BlackGlass);
        Console.WriteLine("CdMultimedia: " + carsFactory.GetCars().CdMultimedia);
        Console.WriteLine("Total price: " + carsFactory.GetCars().GetTotalPrice());
    }
    if (carType.Equals("5"))
    {
        CarsFactory carsFactory = new BmwX5Factory(newBlackClass, newCarMultimedia, newWheelsRadius);
        Console.WriteLine("Name: " + carsFactory.GetCars().Name);
        Console.WriteLine("BlackGlass: " + carsFactory.GetCars().BlackGlass);
        Console.WriteLine("CdMultimedia: " + carsFactory.GetCars().CdMultimedia);
        Console.WriteLine("Total price: " + carsFactory.GetCars().GetTotalPrice());
    }
}

GetCars(newBlackClass,newCarMultimedia, newWheelsRadius);



Console.ReadKey();
#endregion











