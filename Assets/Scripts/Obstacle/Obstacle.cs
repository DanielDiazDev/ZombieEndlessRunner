using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private PlayerDeathEventDispatcher _playerDeathEventDispatcher;

    private void Start()
    {
        _playerDeathEventDispatcher = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeathEventDispatcher>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerDeathEventDispatcher.PlayerDead();
        }
    }
}
