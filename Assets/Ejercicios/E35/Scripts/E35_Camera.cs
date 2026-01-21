using UnityEngine;

public class E35_Camera : MonoBehaviour
{
    public Transform target;
    public float maxSpeed = 5f;

    void LateUpdate()
    {
        Vector3 targetPos = new Vector3(
            target.position.x,
            target.position.y,
            -10
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPos,
            maxSpeed * Time.deltaTime
        );
    }
}
