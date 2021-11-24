using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour
{
    private string chosenPlanet;
    public Text TextChosen;
    public GameObject PlanetChoice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Mars")
                {
                    Debug.Log("Travelling to the planet " + hit.transform.name);
                    chosenPlanet = "Mars";
                    PlanetChoice.SetActive(true);
                }
                else if (hit.transform.name == "Jupiter")
                {
                    Debug.Log("Travelling to the planet " + hit.transform.name);
                    chosenPlanet = "Jupiter";
                    PlanetChoice.SetActive(true);
                }
                else
                {
                    Debug.Log("This isn't a Planet");

                }
            }
        }
        TextChosen.text = "Travel to " + chosenPlanet + " ?";

    }
    public void TravelPlanet()
    {
        SceneManager.LoadScene(chosenPlanet);
    }
}

