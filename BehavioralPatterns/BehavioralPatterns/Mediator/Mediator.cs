namespace BehavioralPatterns.Memento;

/*
    Cпособствует слабой связи между объектами путем инкапсуляции их коммуникационной логики в центральный объект-посредник, тем самым
    позволяя объектам взаимодействовать друг с другом косвенно, уменьшая зависимости и упрощая обслуживание системы
    Можно использовать в сложных системах, где многим объектам необходимо взаимодействовать друг с другом
 */

// Определяет интерфейс для взаимодействия с объектами Colleague
abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}

// Определяет интерфейс для взаимодействия с объектом Mediator
abstract class Colleague
{
    protected Mediator mediator;
 
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}
 
// Конкретные реализации классов Colleague
class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator)
        : base(mediator)
    { }
  
    public void Send(string message)
    {
        mediator.Send(message, this);
    }
  
    public void Notify(string message)
    { }
}
 
class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator)
        : base(mediator)
    { }
  
    public void Send(string message)
    {
        mediator.Send(message, this);
    }
  
    public void Notify(string message)
    { }
}

// Конкретная реализация Mediator
class ConcreteMediator : Mediator
{
    public ConcreteColleague1 Colleague1 { get; set; }
    public ConcreteColleague2 Colleague2 { get; set; }
    public override void Send(string msg, Colleague colleague)
    {
        if (Colleague1 == colleague)
            Colleague2.Notify(msg);
        else
            Colleague1.Notify(msg);
    }
}