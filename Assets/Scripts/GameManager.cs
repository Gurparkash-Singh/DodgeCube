using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    bool gameHasEnded;

    void Start()
    {
        gameHasEnded = false;
    }

    IEnumerator  WaitForFunction()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game Over Screen");
    }

    public void endConditions()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            StartCoroutine(WaitForFunction());
        }
    }

    public void winConditions()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            if (Level.currentLevel == Level.getLevel())
            {
                Level.setLevel();
            }
            SceneManager.LoadScene("win");
        }
    }
}
