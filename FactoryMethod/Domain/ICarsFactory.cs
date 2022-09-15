namespace FactoryMethod.Domain;

internal interface ICarsFactory
{
    string Name { get; }
    decimal DefaultPrice { get; }
    bool BlackGlass { get; set; }
    bool CdMultimedia { get; set; }
    int WheelRadius { get; set; }

    decimal GetPrice(decimal defaultPrice, bool blackGlass, bool cdMultimedia, int wheelRadius);
}