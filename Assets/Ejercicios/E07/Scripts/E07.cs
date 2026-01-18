using UnityEngine;

public class E07 : MonoBehaviour
{
    public float numberA;
    public float numberB;
    public string operation;

    void Start()
    {
        float result = 0;

        switch (operation)
        {
            case "+":
                result = numberA + numberB;
                break;
            case "-":
                result = numberA - numberB;
                break;
            case "*":
                result = numberA * numberB;
                break;
            case "/":
                result = numberA / numberB;
                break;
            case "%":
                result = numberA % numberB;
                break;
        }

        Debug.Log(result);
    }
}
