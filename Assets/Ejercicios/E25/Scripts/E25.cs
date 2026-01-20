using UnityEngine;

public class E25 : MonoBehaviour
{
    public float force = 5f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}
