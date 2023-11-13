using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Resolutions : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _resDropdown;
    private List<Resolution> _importantResolutions;
    private void Awake()
    {
        Screen.SetResolution(1920, 1080, Screen.fullScreen);
        _importantResolutions = new List<Resolution>()
        {
            new Resolution { width = 1920, height = 1080 }, // Full HD
            new Resolution { width = 1280, height = 720 },  // HD
            new Resolution { width = 2560, height = 1440 }, // 2K
            new Resolution { width = 3840, height = 2160 }, // 4K
            new Resolution { width = 1280, height = 1024 }
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        
        _resDropdown.ClearOptions();
        var options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < _importantResolutions.Count; i++)
        {
            var option = _importantResolutions[i].width + "x" + _importantResolutions[i].height;
            options.Add(option);
            if (_importantResolutions[i].width == Screen.currentResolution.width && _importantResolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        _resDropdown.AddOptions(options);
        _resDropdown.value = currentResolutionIndex;
        _resDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        var resolution = _importantResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
