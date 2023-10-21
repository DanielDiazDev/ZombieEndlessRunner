using System;
using UnityEngine;

public class Fall : MonoBehaviour
{
    //public event Action OnPlayerDeath;
    

    [SerializeField] private DeathScreen _deathScree;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //OnPlayerDeath?.Invoke();
        }
    }
}
