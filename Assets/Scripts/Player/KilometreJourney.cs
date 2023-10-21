using System;
using UnityEngine;

public class KilometreJourney : MonoBehaviour
{
    private float _distanceJourney = 0.0f;
    private Vector3 _previousPosition;
    public event Action<float> OnKilometreJourney;
   
    // Start is called before the first frame update
    void Start()
    {
        _previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceBetweenPocition = Vector3.Distance(transform.position, _previousPosition); //Mejorar esto

        _distanceJourney += distanceBetweenPocition;

        _previousPosition = transform.position;

       // Debug.Log($"Recorrido: {_distanceJourney} KM");

        OnKilometreJourney?.Invoke(_distanceJourney);
    }
    public float GetKM()
    {
        return _distanceJourney;
    }
}
