using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
 
  public void ChangeVolume(float volume)
  {
   audioMixer.SetFloat("Volume", volume);
  }

  public void Back()
  {
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
  }

 
}