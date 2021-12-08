using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAssistant : MonoBehaviour
{

    public GameObject GroundInfoPanel;


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GroundInfoPanel.SetActive(true);
        }
    }
}

