using UnityEngine;

public class GoToPauseCommand : ICommand
{
    public void Execute()
    {
        Time.timeScale = 0f;
    }

}
