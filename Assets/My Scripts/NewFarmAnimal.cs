using System;
using UnityEngine;

public class NewFarmAnimal : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} makes a unique sound!");
    }
}
