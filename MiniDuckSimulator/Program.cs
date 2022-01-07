﻿namespace MiniDuckSimulator;

public class Program
{
    private static void Main(string[] args)
    {
        
    }
}

public abstract class Duck
{
    private IFlyBehavior _flyBehavior;
    private IQuackBehavior _quackBehavior;

    public Duck() { }

    public abstract void Display();
    
    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}