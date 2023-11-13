using UnityEngine.SceneManagement;

public class ResetGameCommand : ICommand
{
    public void Execute()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
