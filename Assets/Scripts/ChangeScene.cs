using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //For changing to various scenes
    public void ToStartRoom()
    {
        SceneManager.LoadScene("startRoom");
    }

    public void ToDreamscape()
    {
        SceneManager.LoadScene("dreamscape");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void ToNightmare()
    {
        SceneManager.LoadScene("nightmare");
    }

    public void ToTutorial2()
    {
        SceneManager.LoadScene("tutorial2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
