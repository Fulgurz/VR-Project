using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;

    public Text returnText;
    public GameObject ReturnSpaceship;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "SpaceShip")
                {
                    
                    ReturnSpaceship.SetActive(true);
                    returnText.text = "Return to the spaceship ?";
                }
                else
                {
                    ReturnSpaceship.SetActive(false);
                }
            }
        }
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("SpaceShip");
        }
    }

    public void ReturnSpaceShip()
    {
        Debug.Log("Go back to space");
        SceneManager.LoadScene("SpaceShip");
    }
}
