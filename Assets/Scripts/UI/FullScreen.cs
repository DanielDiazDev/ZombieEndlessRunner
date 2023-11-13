using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public void FullScreenExecute(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }


}
