using UnityEngine;

public class Cow
{
    private string name;
    private int hunger;
    private int happiness;
    private int milk;

    // Properties
    public string Name { get => name; private set => name = value; }
    public int Hunger { get => hunger; private set => hunger = value; }
    public int Happiness { get => happiness; private set => happiness = value; }
    public int Milk { get => milk; private set => milk = value; }

    // Constructor
    public Cow(string name, int hunger, int happiness, int milk)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Milk = milk;
    }

    // Public Methods
    public void AdjustHunger(int amount)
    {
        Hunger += amount;
        Debug.Log($"{Name} Hunger = {Hunger}");
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        Debug.Log($"{Name} Happiness = {Happiness}");
    }

    public void Feed(string food)
    {
        AdjustHunger(-10);
        AdjustHappiness(5);
        Debug.Log($"{Name} was fed {food}.");
    }

    public void Play()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} played.");
    }

    // ให้ MakeSound เรียก Moo ได้
    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} says: Moo");
    }

    public void MakeSound()
    {
        Moo(); // เรียก Moo ภายใน MakeSound
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(5);
        Debug.Log($"{Name} slept");
    }

    public void ProduceMilk()
    {
        Milk++;
        AdjustHappiness(-5);
        Debug.Log($"{Name} produced milk");
        Debug.Log($"Total Milk: {Milk}");
    }

    public void GetStatus()
    {
        Debug.Log($"Cow: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk}");
    }
}
