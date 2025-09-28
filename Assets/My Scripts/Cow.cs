using System;
using UnityEngine;



public class Cow : Animal
{
    private float milk;

    public float Milk
    {
        get { return milk; }
        private set { milk = value; }
    }

    public override void Init(string name)
    {
        base.Init(name);
        preferedFood = FoodType.Hay;
    }



    public override void MakeSound()
    {
        Debug.Log($"{Name} says Moo!");
    }

    public override string Produce()
    {
        if (Happiness > 70)
        {
            float producedMilk = Happiness / 10f; // Produce milk based on happiness level
            Milk += producedMilk;
            Debug.Log($"{Name} produced {producedMilk} liters of milk.");
            return $"{Name} produced {producedMilk} liters of milk.";
        }
        else
        {
            Debug.Log($"{Name} is not happy enough to produce milk.");
            return $"{Name} is not happy enough to produce milk.";
        }
    }
}
