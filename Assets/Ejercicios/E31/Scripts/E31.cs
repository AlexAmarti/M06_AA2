using UnityEngine;

public class E31 : MonoBehaviour
{
    public float speed = 5f;
    public Color insideColor = Color.red;

    SpriteRenderer sr;
    Color originalColor;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;
    }

    void Update()
    {
        float h = 0f;
        if (Input.GetKey(KeyCode.A)) h = -1;
        if (Input.GetKey(KeyCode.D)) h = 1;

        transform.position += Vector3.right * h * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        sr.color = insideColor;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        sr.color = originalColor;
    }
}
