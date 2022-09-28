using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloWorldScriptTwo : MonoBehaviour
{
    public Button NextButton;
    
    void Start()
    {
        NextButton.onClick.AddListener(press);
    }

    public void press()
    {
        SceneManager.LoadScene("Scene02");
    }

    public void QuitGame()
    {
        Application.Quit(); //Funktioniert nur beim Exportierten des Spieles
    }
}