using UnityEngine;

public class E21_Seguido : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) direction.y = 1;
        if (Input.GetKey(KeyCode.S)) direction.y = -1;
        if (Input.GetKey(KeyCode.A)) direction.x = -1;
        if (Input.GetKey(KeyCode.D)) direction.x = 1;

        transform.position += direction * speed * Time.deltaTime;
    }
}
