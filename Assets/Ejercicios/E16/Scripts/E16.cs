using UnityEngine;

public class E16 : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(1, -1, 0) * Time.deltaTime;
    }
}
