using UnityEngine;

public class Chicken
{
    private string name;
    private int hunger;
    private int happiness;
    private int eggs;

    public string Name
    {
        get => name;
        private set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Debug.Log("Invalid name");
                name = "Chicken";
            }
        }
    }

    public int Hunger
    {
        get => hunger;
        private set
        {
            if (value < 0)
            {
                hunger = 0;
            }
            else if (value > 100)
            {
                hunger = 100;
            }
            else
            {
                hunger = value;
            }
        }
    }

    public int Happiness
    {
        get => happiness;
        private set
        {
            if (value < 0)
            {
                happiness = 0;
            }
            else if (value > 100)
            {
                happiness = 100;
            }
            else
            {
                happiness = value;
            }
        }
    }

    public int Eggs
    {
        get => eggs;
        private set
        {
            if (value < 0)
            {
                eggs = 0;
            }
            else
            {
                eggs = value;
            }
        }
    }

    public Chicken(string name, int hunger, int happiness, int eggs)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Eggs = eggs;
    }

    public void AdjustHunger(int amount)
    {
        Hunger = Hunger + amount;
        Debug.Log($"{Name} Hunger --> to {Hunger}");
    }

    public void AdjustHappiness(int amount)
    {
        Happiness = Happiness + amount;
        Debug.Log($"{Name} Happiness --> to {Happiness}");
    }

    public void Feed(string food)
    {
        AdjustHunger(-10);
        AdjustHappiness(5);
        Debug.Log($"{Name} ate {food}!");
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} is sleeping");
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: meow");
    }

    public void GetStatus()
    {
        Debug.Log($"[Chicken Status] Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {Eggs}");
    }
}
