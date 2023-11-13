using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private AudioClip _audioClip;
    private ICommand _resumeCommand;
    private ICommand _goToPauseCommand;
    private ICommand _resetGameCommand;
    private ICommand _closePauseommand;

    private void Start()
    {
        _resumeCommand = new ResumeCommand();
        _goToPauseCommand = new GoToPauseCommand();
        _resetGameCommand = new ResetGameCommand();
        _closePauseommand = new ClosePauseCommand();
    }

    public void Pause()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _goToPauseCommand.Execute();
        _pauseButton.SetActive(false);
        _pauseMenu.SetActive(true);
    }
    public void Resume()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _resumeCommand.Execute();
        _pauseButton.SetActive(true);
        _pauseMenu.SetActive(false);
    }
    public void Reset()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _resetGameCommand.Execute();
        Time.timeScale = 1f;


    }
    public void ClsoePause()
    {
        SoundController.Instance.PlaySound(_audioClip);

        _closePauseommand.Execute();
    }

}
