using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WrestlerHealth : MonoBehaviour
{
    public UnityEvent TakeDamage;
    // public GlobalInteger Health;
    int counter = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter <= 10)
        {
            counter++;
        }
        else
        {
            TakeDamage.Invoke();
        }
    }
}
