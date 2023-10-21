using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Rigidbody2D _rigidbody;
    private bool _isDie;
    [SerializeField] private DeathController _dearhController;
    [SerializeField] private Animator _animator;
    private StartGame startGame;
    private bool _isStarted;
    private void OnEnable()
    {
        startGame = GameObject.FindGameObjectWithTag("Start").GetComponent<StartGame>();
        startGame.OnStarted += Started;
    }
    private void OnDisable()
    {
        startGame.OnStarted -= Started;
    }

    private void Started(bool obj)
    {
        _isStarted = obj;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _dearhController.OnPlayerDeath += StopMove;
    }
    private void FixedUpdate()
    {
        if (!_isDie)
        {
            Move();
        }
        _animator.SetFloat("Horizontal", _rigidbody.velocity.x);

    }

    private void Move()
    {
        if (_isStarted)
        {
            _rigidbody.velocity = new Vector2(_movementSpeed, _rigidbody.velocity.y);
        }

    }
    private void StopMove()
    {
        _isDie = true;
        _rigidbody.velocity = Vector2.zero;
       
    }
}
