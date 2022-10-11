using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloWorldScriptTwo : MonoBehaviour
{
    public Button nextButton;
    
    void Start()
    {
        nextButton.onClick.AddListener(Press);
    }

    public void Press()
    {
        SceneManager.LoadScene("Scene02");
    }

    public void QuitGame()
    {
        Application.Quit(); //Funktioniert nur beim Exportierten des Spieles
    }
}