using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private DeathController _deathController;

    private void Start()
    {
        _deathController = GameObject.FindGameObjectWithTag("DeathController").GetComponent<DeathController>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _deathController.PlayerDead();
        }
    }
}
