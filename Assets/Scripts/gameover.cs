using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    public void quitg()
    {
     Application.Quit();
    }
    public void levelselectionmenu()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void optionsmenu()
    {
        SceneManager.LoadScene("options");
    }
}
