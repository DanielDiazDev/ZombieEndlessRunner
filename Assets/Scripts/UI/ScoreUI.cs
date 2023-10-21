using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private KilometreJourney _kilometreJourney;
    private void OnEnable()

    {
        _kilometreJourney = GameObject.FindGameObjectWithTag("Player").GetComponent<KilometreJourney>();
        _kilometreJourney.OnKilometreJourney += ShowScore;
    }

    public void ShowScore(float score)
    {
        _scoreText.text = score.ToString("F0");
    }

    private void OnDisable()
    {
        _kilometreJourney.OnKilometreJourney -= ShowScore;

    }

}
