using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosePauseCommand : ICommand 
{
    public void Execute()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    
}