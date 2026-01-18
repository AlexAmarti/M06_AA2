using UnityEngine;

public class E10 : MonoBehaviour
{
    void Start()
    {
        float numberA = Random.Range(1f, 10f);
        float numberB = Random.Range(1f, 10f);
        int operation = Random.Range(0, 5);
        float result = 0;

        switch (operation)
        {
            case 0:
                result = numberA + numberB;
                break;
            case 1:
                result = numberA - numberB;
                break;
            case 2:
                result = numberA * numberB;
                break;
            case 3:
                result = numberA / numberB;
                break;
            case 4:
                result = numberA % numberB;
                break;
        }

        Debug.Log(result);
    }
}
