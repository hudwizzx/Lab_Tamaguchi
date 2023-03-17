using System;
public class Tamagotchi
{
    private string name;
    private int hunger;
    private int happiness;

    public Tamagotchi(string name)
    {
        this.name = name;
        this.hunger = 0;
        this.happiness = 0;
    }

    public void Feed()
    {
        this.hunger -= 10;
        if (this.hunger < 0)
        {
            this.hunger = 0;
        }
        this.happiness += 5;
    }

    public void Play()
    {
        this.hunger += 5;
        this.happiness += 10;
    }

    public void Sleep()
    {
        this.hunger += 5;
        this.happiness -= 5;
    }

    public void PrintStats()
    {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Hunger: " + this.hunger);
        Console.WriteLine("Happiness: " + this.happiness);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Tamagotchi tamagotchi = new Tamagotchi("Tommy");

        tamagotchi.PrintStats();
        tamagotchi.Feed();
        tamagotchi.Play();
        tamagotchi.Sleep();
        tamagotchi.PrintStats();
    }
}