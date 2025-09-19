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

    public override void MakeSound()
    {
        Moo();
    }

    public void Moo()
    {
        Debug.Log($"{Name} says: Moo");
    }
}
