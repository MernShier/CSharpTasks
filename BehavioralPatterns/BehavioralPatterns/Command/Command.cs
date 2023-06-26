namespace BehavioralPatterns.Command;

/*
    Инкапсулирует запрос как объект, позволяя параметризовать клиентов с различными запросами, ставить запросы в очередь или протоколировать их, а также поддерживать операции, которые нельзя отменить
    Можно использовать для отделения отправителя запроса от получателя, обеспечивая большую гибкость и расширяемость в управлении командами и их выполнении
 */

// Интерфейс команды
abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}

// Конкретная команда
class ConcreteCommand : Command
{
    Receiver receiver;

    public ConcreteCommand(Receiver r)
    {
        receiver = r;
    }

    public override void Execute()
    {
        receiver.Operation();
    }

    public override void Undo()
    {
    }
}

// Получатель команды
class Receiver
{
    public void Operation()
    {
    }
}

// Инициатор команды
class Invoker
{
    Command command;

    public void SetCommand(Command c)
    {
        command = c;
    }

    public void Run()
    {
        command.Execute();
    }

    public void Cancel()
    {
        command.Undo();
    }
}

// Клиент
class Client
{
    void Main()
    {
        Invoker invoker = new Invoker();
        Receiver receiver = new Receiver();
        ConcreteCommand command = new ConcreteCommand(receiver);
        invoker.SetCommand(command);
        invoker.Run();
    }
}