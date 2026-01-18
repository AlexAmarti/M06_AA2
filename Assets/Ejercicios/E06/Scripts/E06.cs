using UnityEngine;

public class E06 : MonoBehaviour
{
    public int numberA;
    public int numberB;
    public int numberC;

    void Start()
    {
        int average = (numberA + numberB + numberC) / 3;
        Debug.Log(average);
    }
}
