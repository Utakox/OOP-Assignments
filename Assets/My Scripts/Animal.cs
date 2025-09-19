using System;
using UnityEngine;

public abstract class Animal
{
    // ===== Fields =====
    private string name;
    private int hunger;
    private int happiness;

    // ===== Properties =====
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public int Hunger
    {
        get { return hunger; }
        private set { hunger = Mathf.Clamp(value, 0, 100); }
    }

    public int Happiness
    {
        get { return happiness; }
        private set { happiness = Mathf.Clamp(value, 0, 100); }
    }

    // ===== Methods =====
    public void Init(string name, int hunger, int happiness)
    {
        this.Name = name;
        this.Hunger = hunger;
        this.Happiness = happiness;
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    public abstract void MakeSound();

    // Overload Feed
    public void Feed(int food)
    {
        AdjustHunger(-food);
        AdjustHappiness(+5);
    }

    public void Feed(string food, int value)
    {
        Debug.Log($"{Name} is eating {food}!");
        AdjustHunger(-value);
        AdjustHappiness(+10);
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger} | Happiness: {Happiness}");
    }
}
