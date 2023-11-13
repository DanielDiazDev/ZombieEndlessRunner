using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerDeathAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        PlayerDeathEventDispatcher.OnPlayerDeath += Die;
    }
    private void OnDisable()
    {
        
        PlayerDeathEventDispatcher.OnPlayerDeath -= Die;
    }

    private void Die()
    {
        bool isDie = true;
        _animator.SetBool("IsDeath", isDie);
       

    }
}
