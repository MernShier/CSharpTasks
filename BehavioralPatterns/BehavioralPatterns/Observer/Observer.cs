namespace BehavioralPatterns.Observer;

/*
    Устанавливает отношение "один ко многим" между объектами
    Это позволяет нескольким наблюдателям получать уведомления и автоматически обновляться при изменении состояния объекта-субъекта
    Можно использовать в системах, управляемых событиями, для реализации обработки событий, обновлений пользовательского интерфейса
 */

// Интерфейс наблюдаемого объекта
interface IObservable
{
    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

// Конкретная реализация интерфейса наблюдаемого объекта
class ConcreteObservable : IObservable
{
    private List<IObserver> observers;

    public ConcreteObservable()
    {
        observers = new List<IObserver>();
    }

    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
            observer.Update();
    }
}

// Интерфейс наблюдателя
interface IObserver
{
    void Update();
}

// Конкретная раелизация наблюдателя
class ConcreteObserver : IObserver
{
    public void Update()
    {
    }
}