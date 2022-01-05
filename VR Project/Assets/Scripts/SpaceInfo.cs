using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SpaceInfo : MonoBehaviour
{
    private Animator anim;
    public GameObject CommandPanel;
    public GameObject InfoPanel;
    public TextMeshProUGUI arrivalText;

    private GameObject currentPlanet;
    private string chosenPlanet;

    public List<GameObject> planetsPrefab;
    public Transform planetPosition;

    public List<Sprite> planetImages;
    private Sprite currentInfo;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        chosenPlanet = SpaceShip.chosenPlanet;

        foreach (GameObject planets in planetsPrefab)
        {
            if (planets.name == chosenPlanet)
            {
                currentPlanet = planets;
            }
        }
        Debug.Log("Current planet: " + currentPlanet.name);
        Instantiate(currentPlanet, planetPosition);

        arrivalText.text = "We can't land on "+chosenPlanet+" ,it's too dangerous";


        foreach (Sprite planetsInfo in planetImages)
        {
            if (planetsInfo.name == chosenPlanet+"Info")
            {
                currentInfo= planetsInfo;
            }
        }
        InfoPanel.GetComponent<Image>().sprite = currentInfo;
    }


    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {  //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
            //Debug.Log("playing");
        }
        else
        {
            if (InfoPanel.activeSelf == false)
            {
                CommandPanel.SetActive(true);
            }
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Jupiter")
                {
                    Debug.Log("It's Jupiter");
                }

            }
        }
    }
    public void ReturnSolarSystem()
    {
        Debug.Log("Go back to space");
        SceneManager.LoadScene("SpaceShip");
    }
    public void DisplayInfo()
    {
        CommandPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }
    public void ReturnToCommand()
    {
        InfoPanel.SetActive(false);
        CommandPanel.SetActive(true);
    }


}
