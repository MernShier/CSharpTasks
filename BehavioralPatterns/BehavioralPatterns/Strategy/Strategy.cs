namespace BehavioralPatterns.Strategy;

/*
    Позволяет динамически выбирать алгоритмы во время выполнения. Инкапсулирует взаимозаменяемые алгоритмы в отдельные классы, позволяя легко заменять их
    Можно использовать для отделения алгоритмов от клиентского кода и обеспечивает гибкость в выборе различных стратегий, основанных на конкретных требованиях
 */

// Интерфейс определяющий метод Algorithm
public interface IStrategy
{
    void Algorithm();
}

// Конкретные реализации алгоритма
public class ConcreteStrategy1 : IStrategy
{
    public void Algorithm()
    {}
}
 
public class ConcreteStrategy2 : IStrategy
{
    public void Algorithm()
    {}
}
 
// Хранит ссылку на интерфейс
public class Context
{
    public IStrategy ContextStrategy { get; set; }
 
    public Context(IStrategy _strategy)
    {
        ContextStrategy = _strategy;
    }
 
    public void ExecuteAlgorithm()
    {
        ContextStrategy.Algorithm();
    }
}