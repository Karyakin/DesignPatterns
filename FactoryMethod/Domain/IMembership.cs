namespace FactoryMethod.Domain;

internal interface IMembership
{
    string Name { get; }
    string Description { get; }
    int MonthCount { get; }
    decimal GetPrice();
}