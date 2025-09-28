
using System;
using UnityEngine;

public class Chicken : Animal
{
    private int eggs;

    public int Eggs
    {
        get { return eggs; }
        private set { eggs = value; }
    }

    public override void Init(string name)
    {
        base.Init(name);
        preferedFood = FoodType.Grain;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck Cluck!");
    }

    public void Sleep()
    {
        AdjustHunger(+5);
        AdjustHappiness(+10);
    }

    public override string Produce()
    {
        if (Happiness <= 50)
        {
            Eggs += 1;
            Debug.Log($"{Name} laid an egg!");
            return $"{Name} laid an egg!";
        }

        else if (Happiness > 51 && Happiness <= 79)
        {
            Eggs += 2;
            Debug.Log($"{Name} laid 2 eggs!");
            return $"{Name} laid 2 eggs!";
        }

        else if (Happiness >= 80)
        {
            Eggs += 3;
            Debug.Log($"{Name} laid 3 eggs!");
            return $"{Name} laid 3 eggs!";
        }
        else
        {
            Debug.Log($"{Name} is not happy enough to lay an egg.");
            return $"{Name} is not happy enough to lay an egg.";
        }
    }


}
