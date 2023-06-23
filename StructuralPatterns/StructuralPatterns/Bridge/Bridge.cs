namespace StructuralPatterns.Bridge;

/*
 Позволяет отделить абстракцию от реализации таким образом, чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.
 Можно использовать когда нужно избежать жёсткой зависимости реализации от абстракции
 */

// Клиент
class Client
{
    static void Main()
    {
        Abstraction abstraction;
        abstraction = new RefinedAbstraction(new ConcreteImplementorA());
        abstraction.Operation();
        abstraction.Implementor=new ConcreteImplementorB();
        abstraction.Operation();
    }
}

// Определяет базовый интерфейс и хранит ссылку на Implementor
abstract class Abstraction
{
    protected Implementor implementor;
    public Implementor Implementor
    {
        set { implementor = value; }
    }
    public Abstraction(Implementor imp)
    {
        implementor = imp;
    }
    public virtual void Operation()
    {
        implementor.OperationImp();
    }
}
 
// Определяет базовый интерфейс для конкретных реализаций
abstract class Implementor
{
    public abstract void OperationImp();
}
 
// Расширяет наследуемый интерфейс
class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(Implementor imp)
        : base(imp)
    {}
    public override void Operation()
    {
    }
}
 
// Конкретный реализации Implementor
class ConcreteImplementorA : Implementor
{
    public override void OperationImp()
    {
    }
}
 
class ConcreteImplementorB : Implementor
{
    public override void OperationImp()
    {
    }
}