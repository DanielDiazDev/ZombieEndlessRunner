using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton; 

    public void Pause()
    {
        Time.timeScale = 0f;
        _pauseButton.SetActive(false);
        _pauseMenu.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        _pauseButton.SetActive(true);
        _pauseMenu.SetActive(false);
    }
    public void Reset()
    {

        Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Ussar command
      //  _pauseButton.SetActive(true);
     //   _pauseMenu.SetActive(false);
    }
     public void Exit()
    {

        Time.timeScale = 1f;

        SceneManager.LoadScene("Menu");
        //  _pauseButton.SetActive(true);
        //   _pauseMenu.SetActive(false);
    }

}
