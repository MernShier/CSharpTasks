namespace BehavioralPatterns.State;

/*
    Позволяет объекту изменять свое поведение на основе его внутреннего состояния
    Он инкапсулирует каждое состояние в отдельный класс, и объект делегирует свое поведение объекту текущего состояния, 
    из-за чего код становиться более чистым и удобным
    Можно использовать когда поведение объекта должно изменяться в зависимости от его внутреннего состояния
 */

/*
 State Pattern - специфический метод реализации для управления поведением объекта на основе его состояния
 State Machine - описывает поведение системы или компонента посредством состояний и переходов
 
 State Pattern может быть использован как метод для реализации State Machine, но это не обязательно
 */

// Определяет интерфейс состояния
abstract class State
{
    public abstract void Handle(Context context);
}

// Конкретные реализации состояний
class StateA : State
{
    public override void Handle(Context context)
    {
        context.State = new StateB();
    }
}
class StateB : State
{
    public override void Handle(Context context)
    { 
        context.State = new StateA();
    }
}
 
// Объект, изменяющийся на основе состояний
class Context
{
    public State State { get; set; }
    public Context(State state)
    {
        this.State = state;
    }
    public void Request()
    {
        this.State.Handle(this);
    }
}