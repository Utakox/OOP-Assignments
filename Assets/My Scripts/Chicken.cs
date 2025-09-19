
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

    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck Cluck!");
    }

    public void Sleep()
    {
        AdjustHunger(+5);
        AdjustHappiness(+10);
    }
}
