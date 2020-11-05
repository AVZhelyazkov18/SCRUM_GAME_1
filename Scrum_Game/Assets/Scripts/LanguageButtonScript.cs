using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class LanguageButtonScript : MonoBehaviour
{
    private Button btn; // The Language Button
    
    void Start()
    {
        btn = GameObject.Find("LanguageButton").GetComponent<Button>();
        btn.onClick.AddListener(ButtonOnClick);
    }

    void ButtonOnClick() // When The Language Button has been Clicked
    {
        Debug.Log("Language button clicked!");
        Text t = btn.GetComponentInChildren<Text>();
        if(t.text == "EN")
        {
            t.text = "BG";
        } else
        {
            t.text = "EN";
        }
    }
}
