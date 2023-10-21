using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{  
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }
}
