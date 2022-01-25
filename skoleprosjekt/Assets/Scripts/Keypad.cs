using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    [SerializeField] GameObject ui;

    [SerializeField] TMP_Text inputField;

    public GameObject door;

    public GameObject endPortal;

    public string code;

    string text;

    bool uiActive;

    bool canType = true;
    

    Look lookScript;




    public void Run(Look look)
    {
        ui.SetActive(true);
        uiActive = true;
        lookScript = look;
        lookScript.doLooking = false;
    }

    public void Close()
    {
        Clear();
        ui.SetActive(false);
        uiActive = false;
        lookScript.doLooking = true;
    }

    public void Input(string input)
    {
        Debug.Log("Input");
        if (canType)
        {
            text = inputField.text;
            inputField.SetText(text + input);
            if (inputField.text.Length == 4)
            {
                canType = false;
            }
        }
    }

    public void checkCode()
    {
        if (inputField.text == code)
        {
            door.GetComponent<Activate>().Trigger(true);
            endPortal.GetComponent<Portal>().makeActive();
            Close();
        }
        else
        {
            Clear();
        }
    }

    public void Clear()
    {
        inputField.text = "";
        canType = true;
    }
}
