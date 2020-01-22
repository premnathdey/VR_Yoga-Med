using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hk : MonoBehaviour
{
    // Start is called before the first frame update
     public string SampleScene;
    public string YOGA2;

    public string YOGA3;

    public void Red()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Blue()
    {
        SceneManager.LoadScene("YOGA2");
    }
    public void Black()
    {
        SceneManager.LoadScene("YOGA3");
    }
    public void Maroon()
    {
        Application.Quit();
    }
}