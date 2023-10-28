using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public float floatStrenghth;
    public float floatSpeed;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = initialPosition + new Vector3(0.0f, Mathf.Sin(Time.time * floatSpeed) * floatStrenghth, 0.0f);
    }
}
