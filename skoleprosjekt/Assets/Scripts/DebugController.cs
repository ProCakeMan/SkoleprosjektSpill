using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using UnityEngine.UI;

public class DebugController : MonoBehaviour
{
    public bool showConsole;
    public TMP_InputField inputField;
    public Text viewPort;
    bool showScenes;
    bool showHelp;
    int sceneCount;
    string input;
    string[] scenes;
    public GameObject console;
    public static DebugCommand<float> SET_SPEED;
    public static DebugCommand<float> SET_JUMP_HEIGHT;
    public static DebugCommand<float> SET_SENS_X;
    public static DebugCommand<float> SET_SENS_Y;
    public static DebugCommand SHOW_SCENES;
    public static DebugCommand HELP;
    public List<object> commandList;


    Movement movement;

    Look look;

    private void Start()
    {
        movement = this.gameObject.GetComponent<Movement>();
        look = this.gameObject.GetComponent<Look>();
        sceneCount = SceneManager.sceneCountInBuildSettings;
        scenes = new string[sceneCount];
        for (int i = 0; i < sceneCount; i++)
        {
            scenes[i] = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
        }
    }

    public void OnConsole(InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                showConsole = !showConsole;
                Debug.Log("YES");
                break;
        }
    }

    public void OnReturn(InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                if (showConsole)
                {
                    input = inputField.text;
                    HandleInput();
                    inputField.text = "";
                    input = "";
                }
                break;
        }
    }

    private void Awake()
    {
        SET_SPEED = new DebugCommand<float>("set_speed", "Sets speed value", "set_speed <speed>", (x) =>
        {
            movement.overrideSpeed = x;
        });

        SET_SENS_X = new DebugCommand<float>("set_sens_x", "Sets sensitivity on x axis", "set_sens_x <sens>", (x) =>
        {
            look.sensX = x;
        });

        SET_SENS_Y = new DebugCommand<float>("set_sens_y", "Sets sensitivity on y axis", "set_sens_y <sens>", (x) =>
        {
            look.sensY = x;
        });

        SET_JUMP_HEIGHT = new DebugCommand<float>("set_jump_height", "Sets jump height value", "set_jump_height <jump height>", (x) =>
        {
            movement.jumpHeight = x;
        });

        HELP = new DebugCommand("help", "Shows a list of commands", "help", () =>
        {
            showHelp = true;
        });

        SHOW_SCENES = new DebugCommand("show_scenes", "Shows a list of scenes", "show_scenes", () =>
        {
            showScenes = true;
        });

        commandList = new List<object>
        {
            SET_SPEED,
            SET_SENS_X,
            SET_SENS_Y,
            SET_JUMP_HEIGHT,
            HELP
        };

    }

    Vector2 scroll;

    private void OnGUI()
    {
        if (!showConsole)
        {
            console.SetActive(false);
            look.doLooking = true;
            movement.ui = null;
            movement.uiOpen = false;
            return;
        }

        console.SetActive(true);
        look.doLooking = false;
        movement.ui = console;
        movement.uiOpen = true;

        if (showHelp)
        {
            for (int i = 0; i < commandList.Count; i++)
            {
                DebugCommandBase command = commandList[i] as DebugCommandBase;
                string label = $"{command.commandFormat} - {command.commandDescription}";
                viewPort.text = viewPort.text + "\n" + label;
                Debug.Log(label);
            }
            showHelp = false;
        }
    }

    public void OnCloseGUI()
    {
        showConsole = false;
        OnGUI();
    }
    private void HandleInput()
    {
        string[] properties = input.Split(' ');
        viewPort.text = viewPort.text + "\n" + input;

        for (int i = 0; i < commandList.Count; i++)
        {
            DebugCommandBase commandBase = commandList[i] as DebugCommandBase;

            if (input.Contains(commandBase.commandId))
            {
                if (commandList[i] as DebugCommand != null)
                {
                    (commandList[i] as DebugCommand).Invoke();
                }
                else if (commandList[i] as DebugCommand<float> != null)
                {
                    (commandList[i] as DebugCommand<float>).Invoke(float.Parse(properties[1]));
                }
            }

            else
            {
                if (i+1 == commandList.Count)
                { 
                    viewPort.text = viewPort.text + "\n" + "Invalid Command"; 
                }
            }
        }
    }
}
