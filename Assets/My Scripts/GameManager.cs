using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
        // Instantiate สัตว์
        Chicken chicken = Instantiate(chickenPrefab);
        Cow cow = Instantiate(cowPrefab);
        Cat cat = Instantiate(catPrefab);

        // ตั้งชื่อ + ค่าเริ่มต้นเพิ่มเติม (ไม่บังคับเพราะ Awake จะมี default)
        // chicken.Init("KFC", 50, 60);
        // cow.Init("Tangmo", 40, 70);
        // cat.Init("Cat", 30, 80);

        // เก็บใน List
        animals.Add(chicken);
        animals.Add(cow);
        animals.Add(cat);
    }

    public void RunGame()
    {
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Feed("Dead Spider", 20);
            animal.GetStatus();
        }
    }
}
