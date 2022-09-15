

using FactoryMethod.Domain.Factories;

Console.WriteLine(">>> Welcome to fitnessClub <<<\n");
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
}
