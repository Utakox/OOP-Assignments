using JetBrains.Annotations;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string name;

    private int hunger;

    private int happiness;


    public string Name
    {
        get { return name;}
        private set { name = value; }
    }

    public int Hunger
    {
        get { return hunger; }
        private set { hunger = value; }
    }

    public int Happiness
    {
        get { return happiness; }
        private set { happiness = value; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        public virtual void Init(string newName, int newHunger, int newHappiness)
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
