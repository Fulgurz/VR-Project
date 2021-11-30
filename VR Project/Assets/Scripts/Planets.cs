using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Earth;
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Uranus;
    public GameObject Neptune;

    public float rotationMars = 70f;
    public float rotationJupiter = 30f;
    public float rotationSaturn = 50f;
    public float rotationEarth = 30f;
    public float rotationMercury = 70f;
    public float rotationVenus = 30f;
    public float rotationUranus = 50f;
    public float rotationNeptune = 30f;


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
        Earth.transform.Rotate(0, rotationEarth * Time.deltaTime, 0);
        Mercury.transform.Rotate(0, rotationMercury * Time.deltaTime, 0);
        Venus.transform.Rotate(0, -rotationVenus * Time.deltaTime, 0);
        Uranus.transform.Rotate(0, rotationUranus * Time.deltaTime, 0);
        Neptune.transform.Rotate(0, rotationNeptune * Time.deltaTime, 0);
    }
}

