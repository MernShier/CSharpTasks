namespace CreationalPatterns.Factory;

/*
    Определяет интерфейс для создания объектов, подклассы реализуют логику создания
    Можно использовать когда создание объектов должно быть гибким, легко расширяемым
 */

// Определяет интерфейс класса, объекты которого надо создавать
abstract class Product
{
}

class ConcreteProductA : Product
{
}

class ConcreteProductB : Product
{
}

// Определяет фабричный метод, возвращающий продукт
abstract class Creator
{
    public abstract Product FactoryMethod();
}

// Создаёт и возвращает продукт A
class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

// Создаёт и возвращает продукт B
class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}