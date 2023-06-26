namespace BehavioralPatterns.ChainOfResponsibility;

/*
    Паттерн, в котором ряд обработчиков объединен цепочкой
    Когда делается запрос, он передается по цепочке до тех пор, пока не будет найден обработчик, который сможет его обработать
    Можно использовать для разделения отправителей и получателей запросов и позволяет нескольким объектам иметь возможность обрабатывать запрос
 */

// Клиент
class Client
{
    void Main()
    {
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        h1.Successor = h2;
        h1.HandleRequest(2);
    }
}

// Определяет интерфейс для обработки запросов
abstract class Handler
{
    public Handler Successor { get; set; }
    public abstract void HandleRequest(int condition);
}
 
// Конкретные реализация интерфейса
class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int condition)
    {
        // некоторая обработка запроса
         
        if (condition==1)
        {
            // завершение выполнения запроса;
        }
        // передача запроса дальше по цепи при наличии в ней обработчиков
        else if (Successor != null)
        {
            Successor.HandleRequest(condition);
        }
    }
}
 
class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int condition)
    {
        // некоторая обработка запроса
         
        if (condition==2)
        {
            // завершение выполнения запроса;
        }
        // передача запроса дальше по цепи при наличии в ней обработчиков
        else if (Successor != null)
        {
            Successor.HandleRequest(condition);
        }
    }
}