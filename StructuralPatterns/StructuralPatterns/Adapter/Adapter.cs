namespace StructuralPatterns.Adapter;

/*
 Позволяет объектам с несовместимыми интерфейсами работать вместе, преобразя интерфейс одного класса в другой интерфейс
 Можно использовать при интеграции существующих или сторонних компонентов в систему, а также
 при рефакторинге устаревшего кода в соответствии с новыми требованиями к интерфейсу
 */

class Client
{
    public void Request(Target target)
    {
        target.Request();
    }
}
// Класс, к которому надо адаптировать другой класс   
class Target
{
    public virtual void Request()
    {}
}
  
// Адаптер
class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();
  
    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}
  
// Адаптируемый класс
class Adaptee
{
    public void SpecificRequest()
    {}
}