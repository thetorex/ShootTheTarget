using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;

    Resolution[] allResolution;
    bool isFullscreen;
    int selectedResolution;
    List<Resolution> selectedResolutionList = new List<Resolution>();

    void Start()
    {
        isFullscreen = true;
        allResolution = Screen.resolutions;

        List<string> resolutionStringList = new List<string>();
        string newRes;
        foreach (Resolution res in allResolution)
        {
            newRes = res.width.ToString() + "x" + res.height.ToString();
            if (!resolutionStringList.Contains(newRes))
            {
                resolutionStringList.Add(newRes);
                selectedResolutionList.Add(res);
            }
        }

        resolutionDropdown.AddOptions(resolutionStringList);
    }

    public void ChangeResolution()
    {
        selectedResolution = resolutionDropdown.value;
        Screen.SetResolution(selectedResolutionList[selectedResolution].width, selectedResolutionList[selectedResolution].height, isFullscreen);
    }

    public void ChangeFullscreen()
    {
        isFullscreen = fullscreenToggle.isOn;
        Screen.SetResolution(selectedResolutionList[selectedResolution].width, selectedResolutionList[selectedResolution].height, isFullscreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
