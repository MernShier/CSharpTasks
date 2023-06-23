namespace CreationalPatterns.AbstractFactory;

/*
 Данный шаблон можно использовать когда нужно создать семейства связанных объектов без указания их конкретных классов. 
 Он предоставляет интерфейс для создания объектов различных типов в семействе связанных продуктов.
 */

// Создаёт объекты используя класс фабрики
class Client
{
    private AbstractProductA abstractProductA;
    private AbstractProductB abstractProductB;
 
    public Client(AbstractFactory factory)
    {
        abstractProductB = factory.CreateProductB();
        abstractProductA = factory.CreateProductA();
    }

    public void Run()
    {
        
    }
}

// Определяет методы создания объектов
abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

// Реализуют методы создания объектов
class ConcreteFactory1: AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
         
    public override AbstractProductB CreateProductB()   
    {
        return new ProductB1(); 
    }
}
class ConcreteFactory2: AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
         
    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
 
// Определяет интерфейс для классов чьи объекты нужно создавать
abstract class AbstractProductA
{}
             
abstract class AbstractProductB     
{}
                 
// Конкретная реализация абстрактных классов
class ProductA1: AbstractProductA   
{}
     
class ProductB1: AbstractProductB   
{}
 
class ProductA2: AbstractProductA   
{}
                 
class ProductB2: AbstractProductB       
{}      