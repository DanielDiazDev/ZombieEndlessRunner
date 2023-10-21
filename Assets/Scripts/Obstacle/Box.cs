using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour //Usar si habra algo especial en la caja
{
    public  event Action OnPlayerDeath;

   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnPlayerDeath?.Invoke();
        }
    }
}
