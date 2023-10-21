using System;
using TMPro;
using UnityEngine;

public class StartGame: MonoBehaviour
{
    HighScoreSystem highScoreSystem;
    [SerializeField] private GameObject _start;
    [SerializeField] private TextMeshProUGUI _highscoreText;
    [SerializeField] private TextMeshProUGUI _scoreText;
    public event Action<bool> OnStarted;
   
    private void Start()
    {
        _highscoreText.text = PlayerPrefs.GetFloat("highScore",0).ToString("F0");
    }
    private void OnEnable()
    {
        highScoreSystem = GameObject.FindGameObjectWithTag("HighScore").GetComponent<HighScoreSystem>();
        highScoreSystem.OnScore += Scorer;
    }
    private void Update()
    {
       
    }
    public void InitTime()
    {
        _start.SetActive(false);
        bool isStarted = true;
        OnStarted?.Invoke(isStarted);
    }
    private void Scorer(float score)
    {
        _scoreText.text = score.ToString("F0");
    }
    
}
