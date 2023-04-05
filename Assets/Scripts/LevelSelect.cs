using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private AudioSource error;

    public void selectLevel(int level){

        bool selected = Level.setCurrentLevel(level);
        if (selected)
        {
    
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            error.Play(0);
        }
    }

}
