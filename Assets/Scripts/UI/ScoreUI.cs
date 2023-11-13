using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private void OnEnable()

    {
        KilometreJourney.OnKilometreJourney += ShowScore;
    }
    

    public void ShowScore(float score)
    {
        _scoreText.text = score.ToString("F0");
    }

    private void OnDisable()
    {
        KilometreJourney.OnKilometreJourney -= ShowScore;

    }

}
