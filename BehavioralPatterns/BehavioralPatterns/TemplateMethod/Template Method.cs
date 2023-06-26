namespace BehavioralPatterns.TemplateMethod;

/*
    Определяет каркас алгоритма в базовом классе, позволяя подклассам переопределять определенные шаги алгоритма
    Можно использовать когда нужно предоставить общую структуру для ряда связанных алгоритмов,
    обеспечивая при этом гибкость для отдельных реализаций в изменении определенных шагов
 */

// Базовый класс
abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Operation1();
        Operation2();
    }
    public abstract void Operation1();
    public abstract void Operation2();
}

// Подкласс имеющий возможность переопределять определенные шаги базового класса
class ConcreteClass : AbstractClass
{
    public override void Operation1()
    {
    }
 
    public override void Operation2()
    {
    }
}