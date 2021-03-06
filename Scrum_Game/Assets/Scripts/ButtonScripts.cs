﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    private Button optionsButton;
    private Button backButton;
    private Button exitButton;
    private Button playButton;
    private Button backButton2;

    private Canvas Menu;
    private Canvas Options;
    private Canvas minigameMenu;

    // Start is called before the first frame update
    void Start()
    {
        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        optionsButton = GameObject.Find("OptionsButton").GetComponent<Button>();
        exitButton = GameObject.Find("ExitButton").GetComponent<Button>();
        playButton = GameObject.Find("PlayButton").GetComponent<Button>();
        backButton2 = GameObject.Find("BackButton2").GetComponent<Button>();

        backButton.onClick.AddListener(BackButtonClick);
        optionsButton.onClick.AddListener(OptionsClick);
        exitButton.onClick.AddListener(QuitGame);
        playButton.onClick.AddListener(onPlayClick);
        backButton2.onClick.AddListener(BackButtonClick);

        Menu = GameObject.Find("MenuUI").GetComponent<Canvas>();
        Options = GameObject.Find("OptionsUI").GetComponent<Canvas>();
        minigameMenu = GameObject.Find("GameTypeUI").GetComponent<Canvas>();

        minigameMenu.enabled = false;
        Menu.enabled = true;
        Options.enabled = false;
    }

    private void onPlayClick()
    {
        minigameMenu.enabled = true;
        Menu.enabled = false;
        Options.enabled = false;
    }

    private void BackButtonClick()
    {
        minigameMenu.enabled = false;
        Menu.enabled = true;
        Options.enabled = false;
    }

    private void OptionsClick() // Function is called when the Options button is clicked
    {
        minigameMenu.enabled = false;
        Menu.enabled = false;
        Options.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

}
