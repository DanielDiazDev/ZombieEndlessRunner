using System;
using TMPro;
using UnityEngine;

public class GameStarter: MonoBehaviour
{
    [SerializeField] private GameObject _start;
    [SerializeField] private TextMeshProUGUI _highscoreText;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private AudioClip _audioClip;
    public static event Action<bool> OnStarted;
   
    private void Start()
    {
        _highscoreText.text = PlayerPrefs.GetFloat("highScore",0).ToString("F0");
    }
    private void OnEnable()
    {
        ScoreSystem.OnScore += UpdateScore;
    }
    private void OnDisable()
    {
        ScoreSystem.OnScore -= UpdateScore;
    }
    public void InitTime()
    {
        SoundController.Instance.PlaySound(_audioClip);
        _start.SetActive(false);
        bool isStarted = true;
        OnStarted?.Invoke(isStarted);
    }
    private void UpdateScore(float score)
    {
        _scoreText.text = score.ToString("F0");
    }
    
}
