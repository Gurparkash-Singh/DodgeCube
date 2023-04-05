using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youwin : MonoBehaviour
{
    public void main()
    {
        SceneManager.LoadScene("MENU");
    }
    public void quitg()
    {
     Application.Quit();
    }
    public void next()
    {

        SceneManager.LoadScene("SampleScene");
        
    }
}

