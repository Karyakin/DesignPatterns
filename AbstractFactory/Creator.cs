using AbstractFactory.Abstract;

namespace AbstractFactory;

public class Creator
{
    private AbstractWater _water;
    private AbstractBottle _bottle;
    private AbstractCap _cap;
    private AbstractLabel _label;

    public Creator(Abstract.AbstractFactory factory)
    {
        // обстрагирование процкссов инстанцирования - обстрактное описание процессов создания будущих экземпляров
        _bottle = factory.CreateBottle();
        _cap = factory.CreateCap();
        _label = factory.CreateLabel();
        _water = factory.CreateWater();
    }

    public void Run()
    {
        // абстрагирование вариантов использования
        _bottle.Interact(_water, _cap, _label);
    }
}