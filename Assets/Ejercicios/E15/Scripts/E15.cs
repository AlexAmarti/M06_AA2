using UnityEngine;

public class E15 : MonoBehaviour
{
    void Start()
    {
        int winsA = 0;
        int winsB = 0;

        while (winsA < 5 && winsB < 5)
        {
            int a = Random.Range(1, 4);
            int b = Random.Range(1, 4);

            if (a == b) continue;

            if (a == 1 && b == 3 ||
                a == 2 && b == 1 ||
                a == 3 && b == 2)
                winsA++;
            else
                winsB++;
        }

        Debug.Log("Winner: " + (winsA == 5 ? "Player A" : "Player B"));
    }
}
