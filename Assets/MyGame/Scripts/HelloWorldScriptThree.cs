using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorldScriptThree : MonoBehaviour
{

    public int Number;
    public Text NumberText;

    public void plus()
    {
        Number++;
    }

    public void minus()
    {
        Number--;
    }

    public void clear()
    {
        Number = 0;
    }

    void Update()
    {
        NumberText.text = Number.ToString();
    }
}
