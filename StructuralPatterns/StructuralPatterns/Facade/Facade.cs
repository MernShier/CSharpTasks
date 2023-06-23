namespace StructuralPatterns.Facade;

/*
 Обеспечивает упрощенный интерфейс к сложной подсистеме, инкапсулируя группу интерфейсов в единый интерфейс, упрощая при этом его использование и понимание
 Можно использовать когда есть необходимость предоставить упрощенный интерфейс для набора сложных классов или систем
 */
 
// Компоненты сложной подсистемы
public class SubsystemA
{
    public void A1()
    {}
}

public class SubsystemB
{
    public void B1()
    {}
}

public class SubsystemC
{
    public void C1()
    {}
}
 
// Предоставляет упрощенный интерфейс клиенту
public class Facade
{
    SubsystemA subsystemA;
    SubsystemB subsystemB;
    SubsystemC subsystemC;
 
    public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
    {
        subsystemA = sa;
        subsystemB = sb;
        subsystemC = sc;
    }
    public void Operation1()
    {
        subsystemA.A1();
        subsystemB.B1();
        subsystemC.C1();
    }
    public void Operation2()
    {
        subsystemB.B1();
        subsystemC.C1();
    }
}
 
// Клиент
class Client
{
    public void Main()
    {
        Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
        facade.Operation1();
        facade.Operation2();
    }
}