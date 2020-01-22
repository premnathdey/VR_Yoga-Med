using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public string newYOGA1;
    public string newYOGA2;
    public string newYOGA3;

    public void YOGA1()
    {
        SceneManager.LoadScene(newYOGA1);
    }
    public void YOGA2()
    {
        SceneManager.LoadScene(newYOGA2);
    }

    public void YOGA3()
    {
        SceneManager.LoadScene(newYOGA3);
    }
    public void EXIT()
    {
        Application.Quit();
    }
}
