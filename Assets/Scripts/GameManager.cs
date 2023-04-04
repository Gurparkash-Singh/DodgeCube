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

    public void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Enemy")
        {
            endConditions();
        }
    }

    public void endConditions()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
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
            Debug.Log("You Win!");
            SceneManager.LoadScene("win");
        }
    }
}
