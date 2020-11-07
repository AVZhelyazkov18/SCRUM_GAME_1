using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadGame : MonoBehaviour
{
    private Button catchGame = null;

    // Start is called before the first frame update
    void Start()
    {
        catchGame = GameObject.Find("Choice1").GetComponent<Button>();
        catchGame.onClick.AddListener(startCatchGame);
    }

    void startCatchGame()
    {
        Debug.Log("Starting the game!");
        SceneManager.LoadScene("FishGame");
    }
}
