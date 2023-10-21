using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    //Agregar musica
    [SerializeField] private GameObject _deathScreen;
    [SerializeField] private DeathController _deathController;
    private void Start()
    {

        _deathController.OnPlayerDeath += ShowDeathScreen;
        
    }
    
    private void ShowDeathScreen()
    {
        _deathScreen.SetActive(true);      
    }
    private void OnDestroy()
    {
        

    }

}
