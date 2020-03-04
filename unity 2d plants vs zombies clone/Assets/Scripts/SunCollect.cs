using UnityEngine;
using System.Collections;

public class SunCollect : MonoBehaviour {
    // Global score
    public static int score = 600;

    void OnMouseDown()
    {
        // Increase Score
        score += 25;

        // Destroy Sun
        Destroy(gameObject);
    }

}