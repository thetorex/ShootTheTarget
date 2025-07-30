using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    // Değişken tanımlamaları
    public TMP_Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;

    Resolution[] allResolution;
    bool isFullscreen;
    int selectedResolution;
    List<Resolution> selectedResolutionList = new List<Resolution>();

    void Start()
    {
        isFullscreen = true; // tam ekranda başlatma 
        allResolution = Screen.resolutions; // bilgisayardan çözünürlük verisi çekme 

        List<string> resolutionStringList = new List<string>();
        string newRes;
        foreach (Resolution res in allResolution) // çözünürlük paketinin açılması
        {
            newRes = res.width.ToString() + "x" + res.height.ToString(); // çözünürlük tipini istediğimiz formata getirme 
            if (!resolutionStringList.Contains(newRes))
            {
                resolutionStringList.Add(newRes); 
                selectedResolutionList.Add(res);
            }
        }

        resolutionDropdown.AddOptions(resolutionStringList);
    }

    public void ChangeResolution() // çözünürlüğü değiştirme
    {
        selectedResolution = resolutionDropdown.value;
        Screen.SetResolution(selectedResolutionList[selectedResolution].width, selectedResolutionList[selectedResolution].height, isFullscreen);
    }

    public void ChangeFullscreen() // tam ekranı değiştirme 
    {
        isFullscreen = fullscreenToggle.isOn;
        Screen.SetResolution(selectedResolutionList[selectedResolution].width, selectedResolutionList[selectedResolution].height, isFullscreen);
    }
}
