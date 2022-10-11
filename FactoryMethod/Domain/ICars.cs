namespace FactoryMethod.Domain;

internal interface ICars
{
    string Name { get; }
    decimal DefaultPrice { get; }
    bool BlackGlass { get; }
    bool CdMultimedia { get; }
    int WheelRadius { get; }

    decimal GetTotalPrice();
}