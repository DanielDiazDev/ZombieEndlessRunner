using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] private GameObject _deathScreen;
    [SerializeField] private PlayerDeathEventDispatcher _deathController;
    [SerializeField] private GameObject _score;
    private void OnEnable()
    {
        PlayerDeathEventDispatcher.OnPlayerDeath += ShowDeathScreen;
    }
    private void OnDisable()
    {
        PlayerDeathEventDispatcher.OnPlayerDeath-= ShowDeathScreen;

    }

    private void ShowDeathScreen()
    {
        _deathScreen.SetActive(true);
        _score.SetActive(false);
    }
 

}
