using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;

    public GameObject player;

    public bool rotate;

    GameObject ui;

    void Start() {
        ui = this.gameObject;
        Screen.lockCursor = false;
    }

    private void Update() {
        if(rotate)
            player.transform.Rotate(0, 50*Time.deltaTime, 0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level02", LoadSceneMode.Single);
        player.GetComponent<Movement>().LoadPlayer();
    }

    public void Settings()
    {
        settingsMenu.SetActive(true);
        ui.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
