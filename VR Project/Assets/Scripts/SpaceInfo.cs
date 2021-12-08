using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceInfo : MonoBehaviour
{
    private Animator anim;
    public GameObject SpaceInfoPanel;
    public GameObject ReturnBack;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
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
            SpaceInfoPanel.SetActive(true);
            ReturnBack.SetActive(true);
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
                else
                {
                    //ReturnSpaceship.SetActive(false);
                    SpaceInfoPanel.SetActive(false);
                    ReturnBack.SetActive(false);
                }
            }
        }
    }
    public void ReturnSolarSystem()
    {
        Debug.Log("Go back to space");
        SceneManager.LoadScene("SpaceShip");
    }

}
