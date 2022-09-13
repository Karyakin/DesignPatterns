namespace AbstractFactory.Abstract;

public abstract class AbstractBottle
{
    /// <summary>
    /// Метод собирает готовый продукт одного семейства и выдает нам с конвейера готовую бутылку
    /// </summary>
    /// <param name="water">Какая вода</param>
    /// <param name="cap">Какая крышка</param>
    /// <param name="label">Какая этикетка</param>
    public abstract void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label);

}