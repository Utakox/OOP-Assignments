using System;
using UnityEngine;



public class Cat : Animal
{
    public override void Init(string name, int hunger, int happiness)
    {
        base.Init(name, hunger, happiness);
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} Meow");
    }

    public override void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger} | Happiness: {Happiness}");
    }
}
