using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class GameManager : MonoBehaviour
{
    // ให้ Unity Inspector มองเห็น List

    public Chicken chickenPrefab;
    public Cow cowPrefab;

    public Cat catPrefab;
    public List<Animal> animals = new List<Animal>();

    void Start()
    {
        InitGame();
        RunGame();
    }

    public void InitGame()
    {

        Cow cow = Instantiate(cowPrefab);
        Chicken chicken = Instantiate(chickenPrefab);
        Cat cat = Instantiate(catPrefab);

        // สร้างสัตว์แต่ละตัว
        chicken.Init("KFC", 50, 60);


        cow.Init("Tangmo", 40, 70);

        cat.Init("Cat", 30, 80);


        // เก็บใน List
        animals.Add(chicken);
        animals.Add(cow);
        animals.Add(cat);
        
        Debug.Log($"There are {animals.Count} animals in the farm.");
    }

    public void RunGame()
    {
        // ใช้ foreach loop
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Feed("Dead Spider", 20);
        }
        foreach (Animal animal in animals)
        {
            animal.GetStatus();
        }
    }
}
