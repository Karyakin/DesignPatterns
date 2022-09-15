using FactoryMethod.Domain.MemberShips;

namespace FactoryMethod.Domain.Factories;

internal class GymMemberShipFactory : MemberShipFactory
{
    private readonly int _monthCount;
    private readonly string _description;

    public GymMemberShipFactory(int monthCount, string description)
    {
        _monthCount = monthCount;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        GymMembership gymMembership = new GymMembership(_monthCount, _description);
        return gymMembership;
    }
}

internal class GymSwimmingPoolMemberShipFactory : MemberShipFactory
{
    private readonly int _monthCount;
    private readonly string _description;

    public GymSwimmingPoolMemberShipFactory(int monthCount, string description)
    {
        _monthCount = monthCount;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        GymSwimmingPool gymSwimmingPool = new GymSwimmingPool(_monthCount, _description);
        return gymSwimmingPool;
    }
}

internal class GymPersonalTrainingMemberShipFactory : MemberShipFactory
{
    private readonly int _monthCount;
    private readonly string _description;

    public GymPersonalTrainingMemberShipFactory(int monthCount, string description)
    {
        _monthCount = monthCount;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        GymPersonalTraining gymPersonalTraining = new GymPersonalTraining(_monthCount, _description);
        return gymPersonalTraining;
    }
}