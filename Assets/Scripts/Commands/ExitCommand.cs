using UnityEngine;

public class ExitCommand : ICommand
{
    public void Execute()
    {
        Application.Quit();
    }
}

