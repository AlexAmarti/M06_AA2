using UnityEngine;

public class E08 : MonoBehaviour
{
    public float number;

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(number * i);
        }
    }
}
