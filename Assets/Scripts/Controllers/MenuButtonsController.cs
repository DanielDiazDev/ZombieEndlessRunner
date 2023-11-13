using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsController : MonoBehaviour
{
    private ICommand _goToMenuCommand;
    private ICommand _resetGameCommand;
    private ICommand _goToGameCommand;
    private ICommand _exitCommand;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private GameObject _optionsWindow;

    private void Start()
    {
        _goToMenuCommand = new GoToMenuCommand();
        _resetGameCommand = new ResetGameCommand();
        _goToGameCommand = new GoToGameCommand();
        _exitCommand = new ExitCommand();
    }
    public void GoToMenu()
    {
        SoundController.Instance.PlaySound(_audioClip);
        _goToMenuCommand.Execute();
    }
    public void ResetGame()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _resetGameCommand.Execute();
    }
    public void GoToGame()
    {
        SoundController.Instance.PlaySound(_audioClip);
        _goToGameCommand.Execute();
    }
    public void Exit()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _exitCommand.Execute();
    }
    public void GoToOptions()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _optionsWindow.SetActive(true);
    }
    public void GoToCloseOptions()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _optionsWindow.SetActive(false);
    }


}
