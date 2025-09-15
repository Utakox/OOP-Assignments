using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // create objects
        Chicken chicken = new Chicken("KFC", 50, 50, 0); // <-- แก้นี้
        Cow cow = new Cow("MooMoo", 50, 50, 0); // <-- แก้นี้

        // แสดงค่าเริ่มต้น
        chicken.GetStatus();
        cow.GetStatus();

        // เริ่มเกม
        Debug.Log("---- Gameplay Start ----");

        chicken.MakeSound();
        chicken.Feed("Corn");
        chicken.Sleep();
        chicken.AdjustHunger(15);
        chicken.AdjustHappiness(-5);

        cow.MakeSound();
        cow.Feed("Grass");
        cow.Sleep();
        cow.AdjustHunger(-20);
        cow.AdjustHappiness(10);

        // แสดงค่าหลัง start
        Debug.Log("---- After Actions ----");
        chicken.GetStatus();
        cow.GetStatus();
    }
}
