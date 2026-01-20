using UnityEngine;

public class E32 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = 0f;
        float v = 0f;

        if (Input.GetKey(KeyCode.A)) h = -1;
        if (Input.GetKey(KeyCode.D)) h = 1;
        if (Input.GetKey(KeyCode.W)) v = 1;
        if (Input.GetKey(KeyCode.S)) v = -1;

        Vector3 movement = new Vector3(h, v, 0);
        transform.position += movement * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ZonaA"))
        {
            Debug.Log("Entered object in ZonaA");
        }
        else if (other.CompareTag("ZonaB"))
        {
            Debug.Log("Entered object in ZonaB");
        }
    }
}
