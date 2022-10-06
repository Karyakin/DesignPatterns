namespace FactoryMethod.Domain.Factories;

internal abstract class CarsFactory
{
    public abstract ICarsModification GetCars();
}