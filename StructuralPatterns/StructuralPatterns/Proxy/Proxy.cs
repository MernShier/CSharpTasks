namespace StructuralPatterns.Proxy;

/*
 Предоставляет подмену оригинального класса или его имплементации на прокси
 Можно использовать когда нужно разграничить к вызываемому объекту в зависимости от прав вызывающего объекта
 */

// Клиент
class Client
{
    void Main()
    {
        Subject subject = new Proxy();
        subject.Request();
    }
}

// Интерфейс для остальных компонентов
abstract class Subject
{
    public abstract void Request();
}
 
// Реальный объект
class RealSubject : Subject
{
    public override void Request()
    {}
}

// Прокси для реального объекта
class Proxy : Subject
{
    RealSubject realSubject;
    public override void Request()
    {
        if (realSubject == null)
            realSubject = new RealSubject();
        realSubject.Request();
    }
}