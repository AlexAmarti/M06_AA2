using UnityEngine;

public class E20 : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float x = 0;
        float y = 0;

        if (Input.GetKey(KeyCode.W)) y = 1;
        if (Input.GetKey(KeyCode.S)) y = -1;
        if (Input.GetKey(KeyCode.A)) x = -1;
        if (Input.GetKey(KeyCode.D)) x = 1;

        Vector3 direction = new Vector3(x, y, 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
