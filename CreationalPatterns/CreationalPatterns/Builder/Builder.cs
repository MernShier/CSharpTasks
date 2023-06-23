namespace CreationalPatterns.Builder;

/*
 Пошагово "Собирает" объекты по частям, тем самым позволяя гибко их настраивать
 Можно использовать для гибкого и удобочитаемого способа создания объектов с несколькими свойствами или параметрами конфигурации, а также 
 для более простого создания для объектов со сложной логикой инициализации.
 */

// Создаёт объекты продукта используя конкретные объекты Builder
class Director
{
    Builder builder;
    public Director(Builder builder)
    {
        this.builder = builder;
    }
    public void Construct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}
 
// Определяет интерфейс для создания различных частей продукта
abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract void BuildPartC();
    public abstract Product GetResult();
}
 
// Объект который должен быть создан
class Product
{
    List<object> parts = new List<object>();
    public void Add(string part)
    {
        parts.Add(part);
    }
}
 
// Конкретная реализация класса Builder
class ConcreteBuilder : Builder
{
    Product product = new Product();
    public override void BuildPartA()
    {
        product.Add("Part A");
    }
    public override void BuildPartB()
    {
        product.Add("Part B");
    }
    public override void BuildPartC()
    {
        product.Add("Part C");
    }
    public override Product GetResult()
    {
        return product;
    }
}