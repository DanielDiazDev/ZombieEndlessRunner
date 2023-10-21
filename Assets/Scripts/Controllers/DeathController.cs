using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    public event Action OnPlayerDeath;
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
    }
}
