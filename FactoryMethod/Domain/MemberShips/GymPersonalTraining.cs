using FactoryMethod.Utils.AppConstants;

namespace FactoryMethod.Domain.MemberShips;

internal class GymPersonalTraining : IMembership
{
    private readonly string _name;
    private readonly int _monthCount;
    private readonly string _description;

    public GymPersonalTraining(int monthCount, string description)
    {
        _monthCount = monthCount;
        _description = description;
        _name = "Personal training";
    }

    public string Name => _name;
    public string Description => _description;
    public int MonthCount => _monthCount;
    public decimal GetPrice() => GymConstants.PersonalInstructor;
}