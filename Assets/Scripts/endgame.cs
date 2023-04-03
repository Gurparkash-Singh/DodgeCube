using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class endgame : MonoBehaviour
{
    bool gameHasEnded;

    void Start()
    {
        gameHasEnded = false;
    }

    public IEnumerator  WaitForFunction()
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
}
