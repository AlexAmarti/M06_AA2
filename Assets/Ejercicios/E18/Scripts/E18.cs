using UnityEngine;

public class E18 : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 direction = new Vector3(-1, 1, 0);
        transform.position += direction * speed * Time.deltaTime;
    }
}
