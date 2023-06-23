namespace CreationalPatterns.Singleton;

/*
 Гарантирует что для определённого класса будет создан лишь один объект, который можно получить из любой точки программы
 Можно использовать для реализации служебной логики
 */
public class Singleton
{
    private static Singleton instance;
        
        private Singleton()
        {}
 
        // Возвращает объект класса. При первом вызове создаётся единственный объект класса
        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
}