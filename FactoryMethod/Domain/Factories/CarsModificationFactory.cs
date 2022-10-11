using FactoryMethod.Domain.MemberShips;

namespace FactoryMethod.Domain.Factories;

internal class BmwX1Factory : CarsFactory
{
    private readonly bool _blackGlass;
    private readonly bool _cdMultimedia;
    private readonly int _wheelRadius;

    public BmwX1Factory(bool blackGlass, bool cdMultimedia, int wheelRadius)
    {
        _blackGlass = blackGlass;
        _cdMultimedia = cdMultimedia;
        _wheelRadius = wheelRadius;
    }

    public override ICars GetCars()
    {
        return new BmwX1(_blackGlass, _cdMultimedia, _wheelRadius);
    }
    
}

internal class BmwX3Factory : CarsFactory
{
    private readonly bool _blackGlass;
    private readonly bool _cdMultimedia;
    private readonly int _wheelRadius;

    public BmwX3Factory(bool blackGlass, bool cdMultimedia, int wheelRadius)
    {
        _blackGlass = blackGlass;
        _cdMultimedia = cdMultimedia;
        _wheelRadius = wheelRadius;
    }
    
    public override ICars GetCars()
    {
        return new BmwX3(_blackGlass, _cdMultimedia, _wheelRadius);
    }
}

internal class BmwX5Factory : CarsFactory
{
    private readonly bool _blackGlass;
    private readonly bool _cdMultimedia;
    private readonly int _wheelRadius;

    public BmwX5Factory(bool blackGlass, bool cdMultimedia, int wheelRadius)
    {
        _blackGlass = blackGlass;
        _cdMultimedia = cdMultimedia;
        _wheelRadius = wheelRadius;
    }
    
    public override ICars GetCars()
    {
        return new BmwX3.BmwX5(_blackGlass, _cdMultimedia, _wheelRadius);
    }
}