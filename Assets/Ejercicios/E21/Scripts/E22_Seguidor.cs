using UnityEngine;

public class E22 : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speed;

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            speed * Time.deltaTime
        );
    }
}
