using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoSpaceship()
    {
        SceneManager.LoadScene("SpaceShip");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
