using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject ui;

    [SerializeField] GameObject pauseMenuUI;

    Resolution[] resolutions;

    public Dropdown resolutionDropdown;

    Look lookScript;

    bool uiActive;

    public Movement movement;


    public void Run(Look look)
    {
        Debug.Log("RUN");
        pauseMenuUI.SetActive(true);
        uiActive = true;
        lookScript = look;
        lookScript.doLooking = false;
    }

    public void Close()
    {
        pauseMenuUI.SetActive(false);
        ui.SetActive(false);
        uiActive = false;
        lookScript.doLooking = true;
    }

    public void Settings()
    {
        pauseMenuUI.SetActive(false);
        ui.SetActive(true);
    }

    public void Back()
    {
        pauseMenuUI.SetActive(true);
        ui.SetActive(false);
    }

    void Start() {
        resolutions = Screen.resolutions;

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && 
               resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.ClearOptions();
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

    }

    public void SetQuality (int qualityIndex)
    {
        Debug.Log(qualityIndex);
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Debug.Log(isFullscreen);
    }

    public void SetResolution (int resolutionIndex)
    {   
        Debug.Log(resolutionIndex);
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }

    public void CloseToMain(GameObject MainMenu)
    {
        MainMenu.SetActive(true);
        ui.SetActive(false);
    }


    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        movement.SavePlayer();
    }
}
