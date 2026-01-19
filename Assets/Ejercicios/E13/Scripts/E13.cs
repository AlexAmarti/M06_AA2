using UnityEngine;

public class E13 : MonoBehaviour
{
    void Start()
    {
        int count = 0;

        while (count < 100)
        {
            Debug.Log(Random.Range(0, 100));
            count++;
        }
    }
}
