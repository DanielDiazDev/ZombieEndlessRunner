using UnityEngine;

public class ResumeCommand : ICommand
{
    public void Execute()
    {
        Time.timeScale = 1f;
    }

}
