using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelObj : Jetpack
{
    public GameObject player;
    public GameObject fuelCap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PickUpSystem()
    {
        if(player == fuelCap)
        {
            jetFuel += 500f;
        }
    }
}
