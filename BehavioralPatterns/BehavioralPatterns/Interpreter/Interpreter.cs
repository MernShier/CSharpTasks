namespace BehavioralPatterns.Interpreter;

/*
    Определяет грамматику и интерпретирует предложения в этой грамматике
    Это обеспечивает способ вычисления или синтаксического анализа выражений и их выполнения
    Можно использовать для реализации языков, языков запросов и систем оценки выражений
 */

//Клиент
class Client
{
    void Main()
    {
        Context context = new Context();
 
        var expression = new NonterminalExpression();
        expression.Interpret(context);
 
    }
}
 
// Содержит общую для интерпретатора информацию
class Context
{
}
 
// Определяет интерфейс выражения
abstract class AbstractExpression
{
    public abstract void Interpret(Context context);
}
 
// Реализует интерфейс выражения
class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
    }
}
 
// Представляет правило грамматики
class NonterminalExpression : AbstractExpression
{
    AbstractExpression expression1;
    AbstractExpression expression2;
    public override void Interpret(Context context)
    {
             
    }
}