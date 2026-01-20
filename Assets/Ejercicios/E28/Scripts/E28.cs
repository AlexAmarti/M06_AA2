using UnityEngine;

public class E28 : MonoBehaviour
{
    public float speed = 5f;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal, 0, 0);
        transform.position += movement * speed * Time.fixedDeltaTime;
    }
}
