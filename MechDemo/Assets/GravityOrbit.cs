using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{
    //object center orbits
    public float Gravity;

    //if gravity pushes player down
    public bool FixedDirection;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GravityCtrl>())
        {
            //object has gravity script set this planet
            other.GetComponent<GravityCtrl>().Gravity = this.GetComponent<GravityOrbit>();
        }
    }
}
