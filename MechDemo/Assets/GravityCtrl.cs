using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCtrl : MonoBehaviour
{

    //attach to rigidbodies to orbit planet
    public GravityOrbit Gravity;
    private Rigidbody Rb;

    public float RotationSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if ther is a planet to orbit
        if (Gravity)
        {
            Vector3 gravityUp = Vector3.zero;

            if (Gravity.FixedDirection)
            {
                gravityUp = Gravity.transform.up;

            }
            else
            {

                gravityUp = (transform.position - Gravity.transform.position).normalized;

            }
            Vector3 localUp = transform.up;

            Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;

            transform.up = Vector3.Lerp(transform.up, gravityUp, RotationSpeed * Time.deltaTime);

            //push down for gravity
            Rb.AddForce((-gravityUp * Gravity.Gravity) * Rb.mass);
        }
    }
}
