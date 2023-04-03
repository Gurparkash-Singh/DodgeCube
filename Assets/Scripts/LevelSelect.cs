using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private AudioSource error;

    public void level_1(){

        // if statement pertruding to main character where if they have a value higher than the level value then they are transported to the new level
        SceneManager.LoadScene("SampleScene");
        //else statement that if that doesnt work then we get an error sound
        error.Play();
    }

}
