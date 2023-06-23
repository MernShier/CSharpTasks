namespace CreationalPatterns.Prototype;

/*
 Создаёт объекты путём клонирования с внесением при необходимости изменений без использования конструктора.
 Можно использовать для упрощения создания новых объектов, избегая при этом необходимости явно создавать экземпляры новых объектов и устанавливать их начальное состояние.
 */

// Создаёт объекты прототипов
class Client
{
    void Operation()
    {
        Prototype prototype = new ConcretePrototype1(1);
        Prototype clone = prototype.Clone();
        prototype = new ConcretePrototype2(2);
        clone = prototype.Clone();
    }
}

// Определяет интерфейс для клонирования 
abstract class Prototype
{
    public int Id { get; private set; }

    public Prototype(int id)
    {
        this.Id = id;
    }

    public abstract Prototype Clone();
}

// Конкретные реализации прототипа с реализацией метода клонирования
class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(int id)
        : base(id)
    {
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype1(Id);
    }
}

class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(int id)
        : base(id)
    {
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype2(Id);
    }
}