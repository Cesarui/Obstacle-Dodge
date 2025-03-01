using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Logic to track when player hits an object and how many times
    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits);
    }

}
