using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;

    private float rotationMars = 70f;
    private float rotationJupiter = 30f;
    private float rotationSaturn = 50f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Mars.transform.Rotate(0, rotationMars * Time.deltaTime, 0);
        Jupiter.transform.Rotate(0, -rotationJupiter * Time.deltaTime, 0);
        Saturn.transform.Rotate(0, rotationSaturn * Time.deltaTime, 0);
    }
}

