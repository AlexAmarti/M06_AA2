using UnityEngine;

public class E29 : MonoBehaviour
{
    public GameObject boxPrefab;

    void Start()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPos = new Vector3(randomX, 5f, 0f);

        Instantiate(boxPrefab, spawnPos, Quaternion.identity);
    }
}
