using UnityEngine;

public class E17 : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += new Vector3(-1, -1, 0) * speed * Time.deltaTime;
    }
}
