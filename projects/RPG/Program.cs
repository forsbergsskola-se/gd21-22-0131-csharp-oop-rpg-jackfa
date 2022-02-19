using System;

static class Program
{
    static void Main()
    {
        Unit spider = new Unit("Spider", 50);
        Unit bandit = new Unit("Bandit", 150);
        Unit wizard = new Unit("Wizard", 350);
        Unit leet = new Unit("Leet", 1337);

        while(leet.IsAlive)
        {
            Console.WriteLine("How much damage do you want to deal to Leet?");
            leet.Damage(int.Parse(Console.ReadLine()));
        }
    } 
}

public class Unit
{
    //Read-only Property
    public string Name { get; }
    public int id;
    public static int nextId;
    private int health;
    private int maxHealth;

    public bool IsAlive
    {
        get
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public Unit(string name, int maxHealth)
    {
        this.Name = name;
        id = nextId++;

        this.maxHealth = maxHealth;
        health = maxHealth;
        //Make sure ReportStatus is always called last in this constructor.
        ReportStatus();
    }

    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
    }

    public int Health
    {
        private set
        {
            health = Math.Clamp(value, 0 , maxHealth);
            ReportStatus();
        }
        get
        {
            return health;
        }
    }

    public void Damage(int value)
    {
        Health -= value;
    }


}