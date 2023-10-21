using System;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreSystem : MonoBehaviour
{
    private static float _highscore;
    private float _score;
    [SerializeField] private KilometreJourney _kilometreJourney;
    StartGame startGame;
    private bool _isStarted;
    public event Action<float> OnScore;

    private void OnEnable()
    {
        startGame = GameObject.FindGameObjectWithTag("Start").GetComponent<StartGame>();
        startGame.OnStarted += Started;
    }
    

    private void Started(bool obj)
    {
        _isStarted = obj;
    }

    private void Update()
    {
        _score = _kilometreJourney.GetKM();
        OnScore?.Invoke(_score);
        if (_isStarted)
        {
            if (_score > _highscore)
            {
                _highscore = _score;
            }
            PlayerPrefs.SetFloat("highScore", _highscore);
            PlayerPrefs.Save();
        }
        
    }

    public float GetHighscore()
    {
       return PlayerPrefs.GetFloat("highScore", 0);
    }
    public float GetScore()
    {
        return _score;
    }


}
