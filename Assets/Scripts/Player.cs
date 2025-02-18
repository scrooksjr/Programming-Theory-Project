using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ENCAPSULATION

    private int health;

    // Getter and Setter for health.
    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); } // Ensure health stays between 0 and 100.
    }


    // Start is called before the first frame update
    void Start()
    {
        Health = 50; // Setting initial health.
        Debug.Log("Player Health: " +  Health);
    }
}
