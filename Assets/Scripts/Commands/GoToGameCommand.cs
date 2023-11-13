using UnityEngine.SceneManagement;

public class GoToGameCommand : ICommand
{
    public void Execute()
    {
        SceneManager.LoadScene("Game");
    }
}

