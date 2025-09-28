using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType
    {
        Hay,
        Meat,
        Grain,
        RottenFood,
        AnimalFood,
    }
public abstract class Animal : MonoBehaviour
{
    // ===== Fields =====
    private new string name;
    private int hunger;
    private int happiness;

    protected FoodType preferedFood;

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

    public FoodType PreferedFood
    {
        get { return preferedFood; }
        private set { preferedFood = value; }
    }


    // ===== Methods =====
    public virtual void Init(string name)

    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
        PreferedFood = preferedFood;
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

    public abstract string Produce();


    // Overload Feed
    // public void Feed(int food)
    // {
    //     AdjustHunger(-food);
    //     AdjustHappiness(+5);
    //     Debug.Log($"{Name} is eating {food} units of food!");
    // }

    public void Feed(FoodType foodType, int value)
    {

        if (foodType == PreferedFood)
        {
            Debug.Log($"{Name} loves {foodType}! Gained extra 15 Happiness!");
            AdjustHunger(-value);
            AdjustHappiness(+15);
        }
        else if (foodType == FoodType.RottenFood)
        {
            Debug.Log($"{Name} is eating {foodType}! Lost 20 Happiness!");
            AdjustHappiness(-20);
        }

        else if (foodType == FoodType.AnimalFood)
        {
            Debug.Log($"{Name} is eating normal {foodType}. Gained extra 5 Happiness!");
            AdjustHunger(-value);
            AdjustHappiness(+5);

        }





    }

    public virtual void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger} | Happiness: {Happiness}");
    }
}
