namespace StructuralPatterns.Decorator;

/*
 Позволяет динамически добавлять новые модели поведения или функциональные возможности к существующему объекту без изменения его структуры
 Можно использовать для расширения функциональности объекта во время выполнения путем обертывания его одним или несколькими декораторами,
 обеспечивая гибкий и масштабируемый способ изменения поведения объекта
 */

// Определяет интерфейс наследуемых объектов
abstract class Component
{
    public abstract void Operation();
}
// Конкретная реализация интерфейса
class ConcreteComponent : Component
{
    public override void Operation()
    {}
}

abstract class Decorator : Component
{
    protected Component component;
 
    public void SetComponent(Component component)
    {
        this.component = component;
    }
 
    public override void Operation()
    {
        if (component != null)
            component.Operation();
    }
}

// Конкретные реализации декоратора
class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
    }
}
class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
    }
}