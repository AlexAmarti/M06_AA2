using UnityEngine;

public class E27 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = 0f;

        if (Input.GetKey(KeyCode.A)) horizontal = -1;
        if (Input.GetKey(KeyCode.D)) horizontal = 1;


        Vector3 movement = new Vector3(horizontal, 0, 0);
        transform.position += movement * speed * Time.deltaTime;
    }
}
