using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathEventDispatcher : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    public static event Action OnPlayerDeath;
    private bool _isDead;

    private void Update()
    {
        if (_isDead)
        {
            OnPlayerDeath?.Invoke();
        }
    }

    public void PlayerDead()
    {
        _isDead = true;
        SoundController.Instance.PlaySound(_audioClip);
    }
}
