using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private List<Animal> animals = new List<Animal>();

    public void InitGame()
    {
        // สร้างสัตว์ตามโจทย์
        Chicken chicken = new Chicken();
        chicken.Init("KFC", 50, 60);

        Cow cow = new Cow();
        cow.Init("Tangmo", 40, 70);

        NewFarmAnimal newAnimal = new NewFarmAnimal();
        newAnimal.Init("Mystery", 30, 80);

        animals.Add(chicken);
        animals.Add(cow);
        animals.Add(newAnimal);
    }

    public void RunGame()
    {
        foreach (Animal animal in animals) // 👈 ตรงนี้ใช้ foreach
        {
            animal.MakeSound();
            animal.Feed("special food", 20);
            animal.GetStatus();
        }
    }
}
