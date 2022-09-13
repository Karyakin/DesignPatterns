namespace AbstractFactory.Abstract;
/// <summary>
/// Определяет перечень методов, необходимых для создания продукта определенного семейства
/// </summary>
public abstract class AbstractFactory
{
    public abstract AbstractBottle CreateBottle();
    public abstract AbstractLabel CreateLabel();
    public abstract AbstractCap CreateCap();
    public abstract AbstractWater CreateWater();
}