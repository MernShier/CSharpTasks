namespace StructuralPatterns.Composite;

/*
 Позволяет рассматривать группу объектов как единый объект, представляя иерархии,
 в которых отдельные объекты и группы объектов обрабатываются единообразно. 
 Может использоваться когда нужно представить иерархическую структуру объектов, где можено работать как с отдельными объектами,
 так и с группами объектов согласованным образом.
 */

// Клиент работающий с компонентами
class Client
{
    public void Main()
    {
        Component root = new Composite("Root");
        Component leaf = new Leaf("Leaf");
        Composite subtree = new Composite("Subtree");
        root.Add(leaf);
        root.Add(subtree);
        root.Display();
    }
}

// Определяет интерфейс компонента
abstract class Component
{
    protected string name;
 
    public Component(string name)
    {
        this.name = name;
    }
 
    public abstract void Display();
    public abstract void Add(Component c); 
    public abstract void Remove(Component c);
}

// Компонент хранящий другие компоненты и реализующий методы их добавления и удаления
class Composite : Component
{
    List<Component> children = new List<Component>();
 
    public Composite(string name)
        : base(name)
    {}
 
    public override void Add(Component component)
    {
        children.Add(component);
    }
 
    public override void Remove(Component component)
    {
        children.Remove(component);
    }
 
    public override void Display()
    {
        Console.WriteLine(name);
 
        foreach (Component component in children)
        {
            component.Display();
        }
    }
}
// Отдельный компонент
class Leaf : Component
{
    public Leaf(string name)
        : base(name)
    {}
 
    public override void Display()
    {
        Console.WriteLine(name);
    }
 
    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }
 
    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}