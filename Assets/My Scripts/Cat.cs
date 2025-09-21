using System;
using UnityEngine;



public class Cat : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} Meow");
    }
}
