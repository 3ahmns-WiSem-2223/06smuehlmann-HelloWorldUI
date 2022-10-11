using UnityEngine;
using UnityEngine.UI;

public class HelloWorldScriptThree : MonoBehaviour
{

    public int number;
    public Text numberText;

    public void Plus()
    {
        number++;
    }

    public void Minus()
    {
        number--;
    }

    public void Clear()
    {
        number = 0;
    }

    void Update()
    {
        numberText.text = number.ToString();
    }
}
