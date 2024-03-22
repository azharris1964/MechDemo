using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Planet : MonoBehaviour
{
    [SerializeField] float minScale = 1.2f;
    [SerializeField] float maxScale = 10.5f;
    [SerializeField] float rotationOffset = 100f;


    Transform myT;
    Vector3 randomRotation;

    void Awake()
    {
        myT = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        //randomsize
        float size = Random.Range(minScale, maxScale);

        Vector3 scale = Vector3.one;
        scale.x = size;
        scale.y = size;
        scale.z = size;

        myT.localScale = scale;

        //random rotation
        randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.z = Random.Range(-rotationOffset, rotationOffset);
    }

    // Update is called once per frame
    void Update()
    {
        myT.Rotate(randomRotation*Time.deltaTime);
    }

}
