using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("MENU");
    }
    // Update is called once per frame
    public void quitg()
    {
     Application.Quit();
    }
}
