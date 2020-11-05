using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    private Button optionsButton;
    private Button backButton;
    private Button exitButton;

    private Canvas Menu;
    private Canvas Options;

    // Start is called before the first frame update
    void Start()
    {
        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        optionsButton = GameObject.Find("OptionsButton").GetComponent<Button>();
        exitButton = GameObject.Find("ExitButton").GetComponent<Button>();

        backButton.onClick.AddListener(BackButtonClick);
        optionsButton.onClick.AddListener(OptionsClick);
        exitButton.onClick.AddListener(QuitGame);

        Menu = GameObject.Find("MenuUI").GetComponent<Canvas>();
        Options = GameObject.Find("OptionsUI").GetComponent<Canvas>();

        Menu.enabled = true;
        Options.enabled = false;
    }

    private void BackButtonClick()
    {
        Menu.enabled = true;
        Options.enabled = false;
    }

    private void OptionsClick() // Function is called when the Options button is clicked
    {
        Menu.enabled = false;
        Options.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

}
