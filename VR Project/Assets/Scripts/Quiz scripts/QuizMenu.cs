using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuizMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SpaceShip");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
