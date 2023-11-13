using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private Vector2 _movementSpeed;
    private Vector2 _offset;
    private Material _material;
    private Rigidbody2D _playerRB;
    // Start is called before the first frame update
    void Awake()
    {
        _material = GetComponent<SpriteRenderer>().material;
        _playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _offset = (_playerRB.velocity.x * 0.1f) * _movementSpeed * Time.deltaTime;
        _material.mainTextureOffset += _offset;
    }
}
