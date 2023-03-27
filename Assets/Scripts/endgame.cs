using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class endgame : MonoBehaviour
{
public IEnumerator  WaitForFunction()
{
   yield return new WaitForSeconds(1f);
   SceneManager.LoadScene("Game Over Screen");
}

bool gameHasEnded = false;
 public void OnTriggerEnter(Collider other){
    if (other.gameObject.tag=="Enemy"){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over");
        StartCoroutine(WaitForFunction());
        }
}
}

}
