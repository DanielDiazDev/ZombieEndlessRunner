using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivePlatform : MonoBehaviour
{
    [SerializeField] private Transform _endPosition;
    [SerializeField] private GameObject _platform;
    [SerializeField] private float _distanceExpected;
    private bool _levelDone;
    private Transform _playerPosition;

    private void Start()
    {
        _playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().transform;
    }
    private void Update()
    {
        float distance = Vector3.Distance(_playerPosition.position, _endPosition.position); // Usar qrts
        if (distance > _distanceExpected && _levelDone)
        {
            _platform.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //Separar esto para que este en cada platform y que si lo toca llamar a un evento a DesactivePlatform
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Lo paso");
            _levelDone = true;
        }
    }
}
