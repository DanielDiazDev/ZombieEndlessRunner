using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private DeathController _dearhController;
    [SerializeField] private Animator _animator;
    private void Start()
    {
        _dearhController.OnPlayerDeath += Die;
    }

    private void Die()
    {
        bool isDie = true;
        _animator.SetBool("IsDeath", isDie);
       

    }
}
