namespace MiniDuckSimulator;

public class Program
{
    private static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.PerformQuack();
        mallard.PerformFly();
    }
}