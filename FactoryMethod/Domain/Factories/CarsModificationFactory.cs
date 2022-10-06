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
    
    public override ICarsModification GetCars()
    {
        BmwX1Factory x1Factory = new BmwX1Factory(_blackGlass, _cdMultimedia, _wheelRadius);
        return null;
    }
}

internal class BmwX3Factory : CarsFactory
{
    public override ICarsModification GetCars()
    {
        throw new NotImplementedException();
    }
}

internal class BmwX5Factory : CarsFactory
{
    public override ICarsModification GetCars()
    {
        throw new NotImplementedException();
    }
}