using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    private Button optionsButton;
    private Button backButton;

    private Canvas Menu;
    private Canvas Options;

    // Start is called before the first frame update
    void Start()
    {
        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        optionsButton = GameObject.Find("OptionsButton").GetComponent<Button>();

        backButton.onClick.AddListener(BackButtonClick);
        optionsButton.onClick.AddListener(OptionsClick);

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
