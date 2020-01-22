using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu1 : MonoBehaviour
{
    public Button BYOGA1;

    public Button BYOGA2;

    public Button BYOGA3;

    public Button BEXIT;

    public string newYOGA1, newYOGA2, newYOGA3;

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