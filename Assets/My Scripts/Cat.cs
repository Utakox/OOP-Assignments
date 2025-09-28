using System;
using UnityEngine;



public class Cat : Animal
{

    private int furballs;

    public int Furballs
    {
        get { return furballs; }
        private set { furballs = value; }
    }

    public override void Init(string name)
    {
        base.Init(name);
        preferedFood = FoodType.Meat;
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} Meow");
    }

    public override void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger} | Happiness: {Happiness}");
    }

// ผลิต furballs
    public override string Produce()
    {
        if (Happiness <= 40)
        {
            furballs += 1;
            Debug.Log($"{Name} produced a furball!");
            return $"{Name} produced a furball!";
        }

        else if (Happiness >= 41 && Happiness <= 59)
        {
            furballs += 2;
            Debug.Log($"{Name} produced 2 furballs!");
            return $"{Name} produced 2 furballs!";
        }

        else // มากกว่า 60
        {
            furballs += 3;
            Debug.Log($"{Name} produced 3 furballs!");
            return $"{Name} produced 3 furballs!";
        }
    }
}
