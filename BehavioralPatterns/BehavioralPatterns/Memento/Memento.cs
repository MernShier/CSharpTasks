namespace BehavioralPatterns.Memento;

/*
    Позволяет фиксировать и восстанавливать внутреннее состояние объекта, не раскрывая деталей его реализации
    Можно использовать для создания копий состояния объекта, которые могут быть сохранены и восстановлены позже, 
    обеспечивая тем самым функциональность отмены/повтора или контрольных точек в приложении
 */

// Объект хранящий состояние Originator и предоставляющий к нему доступ
class Memento
{
    public string State { get; private set;}
    public Memento(string state)
    {
        this.State = state;
    }
}
 
// Хранит объект Memento
class Caretaker
{
    public Memento Memento { get; set; }
}
 
// Создаёт объект хранителя для сохранения своего состояния
class Originator
{
    public string State { get; set; }
    public void SetMemento(Memento memento)
    {
        State = memento.State;
    }
    public Memento CreateMemento()
    {
        return new Memento(State);
    }
}