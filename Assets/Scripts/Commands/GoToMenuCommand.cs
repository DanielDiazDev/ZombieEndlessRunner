using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class GoToMenuCommand : ICommand
{
    public void Execute()
    {
        SceneManager.LoadScene("Menu");
    }
}
