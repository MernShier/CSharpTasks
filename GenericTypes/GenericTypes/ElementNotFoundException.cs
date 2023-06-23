namespace GenericTypes;

public class ElementNotFoundException : Exception
{
    public override string Message => "Element was not found";
}