using System;
using System.Numerics;
class Dog
{
    public string Name;
    public string FurColor;
    public double BodyWeight;
    public bool isSleeping = false;
    public Dog(string name)
    {
        this.Name = name;
    }
    public Dog(string name, string furColor)
        : this(name)
    {
        FurColor = furColor;
    }
    public Dog(string name, double bodyWeight)
        : this(name)
    {
        BodyWeight = bodyWeight;
    }
    public Dog(string name, string furColor, double bodyWeight)
        : this(name, furColor)
    {
        BodyWeight = bodyWeight;
    }
    public void WakeUp()
    {
        if (!isSleeping)
        {
            Console.WriteLine("Пес {0} встав", Name);
        }
        else Console.WriteLine("Пес {0} не може встати, він спить", Name);
    }
    public void Sleep()
    {
        Console.WriteLine("Пес {0} наразі спить", Name);
        isSleeping = true;
    }
    public void Bark()
    {
        if (!isSleeping)
        {
            if (BodyWeight > 20)
            {
                Console.WriteLine("Великий пес {0} голосно гавкає", Name);
            }
            else Console.WriteLine("Малий пес {0} тихо гавкає", Name);
        }
        else Console.WriteLine("Пес {0} спить. Він не може гавкати", Name);
    }
    public void Run()
    {
        if (!isSleeping)
        {
            if (BodyWeight > 20)
            {
                Console.WriteLine("Великий пес {0} швидко бігає", Name);
            }
            else Console.WriteLine("ИМалий пес {0} повільно бігає", Name);
        }
        Console.WriteLine("Пес {0} спить. Він не може бігати");
    }
}
class Program
{
    static void Main()
    {
        Dog bigDog = new Dog("Барон", "Рудий", 25);
        Dog smallDog = new Dog("Рекс", 10);

        bigDog.WakeUp();
        bigDog.Bark();
        bigDog.Sleep();
        bigDog.Bark();

        smallDog.WakeUp();
        smallDog.Bark();
        smallDog.Sleep();
        smallDog.Bark();

        Console.ReadLine();
    }
}