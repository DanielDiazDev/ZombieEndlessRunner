using UnityEngine;
using UnityEngine.SceneManagement;

public class MenusButton : MonoBehaviour
{
    //Ver si usar command o otro patron
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
