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
    }

    public void InitGame()
    {

        Cow cow = Instantiate(cowPrefab);
        Chicken chicken = Instantiate(chickenPrefab);
        Cat cat = Instantiate(catPrefab);

        // สร้างสัตว์แต่ละตัว


        // เก็บใน List
        animals.Add(chicken);
        animals.Add(cow);
        animals.Add(cat);

        chicken.Init("KFC");

        cow.Init("Tangmo");

        cat.Init("Cat");

        Debug.Log($"There are {animals.Count} animals in the farm.");

        foreach (Animal animal in animals)
        {
            animal.GetStatus();
        }

        Debug.Log("-- Feeding animals --");

        cow.Feed(FoodType.Hay, 1);
        chicken.Feed(FoodType.Grain, 1);
        cat.Feed(FoodType.Meat, 1);

        cow.Feed(FoodType.RottenFood, 1);

        cow.Produce();
        cow.Feed(FoodType.Hay, 1);
        cow.Feed(FoodType.Hay, 1);
        cow.Produce();

        chicken.Produce();
        chicken.Feed(FoodType.Grain, 1);
        chicken.Feed(FoodType.AnimalFood, 1);
        chicken.Feed(FoodType.Grain, 1);
        chicken.Produce();
        chicken.Feed(FoodType.RottenFood, 1);

        cat.Feed(FoodType.Meat, 1);
        cat.Feed(FoodType.Meat, 1);
        cat.Produce();
        cat.Feed(FoodType.RottenFood, 1);
        cat.Feed(FoodType.RottenFood, 1);
        cat.Produce();



        foreach (Animal animal in animals)
        {
            animal.GetStatus();
        }
    }
        

}
