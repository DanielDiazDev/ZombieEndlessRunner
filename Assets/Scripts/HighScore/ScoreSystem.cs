using System;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private KilometreJourney _kilometreJourney;
    private static float _highscore;
    private float _score;
    private bool _isStarted;
    public static event Action<float> OnScore;

    private void OnEnable()
    {
        GameStarter.OnStarted += Started;
    }
    private void OnDisable()
    {
        GameStarter.OnStarted -= Started;

    }

    private void Started(bool obj)
    {
        _isStarted = obj;
    }
    private void Start()
    {
       _highscore = PlayerPrefs.GetFloat("highScore", 0);

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
                PlayerPrefs.SetFloat("highScore", _highscore);
                PlayerPrefs.Save();
            }
           
        }
        
    }

    
    public float GetScore()
    {
        return _score;
    }


}
