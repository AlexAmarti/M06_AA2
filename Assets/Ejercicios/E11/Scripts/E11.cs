using UnityEngine;

public class E11 : MonoBehaviour
{
    public int playerA;

    void Start()
    {
        int playerB = Random.Range(1, 4);

        Debug.Log("Player A: " + playerA);
        Debug.Log("Player B: " + playerB);

        if (playerA == playerB)
            Debug.Log("Draw");
        else if (playerA == 1 && playerB == 3 ||
                 playerA == 2 && playerB == 1 ||
                 playerA == 3 && playerB == 2)
            Debug.Log("Player A wins");
        else
            Debug.Log("Player B wins");
    }
}
